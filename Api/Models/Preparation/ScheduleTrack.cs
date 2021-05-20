using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SeasonVoting.Api.Enums;
using SeasonVoting.Api.Models.Config;
using SeasonVoting.Api.StaticClasses;
using SeasonVoting.Shared.Preparation;
using System;
using System.Collections.Generic;

namespace SeasonVoting.Api.Models.Preparation
{
    public class ScheduleTrack
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId TrackId { get; set; }

        [BsonRequired]
        public string Name { get; set; }

        [BsonRequired]
        [BsonRepresentation(BsonType.Int32)]
        public TrackAvailability TrackAvailability { get; set; }

        public TrackVariant Variant { get; set; }

        #region Public Methods
        public static ScheduleTrackViewModel ToViewModel(ScheduleTrack track)
        {
            var vm = new ScheduleTrackViewModel
            {
                TrackId = BsonTools.ResolveObjectId(track.TrackId).ToString(),
                Name = track.Name,
                VariantName = track.Variant.Name,
                Availability = EnumTools.ToViewModel(track.TrackAvailability),
                TrackType = EnumTools.ToViewModel(track.Variant.TrackType)
            };
            return vm;
        }

        internal static List<ScheduleTrack> FromViewModel(List<ScheduleTrackViewModel> vm)
        {
            var scheduletracks = new List<ScheduleTrack>();
            foreach (var vmTrack in vm)
            {
                scheduletracks.Add(ScheduleTrack.FromViewModel(vmTrack));
            }
            return scheduletracks;
        }

        internal static ScheduleTrack FromViewModel(ScheduleTrackViewModel vm)
        {
            return new ScheduleTrack
            {
                TrackId = BsonTools.ResolveObjectId(vm.TrackId),
                Name = vm.Name,
                TrackAvailability = EnumTools.FromTrackAvailabilityString(vm.Availability),
                Variant = new TrackVariant {
                    Name = vm.Name,
                    TrackType = EnumTools.FromTrackTypeString(vm.TrackType)
                }
            };
        }
        #endregion
    }
}
