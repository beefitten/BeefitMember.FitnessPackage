using MongoDB.Bson.Serialization.Attributes;

namespace Persistence.Models.FitnessPackage.CenterInformation
{
    public class CenterInformationModel
    {
        [BsonElement("HasHeatmap")]
        [BsonRequired]
        public bool HasHeatmap { get; set; }
    }
}