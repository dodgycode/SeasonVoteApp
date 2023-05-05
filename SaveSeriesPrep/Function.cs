using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.Lambda.Core;
using SeasonVoting.Shared.DynamoDocs;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace SaveSeriesPrep;

public class Function
{
    private static readonly AmazonDynamoDBClient _client = new AmazonDynamoDBClient();

    public async Task FunctionHandler(ILambdaContext context)
    {
        var example = Preparation.Example();
        var dynamoDBContext = new DynamoDBContext(_client);
        await dynamoDBContext.SaveAsync(example);

        example.Series = "VRS GT3 Sprint";
        await dynamoDBContext.SaveAsync(example);

        example.Series = "Skippy";
        await dynamoDBContext.SaveAsync(example);
    }
}
