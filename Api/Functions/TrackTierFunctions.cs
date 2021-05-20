using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using SeasonVoting.Api.Models;
using SeasonVoting.Api.Repositories;
using SeasonVoting.Api.StaticClasses;
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

        #endregion
    }
}
