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
using System;
using System.IO;
using System.Linq;

namespace SeasonVoting.Api.Functions
{
    public static class SeasonFunctions
    {
        [FunctionName("GetCurrentSeason")]
        public static IActionResult GetCurrentSeason(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req, ILogger log)
        {
            var service = new SeasonRepository();
            var seasons =  service.GetAllIncomplete();
            var now = DateTime.UtcNow;
            var currentSeason = seasons.OrderBy(s=>s.StartDate).FirstOrDefault();
            if (currentSeason != null)
            {
                var vm = ToViewModel(currentSeason);
                return new OkObjectResult(vm);
            }

            return new NoContentResult();
        }

        [FunctionName("GetDefaultNextSeason")]
        public static IActionResult GetDefaultNextSeason(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req, ILogger log)
        {
            var service = new SeasonRepository();
            var seasons =  service.GetAll();
            var now = DateTime.UtcNow;
            var lastSeason = seasons.OrderByDescending(s=>s.EndDate).FirstOrDefault(s => s.IsComplete);
            var seasonVm = new SeasonViewModel { StartDate = DateTime.UtcNow, IsComplete = false };
            if (lastSeason != null)
            {
                seasonVm.StartDate = lastSeason.EndDate;
            }
            seasonVm.EndDate = lastSeason.EndDate.AddDays(84); // 12 weeks

            return new OkObjectResult(seasonVm);
        }

        [FunctionName("CompleteCurrentSeason")]
        public static IActionResult CompleteCurrentSeason(
        [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req, ILogger log)
        {
            var content = new StreamReader(req.Body).ReadToEnd();
            var obj = JsonConvert.DeserializeObject<string>(content);
            var id = new ObjectId(obj);

            var service = new SeasonRepository();
            var season = service.GetById(id);
            season.IsComplete = true;
            service.Update(id, season);
            return new OkResult();
        }

        [FunctionName("AddSeason")]
        public static IActionResult AddSeason(
        [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req, ILogger log)
        {
            var content = new StreamReader(req.Body).ReadToEnd();
            var vm = JsonConvert.DeserializeObject<SeasonViewModel>(content);
            var season = ToEntity(vm);

            var service = new SeasonRepository();
            service.Create(season);
            return new OkResult();
        }

        private static SeasonViewModel ToViewModel(Season season)
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

        private static Season ToEntity(SeasonViewModel vm)
        {
            return new Season
            {
                Name = vm.Name,
                StartDate = vm.StartDate,
                EndDate = vm.EndDate,
                IsComplete = vm.IsComplete
            };
        }
    }
}
