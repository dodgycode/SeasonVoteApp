using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SeasonVoting.Api.Enums;

namespace SeasonVoting.Api.Models
{
    public class TrackVariant
    {
        [BsonRequired]
        public string Name { get; set; }

        [BsonRepresentation(BsonType.Int32)]
        public TrackType TrackType { get; set; }
    }
}
