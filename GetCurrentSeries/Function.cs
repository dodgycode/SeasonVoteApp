using Amazon.Lambda.Core;
using SeasonVoting.Shared.Preparation;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace GetCurrentSeries;

public class Function
{
    public List<ScheduleSeriesViewModel> FunctionHandler(ILambdaContext context)
    {
        var seriesList = new List<ScheduleSeriesViewModel>
        {
            new ScheduleSeriesViewModel
            {
                Id = "testId",
                Name = "Formula Renault 3.5",
                Description = "Probably best series on the service",
                SeasonId = "2023_S3",
                Tiers = new List<ScheduleTierViewModel>()
            },
            new ScheduleSeriesViewModel
            {
                Id = "testId2",
                Name = "VRS GT Sprint",
                Description = "GT3 Cars",
                SeasonId = "2023_S3",
                Tiers = new List<ScheduleTierViewModel>()
            }
        };

        return seriesList;
    }
}
