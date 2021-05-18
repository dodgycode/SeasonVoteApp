using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SeasonVoting.Api.Enums;
using System.Collections.Generic;

namespace SeasonVoting.Api.Models
{
    public class Track
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonRequired]
        public string Name { get; set; }

        [BsonRequired]
        public string Url { get; set; }

        [BsonRequired]
        [BsonRepresentation(BsonType.Int32)]
        public TrackAvailability TrackAvailability { get; set; }

        public List<TrackVariant> Variants { get; set; }
    }
}
