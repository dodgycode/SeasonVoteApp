﻿using System.Collections.Generic;

namespace SeasonVoting.Shared.Preparation
{
    public class SeriesViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SeasonId { get; set; }
        public List<TierViewModel> Tiers { get; set; } = new List<TierViewModel>();
    }
    
}