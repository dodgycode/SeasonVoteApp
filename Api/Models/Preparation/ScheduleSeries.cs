using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SeasonVoting.Api.StaticClasses;
using SeasonVoting.Shared.Preparation;
using System.Collections.Generic;

namespace SeasonVoting.Api.Models.Preparation
{
    public class ScheduleSeries
    {
        #region Properties
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonRequired]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId SeasonId { get; set; }

        [BsonRequired]
        public string Name { get; set; }

        public string Description { get; set; }


        public List<ScheduleTrackTier> TrackTiers { get; set; } = new List<ScheduleTrackTier>();
        #endregion

        #region Public Methods
        public static ScheduleSeriesViewModel ToViewModel(ScheduleSeries series)
        {
            var vm = new ScheduleSeriesViewModel
            {
                Id = series.Id.ToString(),
                SeasonId = series.SeasonId.ToString(),
                Name = series.Name,
                Description = series.Description,
                Tiers = ScheduleTrackTier.ToViewModel(series.TrackTiers)
            };
            return vm;
        }

        public static ScheduleSeries FromViewModel(ScheduleSeriesViewModel vm)
        {
            var series = new ScheduleSeries
            {
                Id = BsonTools.ResolveObjectId(vm.Id),
                SeasonId = new ObjectId(vm.SeasonId),
                Name = vm.Name,
                Description = vm.Description,
                TrackTiers = ScheduleTrackTier.FromViewModel(vm.Tiers)
            };
            return series;
        }
        #endregion
    }
}
