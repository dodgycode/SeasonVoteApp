using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SeasonVoting.Api.StaticClasses;
using SeasonVoting.Shared.Preparation;
using System;
using System.Collections.Generic;

namespace SeasonVoting.Api.Models.Preparation
{
    public class TrackTier
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonRequired]
        public string Name { get; set; }

        public int NumberToBeSelectedFromTier { get; set; }

        public List<ScheduleTrack> Tracks { get; set; } = new List<ScheduleTrack>();

        #region Public Methods
        public static TierViewModel ToViewModel(TrackTier tier)
        {
            var tierVm = new TierViewModel
            {
                Id = BsonTools.ResolveObjectId(tier.Id).ToString(),
                Name = tier.Name,
                NumberToBeSelectedFromTier = tier.NumberToBeSelectedFromTier,
            };
            if (tier.Tracks == null) { tier.Tracks = new List<ScheduleTrack>(); }
            foreach (var track in tier.Tracks)
            {
                tierVm.Tracks.Add(ScheduleTrack.ToViewModel(track));
            }

            return tierVm;
        }

        internal static TrackTier FromViewModel(TierViewModel vm)
        {
            return new TrackTier
            {
                Id = BsonTools.ResolveObjectId(vm.Id),
                Name = vm.Name,
                NumberToBeSelectedFromTier = vm.NumberToBeSelectedFromTier,
                Tracks = ScheduleTrack.FromViewModel(vm.Tracks)
            };
        }
        #endregion
    }
}
