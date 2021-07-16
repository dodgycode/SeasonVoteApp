using SeasonVoting.Shared.Preparation;
using System.Collections.Generic;

namespace SeasonVoting.Shared.Voting
{
    public class TierVotingViewModel
    {
        public string Id { get; set; }

        public string TierId { get; set; }
        
        public string Name { get; set; }
        public int Order { get; set; }

        public List<TrackVotingViewModel> Tracks { get; set; }

        public ScheduleTierViewModel Rules { get; set; }

        public string PleaseSelectXManyTracksMessage()
        {
            string message = null;
            if (TierVotingComplete)
            {
                message = "You have completed voting for this tier.";
            }
            else
            {
                var votesRemaining = Rules.NumberToBeVotedOn - Tracks.Count;
                if (votesRemaining > 0)
                {
                    message = $"Please select {votesRemaining} ";
                    var tracks = votesRemaining > 1 ? "tracks." : "track.";
                    message += tracks;
                }
            }
            return message;
        }

        public bool TierVotingComplete => Rules.NumberToBeVotedOn == Tracks.Count;
    }
}
