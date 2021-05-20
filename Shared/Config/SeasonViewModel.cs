using System;

namespace SeasonVoting.Shared.Config
{
    public class SeasonViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsComplete { get; set; }
    }

}
