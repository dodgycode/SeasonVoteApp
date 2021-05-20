using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SeasonVoting.Api.StaticClasses;
using SeasonVoting.Shared.Preparation;
using System.Collections.Generic;

namespace SeasonVoting.Api.Models.Preparation
{
    public class Series
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonRequired]
        public string Name { get; set; }

        public string Description { get; set; }

        [BsonRequired]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId SeasonId { get; set; }

        public List<TrackTier> TrackTiers { get; set; } = new List<TrackTier>();

        #region Public Methods
        public static SeriesViewModel ToViewModel(Series series)
        {
            var vm = new SeriesViewModel
            {
                Id = series.Id.ToString(),
                Name = series.Name,
                Description = series.Description,
                SeasonId = series.SeasonId.ToString(),
            };

            if (series.TrackTiers == null) { series.TrackTiers = new List<TrackTier>(); }
            foreach (var tier in series.TrackTiers)
            {
                vm.Tiers.Add(TrackTier.ToViewModel(tier));
            }
            return vm;
        }

        public static Series FromViewModel(SeriesViewModel vm)
        {
            var series = new Series
            {
                Id = BsonTools.ResolveObjectId(vm.Id),
                Name = vm.Name,
                Description = vm.Description,
                SeasonId = new ObjectId(vm.SeasonId)
            };

            foreach (var tier in vm.Tiers)
            {
                series.TrackTiers.Add(new TrackTier
                {
                    Id = BsonTools.ResolveObjectId(tier.Id),
                    Name = tier.Name,
                    NumberToBeSelectedFromTier = tier.NumberToBeSelectedFromTier
                });

            }
            return series;
        }
        #endregion
    }
}
