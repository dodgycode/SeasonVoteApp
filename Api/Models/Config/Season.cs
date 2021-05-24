using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SeasonVoting.Api.StaticClasses;
using SeasonVoting.Shared.Config;

namespace SeasonVoting.Api.Models.Config
{
    public class Season
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonRequired]
        public string Name { get; set; }

        [BsonRequired]
        public int Year { get; set; }

        [BsonRequired]
        public int Quarter { get; set; }

        [BsonRequired]
        public int Order { get; set; }

        [BsonRequired]
        [BsonRepresentation(BsonType.Boolean)]
        public bool IsComplete { get; set; }
        //public List<Series> SeriesVoting { get; set; }

        #region Public Methods

        public static SeasonViewModel ToViewModel(Season season)
        {
            return new SeasonViewModel
            {
                Id = season.Id.ToString(),
                Name = season.Name,
                Year = season.Year,
                Quarter = season.Quarter,
                IsComplete = season.IsComplete
            };
        }

        public static Season FromViewModel(SeasonViewModel vm)
        {
            return new Season
            {
                Id = BsonTools.ResolveObjectId(vm.Id),
                Name = vm.Name,
                Year = vm.Year,
                Quarter = vm.Quarter,
                IsComplete = vm.IsComplete
            };
        }

        public Season CreateNextSeason()
        {
            this.IsComplete = true;
            var newSeason = new Season
            {
                Id = new ObjectId(),
                Year = GetNextYear(),
                Quarter = GetNextQuarter(),
                Name = $"{Year} S{Quarter}",
                Order = this.Order + 1,
                IsComplete = false,
            };
            return newSeason;
        }
        #endregion

        #region Private Methods
        private int GetNextYear()
        {
            if(this.Quarter == 4)
            {
                return this.Year + 1;
            }
            return this.Year;
        }

        private int GetNextQuarter()
        {
            if(this.Quarter == 4)
            {
                return 1;
            }
            return this.Quarter + 1;
        }
        #endregion
    }
}
