using System.Collections.Generic;
using System.Linq;

namespace SeasonVoting.Shared.Voting
{
    public class SeriesVotingViewModel
    {
        public string Id { get; set; }

        public string SeriesId { get; set; }

        public string SeasonId { get; set; }

        public string VoterName { get; set; }

        public List<TierVotingViewModel> Tiers { get; set; }
    }
}
