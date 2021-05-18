using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using Newtonsoft.Json;
using SeasonVoting.Api.Repositories;
using SeasonVoting.Shared;
using System;
using System.IO;
using System.Linq;

namespace SeasonVoting.Api.Functions
{
    public static class CurrentSeasonFunction
    {
        [FunctionName("CurrentSeason")]
        public static IActionResult GetCurrentSeason(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req, ILogger log)
        {
            var service = new SeasonRepository();
            var seasons =  service.GetAll();
            var now = DateTime.UtcNow;
            var currentSeason = seasons.FirstOrDefault(s => s.StartDate <= now && !s.IsComplete);
            if (currentSeason != null)
            {
                var vm = new SeasonViewModel { Id = currentSeason.Id.ToString(), Name = currentSeason.Name };
                return new OkObjectResult(vm);
            }

            return new NoContentResult();
        }

        [FunctionName("FinishCurrentSeason")]
        public static IActionResult FinishCurrentSeason(
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
    }
}
