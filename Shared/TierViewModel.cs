using System.Collections.Generic;

namespace SeasonVoting.Shared
{
    public class TierViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int NumberToBeSelectedFromTier { get; set; }
        public List<TrackViewModel> Tracks { get; set; } = new List<TrackViewModel>();
    }
    
}
