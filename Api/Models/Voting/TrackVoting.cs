using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SeasonVoting.Api.Models.Preparation;
using SeasonVoting.Api.StaticClasses;
using SeasonVoting.Shared.Voting;
using System;
using System.Collections.Generic;

namespace SeasonVoting.Api.Models.Voting
{
    public class TrackVoting
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId TrackId { get; set; }

        public string Name { get; set; }

        public int? Order { get; set; }

        #region Public Methods
        public static List<TrackVoting> FromScheduleTrack(List<ScheduleTrack> scheduleTracks)
        {
            var tracks = new List<TrackVoting>();
            foreach(var scheduleTrack in scheduleTracks)
            {
                tracks.Add(TrackVoting.FromScheduleTrack(scheduleTrack));
            }
            return tracks;
        }

        public static TrackVoting FromScheduleTrack(ScheduleTrack scheduleTrack)
        {
            return new TrackVoting
            {
                TrackId = scheduleTrack.Id,
                Name = scheduleTrack.Name
            };
        }

        public static List<TrackVotingViewModel> ToViewModel(List<TrackVoting> tracks)
        {
            var vms = new List<TrackVotingViewModel>();
            foreach(var track in tracks)
            {
                vms.Add(TrackVoting.ToViewModel(track));
            }

            return vms;
        }

        public static TrackVotingViewModel ToViewModel(TrackVoting track)
        {
            return new TrackVotingViewModel
            {
                Name = track.Name,
                Order = track.Order,
                TrackId = track.TrackId.ToString()
            };
        }

        internal static List<TrackVoting> FromViewModel(List<TrackVotingViewModel> tracks)
        {
            var trackVotings = new List<TrackVoting>();
            foreach(var track in tracks)
            {
                trackVotings.Add(FromViewModel(track));
            }
            return trackVotings;
        }

        private static TrackVoting FromViewModel(TrackVotingViewModel vm)
        {
            return new TrackVoting
            {
                Name = vm.Name,
                TrackId = BsonTools.ResolveObjectId(vm.TrackId),
                Order = vm.Order
            };
        }
        #endregion
    }
}
