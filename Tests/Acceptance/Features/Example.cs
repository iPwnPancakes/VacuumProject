using Xunit;

namespace Tests.Acceptance.Features;

public class Example
{
    [Fact]
    public void TestMethod1()
    {
        int a = 10;
        int b = 20;

        Assert.Equal(30, a + b);
    }
}