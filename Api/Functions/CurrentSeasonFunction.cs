using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using SeasonVoting.Api.Repositories;
using SeasonVoting.Shared;
using System;
using System.Linq;

namespace SeasonVoting.Api.Functions
{
    public static class CurrentSeasonFunction
    {
        [FunctionName("CurrentSeason")]
        public static  IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            var service = new SeasonRepository();
            var seasons =  service.GetAll();
            var now = DateTime.UtcNow;
            var currentSeason = seasons.FirstOrDefault(s => s.StartDate <= now && !s.IsComplete);
            if (currentSeason != null)
            {
                var vm = new SeasonViewModel { Name = currentSeason.Name };
                return new OkObjectResult(vm);
            }

            return new NoContentResult();
        }       
    }
}
