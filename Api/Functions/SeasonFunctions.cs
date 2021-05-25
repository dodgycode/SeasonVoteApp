using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using Newtonsoft.Json;
using SeasonVoting.Api.Models.Config;
using SeasonVoting.Api.Repositories;
using System.IO;

namespace SeasonVoting.Api.Functions
{
    public static class SeasonFunctions
    {
        #region Functions
        [FunctionName("GetCurrentSeason")]
        public static IActionResult GetCurrentSeason(
           [HttpTrigger(AuthorizationLevel.Function, "get", Route = "Season/GetCurrent")] HttpRequest req, ILogger log)
        {
            var service = new SeasonRepository();
            var currentSeason = service.GetCurrentSeason();
            if (currentSeason == null)
            {
                currentSeason = new Season
                {
                    Id = new ObjectId(),
                    Name = "2008 S1",
                    Year = 2008,
                    Quarter = 1,
                    Order = 1,
                    IsComplete = false
                };
                service.Create(currentSeason);
            }

            var vm = Season.ToViewModel(currentSeason);
            return new OkObjectResult(vm);
        }

        [FunctionName("CompleteCurrentSeason")]
        public static IActionResult CompleteCurrentSeason(
        [HttpTrigger(AuthorizationLevel.Function, "post", Route = "Season/Complete")] HttpRequest req, ILogger log)
        {
            var content = new StreamReader(req.Body).ReadToEnd();
            var obj = JsonConvert.DeserializeObject<string>(content);
            var id = new ObjectId(obj);
            var service = new SeasonRepository();

            var currentSeason = service.GetById(id);
            currentSeason.IsComplete = true;
            service.Update(id, currentSeason);

            var nextSeason = currentSeason.CreateNextSeason();
            Season seasonThatCouldBeNextOne = service.GetByYearAndQuarter(nextSeason.Year, nextSeason.Quarter);
            if(seasonThatCouldBeNextOne == null)
            {
                service.Create(nextSeason); // Does not yet exist, create it.
            }

            return new OkResult();
        }

        #endregion

    }
}
