using Amazon.Lambda.Core;
using AWS.Lambda.Powertools.Logging;
using AWS.Lambda.Powertools.Tracing;
using SeasonVoting.Shared.Preparation;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace Lambda.Functions;

/// <summary>
/// Learn more about Lambda Powertools at https://awslabs.github.io/aws-lambda-powertools-dotnet/
/// Lambda Powertools Logging: https://awslabs.github.io/aws-lambda-powertools-dotnet/core/logging/
/// Lambda Powertools Tracing: https://awslabs.github.io/aws-lambda-powertools-dotnet/core/tracing/
/// Lambda Powertools Metrics: https://awslabs.github.io/aws-lambda-powertools-dotnet/core/metrics/
/// Metrics Namespace and Service can be defined through Environment Variables https://awslabs.github.io/aws-lambda-powertools-dotnet/core/metrics/#getting-started
/// </summary>
public class SeriesFunctions
{

    /// <summary>
    /// A simple function that takes a string and does a ToUpper
    /// </summary>
    /// <param name="input"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    [Logging(LogEvent = true)]
    [Tracing]
    public List<ScheduleSeriesViewModel> GetCurrentSeries(ILambdaContext context)
    {
        var seriesList = new List<ScheduleSeriesViewModel>
        {
            new ScheduleSeriesViewModel
            {
                Id = "testId",
                Name = "Formula Renault 3.5",
                Description = "Probably best series on the service",
                SeasonId = "ten",
                Tiers = new List<ScheduleTierViewModel>()
            }
        };

        return seriesList;
    }

}
