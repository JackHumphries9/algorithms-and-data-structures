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


    [Fact]
    public void TestIsEmptyTrue()
    {
        DataStructures.Stack<int> teststack = new DataStructures.Stack<int>();

        Assert.True(teststack.IsEmpty());
    }

    [Fact]
    public void TestIsEmptyFalse()
    {
        DataStructures.Stack<int> teststack = new DataStructures.Stack<int>();

        teststack.Push(2);

        Assert.False(teststack.IsEmpty());
    }

    [Fact]
    public void TestIsFullFalse()
    {
        DataStructures.Stack<int> teststack = new DataStructures.Stack<int>();

        teststack.Push(2);

        Assert.False(teststack.IsFull());
    }
    [Fact]
    public void TestIsFullTrue()
    {
        DataStructures.Stack<int> teststack = new DataStructures.Stack<int>(3);

        teststack.Push(2);
        teststack.Push(3);
        teststack.Push(4);


        Assert.True(teststack.IsFull());
    }
    [Fact]
    public void TestNoEmptyPop()
    {
        DataStructures.Stack<int> teststack = new DataStructures.Stack<int>();

        Assert.Throws<IndexOutOfRangeException>(() => teststack.Pop());
    }

    [Fact]
    public void TestFullPush()
    {
        DataStructures.Stack<int> teststack = new DataStructures.Stack<int>(2);

        teststack.Push(1);
        teststack.Push(2);

        Assert.Throws<IndexOutOfRangeException>(() => teststack.Push(3));
    }
}