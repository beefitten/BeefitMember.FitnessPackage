using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using Persistence.Models.FitnessPackage.Overview;

namespace Persistence.Models.FitnessPackage.Bookings
{
    public class BookingsModel
    {
        [BsonElement("TopPicPath")]
        [BsonRequired]
        public string TopPicPath { get; set; }
        
        [BsonElement("Bookings")]
        [BsonRequired]
        public List<Bookings> Bookings { get; set; }
        
        [BsonElement("ShowLocation")]
        [BsonRequired]
        public bool ShowLocation { get; set; }
    }
}