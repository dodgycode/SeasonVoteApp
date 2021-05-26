using System.Collections.Generic;

namespace SeasonVoting.Shared.Voting
{
    public class TierVotingViewModel
    {
        public string Id { get; set; }

        public string TierId { get; set; }
        
        public string Name { get; set; }

        public List<TrackVotingViewModel> Tracks { get; set; }
    }
}
