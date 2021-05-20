using System.Collections.Generic;

namespace SeasonVoting.Shared.Config
{
    public class TrackViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Availability { get; set; }
        public string Url { get; set; }
        public int NumberOfVariants { get; set; }
        public List<TrackVariantViewModel> Variants { get; set; } = new List<TrackVariantViewModel>();
    }

}
