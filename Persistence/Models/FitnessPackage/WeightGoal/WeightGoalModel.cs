using MongoDB.Bson.Serialization.Attributes;

namespace Persistence.Models.FitnessPackage.WeightGoal
{
    public class WeightGoalModel
    {
        [BsonElement("ImagePath")]
        [BsonRequired]
        public string ImagePath { get; set; }
        
    }
}