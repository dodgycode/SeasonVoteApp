using Amazon.Lambda.Core;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace InitialiseSeries;

public class Function
{
    private static readonly AmazonDynamoDBClient _client = new AmazonDynamoDBClient();

    public async Task FunctionHandler(ILambdaContext context)
    {
        var allSeries = GetSeries();
        var dynamoDBContext = new DynamoDBContext(_client);

        foreach (var series in allSeries)
        {
            await dynamoDBContext.SaveAsync(series);
        }
    }

    private List<Series> GetSeries()
    {
        return new List<Series>
        {
            new Series
            {
                Name = "Formula Renault 3.5",
                Discipline = SeriesDiscipline.Road,
                Description = "Where Ricciardo made his start"
            }
        };
    }
}

[DynamoDBTable("SeasonVoting_Series")]
public class Series
{
    [DynamoDBHashKey] public string Name { get; set; }
    [DynamoDBRangeKey] public SeriesDiscipline Discipline { get; set; }
    [DynamoDBProperty] public string? Description { get; set; }
}

public enum SeriesDiscipline
{
    Road,
    Oval,
    DirtRoad,
    DirtOval,
    RoadAndOval
}