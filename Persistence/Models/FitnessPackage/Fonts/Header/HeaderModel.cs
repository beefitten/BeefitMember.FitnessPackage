using MongoDB.Bson.Serialization.Attributes;

namespace Persistence.Models.FitnessPackage.Fonts.H1
{
    public class HeaderModel
    {
        [BsonElement("Size")]
        [BsonRequired]
        public string Size { get; set; }
        
        [BsonElement("Weight")]
        [BsonRequired]
        public string Weight { get; set; }
        
        [BsonElement("Family")]
        [BsonRequired]
        public string Family { get; set; }
    }
}