using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.Lambda.Core;
using SeasonVoting.Shared.DynamoDocs;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace InitialiseSeries;

public class Function
{
    private static readonly AmazonDynamoDBClient _client = new AmazonDynamoDBClient();

    public async Task FunctionHandler(ILambdaContext context)
    {
        var allSeries = Series.AllSeries();
        var dynamoDBContext = new DynamoDBContext(_client);
        foreach (var series in allSeries)
        {
            await dynamoDBContext.SaveAsync(series);
        }
    }   
}

