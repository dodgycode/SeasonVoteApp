using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using SeasonVoting.Api.Models.Config;
using SeasonVoting.Api.Repositories;
using SeasonVoting.Shared.Config;
using System.Collections.Generic;

namespace SeasonVoting.Api.Functions
{
    public static class TrackFunctions
    {
        #region Functions
        [FunctionName("GetAllTracks")]
        public static IActionResult GetAllTracks(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "Track/GetAll")] HttpRequest req, ILogger log)
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

        [FunctionName("GetTrackById")]
        public static IActionResult GetSeriesById(
    [HttpTrigger(AuthorizationLevel.Function, "get", Route = "Track/GetById/{trackId}")] HttpRequest req, ILogger log, string trackId)
        {
            var service = new TrackRepository();
            var track = service.GetById(new ObjectId(trackId));
            var vm = Track.ToViewModel(track);

            return new OkObjectResult(vm);
        }

        [FunctionName("GetSchduleTrackByName")]
        public static IActionResult GetSchduleTrackByName(
    [HttpTrigger(AuthorizationLevel.Function, "get", Route = "Track/GetScheduleTrackByName/{name}")] HttpRequest req, ILogger log, string name)
        {
            var service = new TrackRepository();
            var track = service.GetByName(name);
            var vm = Track.ToViewModel(track);

            return new OkObjectResult(vm);
        }
        #endregion

    }
}
