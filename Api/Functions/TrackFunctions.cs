using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using SeasonVoting.Api.Enums;
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
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req, ILogger log)
        {
            var service = new TrackRepository();
            var tracks = service.GetAll();
            var vms = new List<TrackViewModel>();
            foreach (var track in tracks)
            {
                vms.Add(ToViewModel(track));
            }

            return new OkObjectResult(vms.ToArray());
        }

        #endregion

        #region Private Methods

        private static TrackViewModel ToViewModel(Track track)
        {
            string availability;

            switch (track.TrackAvailability)
            {
                case TrackAvailability.Free:
                    availability = "Free";
                    break;
                case TrackAvailability.Legacy:
                    availability = "Legacy";
                    break;
                case TrackAvailability.Paid:
                    availability = "Paid";
                    break;
                default:
                    availability = "";
                    break;
            }

            return new TrackViewModel
            {
                Name = track.Name,
                Availability = availability,
                NumberOfVariants = track.Variants.Count,
                Url = track.Url
            };
        }

        #endregion
    }
}
