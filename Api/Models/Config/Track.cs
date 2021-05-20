using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SeasonVoting.Api.Enums;
using SeasonVoting.Api.StaticClasses;
using SeasonVoting.Shared.Config;
using System.Collections.Generic;

namespace SeasonVoting.Api.Models.Config
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

        public List<TrackVariant> Variants { get; set; } = new List<TrackVariant>();

        #region Public Methods
        public static TrackViewModel ToViewModel(Track track)
        {
            var vm = new TrackViewModel
            {
                Id = BsonTools.ResolveObjectId(track.Id).ToString(),
                Name = track.Name,
                NumberOfVariants = track.Variants.Count,
                Url = track.Url,
                Availability = EnumTools.ToViewModel(track.TrackAvailability)
            };
            foreach (var variant in track.Variants)
            {
                vm.Variants.Add(TrackVariant.ToViewModel(variant));
            }

            return vm;
        }
        #endregion
    }
}
