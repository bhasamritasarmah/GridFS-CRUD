using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Security.Cryptography.X509Certificates;

namespace GridFSCreateEditAndDisplay.Models
{
    [BsonIgnoreExtraElements]
    public class ImageInfo
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;
        public ObjectId ImageId { get; set; }
        [BsonElement("image_name")]
        public string ImageName { get; set; } = String.Empty;
        [BsonElement("image_description")]
        public string Description { get; set; } = String.Empty;
    }
}
