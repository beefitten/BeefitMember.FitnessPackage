using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using Persistence.Models.FitnessPackage.Bookings;
using Persistence.Models.FitnessPackage.CenterInformation;
using Persistence.Models.FitnessPackage.Fonts;
using Persistence.Models.FitnessPackage.More;
using Persistence.Models.FitnessPackage.Overview;
using Persistence.Models.FitnessPackage.WeightGoal;

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
        
        [BsonElement("ThirdColor")]
        [BsonRequired]
        public string ThirdColor { get; set; }
        
        [BsonElement("BackgroundColor")]
        [BsonRequired]
        public string BackgroundColor { get; set; }
        
        [BsonElement("BorderRadius")]
        [BsonRequired]
        public string BorderRadius { get; set; }
        
        [BsonElement("Elevation")]
        [BsonRequired]
        public string Elevation { get; set; }

        [BsonElement("Logo")]
        [BsonRequired]
        public string Logo { get; set; }
        
        [BsonElement("Features")]
        [BsonRequired]
        public List<Features> Features { get; set; }
        
        [BsonElement("Overview")]
        [BsonRequired]
        public OverViewModel OverView { get; set; }

        [BsonElement("WeightGoal")]
        [BsonRequired]
        public WeightGoalModel WeightGoal { get; set; }
        
        [BsonElement("CenterInformation")]
        [BsonRequired]
        public CenterInformationModel CenterInformation { get; set; }
        
        [BsonElement("More")]
        [BsonRequired]
        public MoreModel More { get; set; }
        
        [BsonElement("Fonts")]
        [BsonRequired]
        public FontModel Fonts { get; set; }
        
        [BsonElement("Bookings")]
        [BsonRequired]
        public BookingsModel Bookings { get; set; }
    }
}