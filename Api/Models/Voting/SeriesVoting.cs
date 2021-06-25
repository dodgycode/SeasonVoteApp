using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SeasonVoting.Api.Models.Preparation;
using SeasonVoting.Shared.Voting;
using System;
using System.Collections.Generic;

namespace SeasonVoting.Api.Models.Voting
{
    public class SeriesVoting
    {
        public SeriesVoting(string voterName, ScheduleSeries series)
        {
            VoterName = voterName;
            SeriesId = series.Id;
            SeasonId = series.SeasonId;
            Tiers = TierVoting.FromScheduleTrackTier(series.TrackTiers);
        }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId SeriesId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId SeasonId { get; set; }

        public string VoterName { get; set; }

        public List<TierVoting> Tiers { get; set; }
       
        #region Public Methods

        public static SeriesVotingViewModel ToViewModel(SeriesVoting ballot, ScheduleSeries series)
        {
            return new SeriesVotingViewModel
            {
                Id = ballot.Id.ToString(),
                VoterName = ballot.VoterName,
                SeasonId = ballot.SeasonId.ToString(),
                SeriesId = ballot.SeriesId.ToString(),
                Tiers = TierVoting.ToViewModel(ballot.Tiers, series.TrackTiers)
            };
        } 
        #endregion
    }
}
