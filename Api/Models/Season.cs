using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace SeasonVoting.Api.Models
{
    public class Season
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonRequired]
        public string Name { get; set; }

        [BsonRequired]
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime StartDate { get; set; }

        [BsonRequired]
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime EndDate { get; set; }

        [BsonRequired]
        [BsonRepresentation(BsonType.Boolean)]
        public bool IsComplete { get; set; }
        //public List<Series> SeriesVoting { get; set; }
    }
}
