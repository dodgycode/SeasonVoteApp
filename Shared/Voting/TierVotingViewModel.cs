using SeasonVoting.Shared.Preparation;
using System.Collections.Generic;

namespace SeasonVoting.Shared.Voting
{
    public class TierVotingViewModel
    {
        public string Id { get; set; }

        public string TierId { get; set; }
        
        public string Name { get; set; }

        public List<TrackVotingViewModel> Tracks { get; set; }

        public ScheduleTierViewModel Rules { get; set; }

        public string PleaseSelectXManyTracksMessage()
        {
            var votesRemaining = Rules.NumberToBeVotedOn - Tracks.Count;
            string message = null;
            if (votesRemaining > 0)
            {
                message = $"Please select {votesRemaining} ";
                var tracks = votesRemaining > 1 ? "tracks." : "track.";
                message += tracks;
            }
            else
            {
                message = "You have completed voting for this tier.";
            }
            return message;
        }
    }
}
