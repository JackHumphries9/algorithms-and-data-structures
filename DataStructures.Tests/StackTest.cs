namespace DataStructures.Tests;

public class StackTest
{
    [Fact]
    public void TestPush()
    {
        DataStructures.Stack<int> teststack = new DataStructures.Stack<int>();

        teststack.Push(10);
        Assert.True(teststack.Peek() == 10, "Should add item and peek the item");
    }

    [Fact]
    public void TestPeek()
    {
        DataStructures.Stack<int> teststack = new DataStructures.Stack<int>();

        teststack.Push(10);
        teststack.Push(20);
        teststack.Push(30);

        Assert.True(teststack.Peek() == 30, "Should be the last item in which is 30");
    }

    [Fact]
    public void TestPop()
    {
        DataStructures.Stack<int> teststack = new DataStructures.Stack<int>();

        teststack.Push(10);
        teststack.Push(20);
        teststack.Push(30);

        teststack.Pop();

        Assert.True(teststack.Peek() == 20);
    }
}