using System.Collections.Generic;

namespace SeasonVoting.Shared
{
    public class SeriesViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SeasonId { get; set; }
        public List<TierViewModel> Tiers { get; set; } = new List<TierViewModel>();
    }
    public class TierViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int NumberToBeSelectedFromTier { get; set; }
    }
    
}
