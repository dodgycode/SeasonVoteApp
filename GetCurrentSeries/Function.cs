using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.Lambda.Core;
using SeasonVoting.Shared;
using SeasonVoting.Shared.DynamoDocs;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace GetCurrentSeries;

public class Function
{
    public async Task<List<Preparation>> FunctionHandler(ILambdaContext context)
    {
        var result = new List<Preparation>();
        var dynamoDBContext = new DynamoDBContext(new AmazonDynamoDBClient());
        var query = dynamoDBContext.QueryAsync<Preparation>(hashKeyValue: Seasons.CurrentSeasonId);

        return await query.GetNextSetAsync();
    }
}
