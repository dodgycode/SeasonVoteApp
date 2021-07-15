using System.Collections.Generic;

namespace SeasonVoting.Shared.Preparation
{
    public class ScheduleTierViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<ScheduleTrackViewModel> Tracks { get; set; } = new List<ScheduleTrackViewModel>();

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

    }

}
