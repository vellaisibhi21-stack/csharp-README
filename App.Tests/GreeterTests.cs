using App;
using Xunit;

namespace App.Tests;

public class Feat_1_GreeterTests
{
    [Fact]
    public void Greet_ReturnsExpectedMessage()
    {
        Assert.Equal("Hello, LaneSync!", Greeter.Greet("LaneSync"));
    }
}
