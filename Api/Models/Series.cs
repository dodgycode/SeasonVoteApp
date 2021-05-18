using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace SeasonVoting.Api.Models
{
    public class Series
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonRequired]
        public string Name { get; set; }

        public string Description { get; set; }

        [BsonRequired]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId SeasonId { get; set; }

        [BsonRepresentation(BsonType.Array)]
        public List<TrackTier> TrackTiers { get; set; }
    }
}
