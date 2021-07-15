using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using Newtonsoft.Json;
using SeasonVoting.Api.Models.Voting;
using SeasonVoting.Api.Repositories;
using SeasonVoting.Shared.Voting;
using System.IO;

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
            var ballotVm = SeriesVoting.ToViewModel(ballot, series);

            return new OkObjectResult(ballotVm);
        }

        [FunctionName("SubmitVote")]
        public static IActionResult SubmitVote(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = "Voting/SubmitVote")] HttpRequest req, ILogger log)
        {
            var content = new StreamReader(req.Body).ReadToEnd();
            var vm = JsonConvert.DeserializeObject<SeriesVotingViewModel>(content);
            var seriesVoting = SeriesVoting.FromViewModel(vm);
            var votingService = new SeriesVotingRepository();
            var seriesObjectId = new ObjectId(vm.SeriesId);

            // Check voter hasn't already cast vote
            var previousVote = votingService.GetBySeriesAndVoter(seriesObjectId, vm.VoterName);

            // Add the ballot!
            votingService.Create(seriesVoting);

            return new OkResult();
        }


    }
}
