using MongoDB.Bson.Serialization.Attributes;

namespace Persistence.Models.FitnessPackage.More
{
    public class MoreModel
    {
        [BsonElement("HasMoreMenu")]
        [BsonRequired]
        public bool HasMoreMenu { get; set; }
    }
}