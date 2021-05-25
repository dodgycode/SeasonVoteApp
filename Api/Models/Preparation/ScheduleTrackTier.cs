using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SeasonVoting.Api.StaticClasses;
using SeasonVoting.Shared.Preparation;
using System.Collections.Generic;

namespace SeasonVoting.Api.Models.Preparation
{
    public class ScheduleTrackTier
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonRequired]
        public string Name { get; set; }

        public List<ScheduleTrack> Tracks { get; set; } = new List<ScheduleTrack>();

        #region Rules
        /// <summary>
        /// How many tracks are to be selected from this teir?
        /// </summary>
        public int NumberToBeSelected { get; set; }

        /// <summary>
        /// How many tracks are voters to select during voting?
        /// </summary>
        public int NumberToBeVotedOn { get; set; }

        /// <summary>
        /// What is the maximum number of times in a year (4 seasons) the track can be run once selected?
        /// </summary>
        public int MaxSeasonsTrackCanRunPerYear { get; set; }

        /// <summary>
        /// What is the maximum number of consecutive seasons the track can run before it's given a break?
        /// </summary>
        public int MaxConsecutiveSeasonsTracksCanRun { get; set; }

        /// <summary>
        /// Once a track is selected, how many seasons should it be locked in for (e.g. Skippy Rotation)?
        /// </summary>
        public int MinConsecutiveSeasonsTrackWillRunOnceSelected { get; set; }

        /// <summary>
        /// Voters should number their choices (e.g. 1,2,3).
        /// </summary>
        public bool SelectionsShouldBeOrdered { get; set; }
        #endregion

        #region Public Methods
        public static List<ScheduleTierViewModel> ToViewModel(List<ScheduleTrackTier> tiers)
        {
            var scheduleTiers = new List<ScheduleTierViewModel>();
            foreach (var tier in tiers)
            {
                scheduleTiers.Add(ToViewModel(tier));
            }
            return scheduleTiers;
        }

        public static ScheduleTierViewModel ToViewModel(ScheduleTrackTier tier)
        {
            var tierVm = new ScheduleTierViewModel
            {
                Id = BsonTools.ResolveObjectId(tier.Id).ToString(),
                Name = tier.Name,
                NumberToBeSelected = tier.NumberToBeSelected,
                NumberToBeVotedOn = tier.NumberToBeVotedOn,
                MaxSeasonsTrackCanRunPerYear = tier.MaxSeasonsTrackCanRunPerYear,
                MaxConsecutiveSeasonsTracksCanRun = tier.MaxConsecutiveSeasonsTracksCanRun,
                MinConsecutiveSeasonsTrackWillRunOnceSelected = tier.MinConsecutiveSeasonsTrackWillRunOnceSelected,
                SelectionsShouldBeOrdered = tier.SelectionsShouldBeOrdered,
                Tracks = ScheduleTrack.ToViewModel(tier.Tracks)
            };

            return tierVm;
        }

        public static List<ScheduleTrackTier> FromViewModel(List<ScheduleTierViewModel> tiers)
        {
            var scheduleTiers = new List<ScheduleTrackTier>();
            foreach (var tier in tiers)
            {
                scheduleTiers.Add(FromViewModel(tier));
            }
            return scheduleTiers;
        }

        public static ScheduleTrackTier FromViewModel(ScheduleTierViewModel vm)
        {
            return new ScheduleTrackTier
            {
                Id = BsonTools.ResolveObjectId(vm.Id),
                Name = vm.Name,
                NumberToBeSelected = vm.NumberToBeSelected,
                NumberToBeVotedOn = vm.NumberToBeVotedOn,
                MaxSeasonsTrackCanRunPerYear = vm.MaxSeasonsTrackCanRunPerYear,
                MaxConsecutiveSeasonsTracksCanRun = vm.MaxConsecutiveSeasonsTracksCanRun,
                MinConsecutiveSeasonsTrackWillRunOnceSelected = vm.MinConsecutiveSeasonsTrackWillRunOnceSelected,
                SelectionsShouldBeOrdered = vm.SelectionsShouldBeOrdered,
                Tracks = ScheduleTrack.FromViewModel(vm.Tracks)
            };
        }
        #endregion
    }
}
