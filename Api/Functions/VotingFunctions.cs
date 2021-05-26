using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using SeasonVoting.Api.Models.Voting;
using SeasonVoting.Api.Repositories;

namespace SeasonVoting.Api.Functions
{
    public static class VotingFunctions
    {
        [FunctionName("CreateBallot")]
        public static IActionResult CreateBallot(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "Voting/CreateBallot/{seriesId}/{voterName}")] HttpRequest req, ILogger log, string seriesId, string voterName)
        {
            var votingService = new SeriesVotingRepository();
            var seriesService = new SeriesRepository();
            var seriesObjectId = new ObjectId(seriesId);

            // Check voter hasn't already cast vote
            var previousVote = votingService.GetBySeriesAndVoter(seriesObjectId, voterName);

            // Get ScheduleSeries for the rules
            var series = seriesService.GetById(seriesObjectId);

            // Create new SeriesVoting object bases on name and ScheduleSeries
            var ballot = new SeriesVoting(voterName, series);
            var ballotVm = SeriesVoting.ToViewModel(ballot);

            return new OkObjectResult(ballotVm);
        }


    }
}
