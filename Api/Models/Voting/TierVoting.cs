using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SeasonVoting.Api.Models.Preparation;
using SeasonVoting.Shared.Voting;
using System;
using System.Collections.Generic;

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
                Tracks = TrackVoting.FromScheduleTrack(scheduleTier.Tracks)
            };
        }

        public static List<TierVotingViewModel> ToViewModel(List<TierVoting> tiers)
        {
            var vms = new List<TierVotingViewModel>();
            foreach(var tier in tiers)
            {
                vms.Add(TierVoting.ToViewModel(tier));
            }
            return vms;
        }

        private static TierVotingViewModel ToViewModel(TierVoting tier)
        {
            return new TierVotingViewModel
            {
                Id = new ObjectId().ToString(),
                TierId = tier.Id.ToString(),
                Name = tier.Name,
                Tracks = TrackVoting.ToViewModel(tier.Tracks)
            };
        }
        #endregion
    }
}
