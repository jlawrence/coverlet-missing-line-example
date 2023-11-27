using Xunit;

namespace ExampleProject.Tests;

public class MyRecordTests
{
    [Fact]
    public void Constructor()
    {
        var myRecord = new MyRecord(1);
        Assert.Equal(1, myRecord.A);
    }
}
