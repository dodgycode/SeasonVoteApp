using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SeasonVoting.Api.Enums;
using SeasonVoting.Api.Models.Config;
using SeasonVoting.Api.StaticClasses;
using SeasonVoting.Shared.Preparation;
using System.Collections.Generic;

namespace SeasonVoting.Api.Models.Preparation
{
    public class ScheduleTrack
    {
        [BsonRequired]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonRequired]
        public string Name { get; set; }

        [BsonRequired]
        [BsonRepresentation(BsonType.Int32)]
        public TrackAvailability TrackAvailability { get; set; }

        public TrackVariant Variant { get; set; }

        #region Public Methods
        public static List<ScheduleTrackViewModel> ToViewModel(List<ScheduleTrack> tracks)
        {
            var scheduletracks = new List<ScheduleTrackViewModel>();
            foreach (var track in tracks)
            {
                scheduletracks.Add(ScheduleTrack.ToViewModel(track));
            }
            return scheduletracks;
        }
        public static ScheduleTrackViewModel ToViewModel(ScheduleTrack track)
        {
            var vm = new ScheduleTrackViewModel
            {
                TrackId = BsonTools.ResolveObjectId(track.Id).ToString(),
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
                Id = BsonTools.ResolveObjectId(vm.TrackId),
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
