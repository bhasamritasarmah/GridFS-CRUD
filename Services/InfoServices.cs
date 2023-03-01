using GridFSCreateEditAndDisplay.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using System.Security.Cryptography.Xml;

namespace GridFSCreateEditAndDisplay.Services
{
    public class InfoServices : IInfoServices
    {
        private readonly IMongoCollection<ImageInfo> _information;
        private readonly GridFSBucket bucket;

        public InfoServices(IDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            bucket = new GridFSBucket(database);
            _information = database.GetCollection<ImageInfo>(settings.InfoCollectionName);
        }
        public Image Create(Image info)
        {
            byte[] imageBytes = null;

            if (info.Photo.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    info.Photo.CopyTo(ms);
                    imageBytes = ms.ToArray();
                }
            }

            ObjectId id = bucket.UploadFromBytes(info.Photo.FileName, imageBytes);

            ImageInfo infoImage = new ImageInfo();
            infoImage.ImageId = id;
            infoImage.ImageName = info.ImageName;
            infoImage.Description= info.Description;
            _information.InsertOne(infoImage);
            return info;
        }

        public ImageInfo Get(string id)
        {
            return _information.Find(p => p.Id == id).FirstOrDefault();
        }

        public List<ImageInfo> GetAll()
        {
            return _information.Find(p => true).ToList();
        }
        public void Update(string id, ImageInfo info)
        {
            _information.ReplaceOne(p => p.Id == id, info);
        }
    }
}
