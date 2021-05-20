using System.Collections.Generic;

namespace SeasonVoting.Shared.Preparation
{
    public class TierViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int NumberToBeSelectedFromTier { get; set; }
        public List<ScheduleTrackViewModel> Tracks { get; set; } = new List<ScheduleTrackViewModel>();
    }
    
}
