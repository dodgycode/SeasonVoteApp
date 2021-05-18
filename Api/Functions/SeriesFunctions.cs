using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using Newtonsoft.Json;
using SeasonVoting.Api.Models;
using SeasonVoting.Api.Repositories;
using SeasonVoting.Shared;
using System.Collections.Generic;
using System.IO;

namespace SeasonVoting.Api.Functions
{
    public static class SeriesFunctions
    {
        #region Functions
        [FunctionName("GetCurrentSeries")]
        public static IActionResult GetCurrentSeries(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req, ILogger log)
        {
            var seasonService = new SeasonRepository();
            var currentSeason = seasonService.GetCurrentSeason();
            var seriesService = new SeriesRepository();
            var seriesList = seriesService.GetBySeasonId(currentSeason.Id);

            var vms = new List<SeriesViewModel>();
            foreach (var series in seriesList)
            {
                vms.Add(ToViewModel(series));
            }

            return new OkObjectResult(vms.ToArray());
        }

        [FunctionName("AddSeries")]
        public static IActionResult AddSeries(
        [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req, ILogger log)
        {
            var content = new StreamReader(req.Body).ReadToEnd();
            var vm = JsonConvert.DeserializeObject<SeriesViewModel>(content);
            var series = ToEntity(vm);

            var service = new SeriesRepository();
            service.Create(series);
            return new OkResult();
        }

        [FunctionName("ConstructSeries")]
        public static IActionResult ConstructSeries(
         [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req, ILogger log)
        {
            var service = new SeasonRepository();
            var season = service.GetCurrentSeason();
            var series = new Series { Id = ObjectId.GenerateNewId(), SeasonId = season.Id };
            var vm = ToViewModel(series);
            return new OkObjectResult(vm);
        }
        #endregion

        #region Private Methods

        private static SeriesViewModel ToViewModel(Series series)
        {
            return new SeriesViewModel
            {
                Id = series.Id.ToString(),
                Name = series.Name,
                Description = series.Description,
                SeasonId = series.SeasonId.ToString()
            };
        }
        
        private static Series ToEntity(SeriesViewModel vm)
        {
            return new Series
            {
                Id = new ObjectId(vm.Id),
                Name = vm.Name,
                Description = vm.Description,
                SeasonId = new ObjectId(vm.SeasonId)
            };
        }

        #endregion
    }
}
