using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SeasonVoting.Api.Models.Preparation;
using SeasonVoting.Api.Repositories;
using SeasonVoting.Api.StaticClasses;
using SeasonVoting.Shared.Preparation;
using System.IO;
using System.Linq;

namespace SeasonVoting.Api.Functions
{
    public static class TrackTierFunctions
    {
        #region Functions
        [FunctionName("GetTierById")]
        public static IActionResult GetTierById(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "Tier/GetById/{tierId}")] HttpRequest req, ILogger log, string tierId)
        {
            var seasonService = new SeasonRepository();
            var currentSeason = seasonService.GetCurrentSeason();
            var seriesService = new SeriesRepository();
            var series = seriesService.GetBySeasonId(currentSeason.Id);
            var tiers = series.SelectMany(s => s.TrackTiers).ToList();
            var tier = tiers.FirstOrDefault(t => t.Id == BsonTools.ResolveObjectId(tierId));

            var vm = TrackTier.ToViewModel(tier);
            return new OkObjectResult(vm);
        }
        
        [FunctionName("SaveTier")]
        public static IActionResult SaveTier(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = "Tier/Save")] HttpRequest req, ILogger log)
        {
            var content = new StreamReader(req.Body).ReadToEnd();
            var vm = JsonConvert.DeserializeObject<TierViewModel>(content);
            var seasonService = new SeasonRepository();
            var currentSeason = seasonService.GetCurrentSeason();
            var seriesService = new SeriesRepository();
            var series = seriesService.GetBySeasonId(currentSeason.Id);
            var currentSeries = series.FirstOrDefault(s=>s.TrackTiers.Any(t => t.Id == BsonTools.ResolveObjectId(vm.Id)));
            var tier = currentSeries.TrackTiers.FirstOrDefault(t => t.Id == BsonTools.ResolveObjectId(vm.Id));
            currentSeries.TrackTiers.Remove(tier);
            currentSeries.TrackTiers.Add(TrackTier.FromViewModel(vm));

            seriesService.Update(currentSeries.Id, currentSeries);

            return new OkResult();
        }

        #endregion
    }
}
