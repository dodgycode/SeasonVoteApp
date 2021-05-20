using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SeasonVoting.Api.Enums;
using SeasonVoting.Shared.Config;

namespace SeasonVoting.Api.Models.Config
{
    public class TrackVariant
    {
        [BsonRequired]
        public string Name { get; set; }

        [BsonRepresentation(BsonType.Int32)]
        public TrackType TrackType { get; set; }

        public static TrackVariantViewModel ToViewModel(TrackVariant variant)
        {
            return new TrackVariantViewModel
            {
                Name = variant.Name,
                TrackType = EnumTools.ToViewModel(variant.TrackType)
            };
        }
    }
}
