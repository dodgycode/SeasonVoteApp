using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using SeasonVoting.Api.Models;
using SeasonVoting.Api.Repositories;
using SeasonVoting.Shared;
using System.Collections.Generic;

namespace SeasonVoting.Api.Functions
{
    public static class TrackFunctions
    {
        #region Functions
        [FunctionName("GetAllTracks")]
        public static IActionResult GetAllTracks(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "Tracks/GetAll")] HttpRequest req, ILogger log)
        {
            var service = new TrackRepository();
            var tracks = service.GetAll();
            var vms = new List<TrackViewModel>();
            foreach (var track in tracks)
            {
                vms.Add(Track.ToViewModel(track));
            }

            return new OkObjectResult(vms.ToArray());
        }

        #endregion

    }
}
