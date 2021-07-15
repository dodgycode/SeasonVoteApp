using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SeasonVoting.Api.Models.Preparation;
using SeasonVoting.Api.StaticClasses;
using SeasonVoting.Shared.Voting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SeasonVoting.Api.Models.Voting
{
    public class TierVoting
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId TierId { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }

        public List<TrackVoting> Tracks { get; set; }


        #region Public Methods
        public static List<TierVoting> FromScheduleTrackTier(List<ScheduleTrackTier> scheduleTiers)
        {
            var tiers = new List<TierVoting>();
            foreach (var scheduleTier in scheduleTiers)
            {
                tiers.Add(TierVoting.FromScheduleTrackTier(scheduleTier));
            }

            return tiers;
        }

        public static TierVoting FromScheduleTrackTier(ScheduleTrackTier scheduleTier)
        {
            return new TierVoting
            {
                Id = ObjectId.GenerateNewId(),
                TierId = scheduleTier.Id,
                Name= scheduleTier.Name,
                Order = scheduleTier.Order,
                Tracks = new List<TrackVoting>()
            };
        }

        public static List<TierVotingViewModel> ToViewModel(List<TierVoting> tiers, List<ScheduleTrackTier> scheduleTrackTiers)
        {
            var vms = new List<TierVotingViewModel>();
            foreach(var tier in tiers)
            {
                var scheduleTier = scheduleTrackTiers.FirstOrDefault(t => t.Id == tier.TierId);
                vms.Add(ToViewModel(tier, scheduleTier));
            }
            return vms;
        }

        private static TierVotingViewModel ToViewModel(TierVoting tier, ScheduleTrackTier scheduleTrackTier)
        {
            return new TierVotingViewModel
            {
                Id = new ObjectId().ToString(),
                TierId = tier.Id.ToString(),
                Name = tier.Name,
                Tracks = TrackVoting.ToViewModel(tier.Tracks),
                Order = tier.Order,
                Rules = ScheduleTrackTier.ToViewModel(scheduleTrackTier)
            };
        }

        internal static List<TierVoting> FromViewModel(List<TierVotingViewModel> tiers)
        {
            var tierVotings = new List<TierVoting>();
            foreach(var tier in tiers)
            {
                tierVotings.Add(FromViewModel(tier));
            }

            return tierVotings;
        }

        private static TierVoting FromViewModel(TierVotingViewModel tierVm)
        {
            return new TierVoting
            {
                Id = BsonTools.ResolveObjectId(tierVm.Id),
                Order = tierVm.Order,
                Name = tierVm.Name,
                TierId = BsonTools.ResolveObjectId(tierVm.TierId),
                Tracks = TrackVoting.FromViewModel(tierVm.Tracks)
            };
        }
        #endregion
    }
}
