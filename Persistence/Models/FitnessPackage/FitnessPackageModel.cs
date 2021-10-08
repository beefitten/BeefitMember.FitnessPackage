using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Persistence.Models.FitnessPackage
{
    public class FitnessPackageModel
    {
        [BsonId]
        [BsonRequired]
        [BsonElement("Name")]
        public string Name { get; set; }
        
        [BsonElement("PrimaryColor")]
        [BsonRequired]
        public string PrimaryColor { get; set; }

        [BsonElement("SecondaryColor")]
        [BsonRequired]
        public string SecondaryColor { get; set; }
        
        [BsonElement("Logo")]
        [BsonRequired]
        public string Logo { get; set; }
        
        [BsonElement("Features")]
        [BsonRequired]
        public List<Features> Features { get; set; }
    }
}