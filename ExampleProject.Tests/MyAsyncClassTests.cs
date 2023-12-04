using Xunit;

namespace ExampleProject.Tests;

public class MyAsyncClassTests
{
    [Fact]
    public async void TestAsyncMethod()
    {
        var obj = new MyAsyncClass();
        var result = await obj.DoAsyncAction();
        Assert.Equal(1, result);
    }
}
