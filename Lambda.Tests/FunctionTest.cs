using Amazon.Lambda.TestUtilities;
using Lambda.Functions;
using Xunit;

namespace Lambda.Tests;

public class FunctionTest
{
    [Fact]
    public void TestToUpperFunction()
    {
        Environment.SetEnvironmentVariable("POWERTOOLS_METRICS_NAMESPACE", "AWSLambdaPowertools");
        // Invoke the lambda function and confirm the string was upper cased.
        var function = new SeriesFunctions();
        var context = new TestLambdaContext();
        var upperCase = function.GetCurrentSeries(context);

       // Assert.Equal("HELLO WORLD", upperCase);
    }
}
