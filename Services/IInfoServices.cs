using GridFSCreateEditAndDisplay.Models;
using MongoDB.Bson.Serialization.Serializers;

namespace GridFSCreateEditAndDisplay.Services
{
    public interface IInfoServices
    {
        List<ImageInfo> GetAll();
        ImageInfo Get(string id);
        Image Create(Image info);
        void Update(string id, ImageInfo info);
    }
}
