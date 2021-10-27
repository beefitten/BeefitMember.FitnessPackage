using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Persistence.Models.FitnessPackage.Overview
{
    public class OverViewModel
    {
        [BsonElement("Overview")]
        [BsonRequired]
        public List<OverView> OverView { get; set; }
    }
}