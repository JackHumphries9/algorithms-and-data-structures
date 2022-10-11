namespace DataStructures.Tests;

public class StackTest
{
    [Fact]
    public void Test1()
    {
        var temp = new DataStructures.Stack();
        var res = temp.add(2, 4);

        Assert.True(res == 6, "2 + 4 should equal 6");
    }
}