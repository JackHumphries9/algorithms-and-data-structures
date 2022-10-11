namespace DataStructures.Tests;

public class QueueTest
{
    [Fact]
    public void SubTest()
    {
        var temp = new DataStructures.Queue();
        var res = temp.subtract(4, 2);

        Assert.True(res == 2, "4 - 2 should equal 2");
    }
}