using System;

namespace SeasonVoting.Shared.Config
{
    public class SeasonViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int Quarter { get; set; }
        public bool IsComplete { get; set; }
    }

}
