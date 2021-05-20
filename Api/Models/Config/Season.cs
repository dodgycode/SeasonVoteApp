using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SeasonVoting.Api.StaticClasses;
using SeasonVoting.Shared.Config;
using System;

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
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime StartDate { get; set; }

        [BsonRequired]
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime EndDate { get; set; }

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
                StartDate = season.StartDate,
                EndDate = season.EndDate,
                IsComplete = season.IsComplete
            };
        }

        public static Season FromViewModel(SeasonViewModel vm)
        {
            return new Season
            {
                Id = BsonTools.ResolveObjectId(vm.Id),
                Name = vm.Name,
                StartDate = vm.StartDate,
                EndDate = vm.EndDate,
                IsComplete = vm.IsComplete
            };
        }

        #endregion
    }
}
