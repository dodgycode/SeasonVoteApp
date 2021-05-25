using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using Newtonsoft.Json;
using SeasonVoting.Api.Models.Preparation;
using SeasonVoting.Api.Repositories;
using SeasonVoting.Shared;
using SeasonVoting.Shared.Preparation;
using System.Collections.Generic;
using System.IO;

namespace SeasonVoting.Api.Functions
{
    public static class SeriesFunctions
    {
        #region Functions
        [FunctionName("GetCurrentSeries")]
        public static IActionResult GetCurrentSeries(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "Series/GetCurrent")] HttpRequest req, ILogger log)
        {
            var seasonService = new SeasonRepository();
            var currentSeason = seasonService.GetCurrentSeason();
            var seriesService = new SeriesRepository();
            var seriesList = seriesService.GetBySeasonId(currentSeason.Id);

            var vms = new List<ScheduleSeriesViewModel>();
            foreach (var series in seriesList)
            {
                vms.Add(ScheduleSeries.ToViewModel(series));
            }

            return new OkObjectResult(vms.ToArray());
        }
        
        [FunctionName("GetSeriesById")]
        public static IActionResult GetSeriesById(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "Series/GetById/{seriesId}")] HttpRequest req, ILogger log, string seriesId)
        {
            var seriesService = new SeriesRepository();
            var series = seriesService.GetById(new ObjectId(seriesId));
            var vm = ScheduleSeries.ToViewModel(series);
           
            return new OkObjectResult(vm);
        }

        [FunctionName("AddSeries")]
        public static IActionResult AddSeries(
        [HttpTrigger(AuthorizationLevel.Function, "post", Route = "Series/Add")] HttpRequest req, ILogger log)
        {
            var content = new StreamReader(req.Body).ReadToEnd();
            var vm = JsonConvert.DeserializeObject<ScheduleSeriesViewModel>(content);
            var series = ScheduleSeries.FromViewModel(vm);

            var service = new SeriesRepository();
            service.Create(series);
            return new OkResult();
        }
        
        [FunctionName("UpdateSeries")]
        public static IActionResult UpdateSeries(
        [HttpTrigger(AuthorizationLevel.Function, "post", Route = "Series/Update")] HttpRequest req, ILogger log)
        {
            var content = new StreamReader(req.Body).ReadToEnd();
            var vm = JsonConvert.DeserializeObject<ScheduleSeriesViewModel>(content);
            var series = ScheduleSeries.FromViewModel(vm);

            var service = new SeriesRepository();
            service.Update(series.Id, series);
            return new OkResult();
        }

        [FunctionName("ConstructSeries")]
        public static IActionResult ConstructSeries(
         [HttpTrigger(AuthorizationLevel.Function, "get", Route = "Series/Construct")] HttpRequest req, ILogger log)
        {
            var service = new SeasonRepository();
            var season = service.GetCurrentSeason();
            var series = new ScheduleSeries { Id = ObjectId.GenerateNewId(), SeasonId = season.Id };
            var vm = ScheduleSeries.ToViewModel(series);
            return new OkObjectResult(vm);
        }
        #endregion

    }
}
