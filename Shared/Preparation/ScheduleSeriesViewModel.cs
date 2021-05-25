using System.Collections.Generic;

namespace SeasonVoting.Shared.Preparation
{
    public class ScheduleSeriesViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SeasonId { get; set; }
        public List<ScheduleTierViewModel> Tiers { get; set; } = new List<ScheduleTierViewModel>();
    }
    
}
