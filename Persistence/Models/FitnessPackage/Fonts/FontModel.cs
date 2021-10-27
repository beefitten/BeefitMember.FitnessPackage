using MongoDB.Bson.Serialization.Attributes;
using Persistence.Models.FitnessPackage.Fonts.H1;

namespace Persistence.Models.FitnessPackage.Fonts
{
    public class FontModel
    {
        [BsonElement("GeneralFont")]
        [BsonRequired]
        public string GeneralFont { get; set; }
        
        [BsonElement("Header")]
        [BsonRequired]
        public HeaderModel Header { get; set; }
        
        [BsonElement("HeaderTwo")]
        [BsonRequired]
        public HeaderModel HeaderTwo { get; set; }
        
        [BsonElement("HeaderThree")]
        [BsonRequired]
        public HeaderModel HeaderThree { get; set; }
    }
}