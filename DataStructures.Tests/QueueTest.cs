namespace DataStructures.Tests;
using DataStructures;

public class QueueTest
{
    [Fact]
    public void TestEnqueue()
    {
        var testq = new Queue<int>();
        testq.Enqueue(1);

        Assert.True(testq.Peek() == 1);
    }
    [Fact]
    public void TestDequeueReturn()
    {
        var testq = new Queue<int>();
        testq.Enqueue(1);
        testq.Enqueue(2);

        Assert.True(testq.Dequeue() == 1);
    }
    [Fact]
    public void TestDequeue()
    {
        var testq = new Queue<int>();
        testq.Enqueue(1);
        testq.Enqueue(2);
        testq.Dequeue();

        Assert.True(testq.Peek() == 2);
    }
    [Fact]
    public void TestPeek()
    {
        var testq = new Queue<int>();

        Assert.True(testq.Peek() == 0);
    }

    [Fact]
    public void TestIsFull()
    {
        var testq = new Queue<int>(2);
        testq.Enqueue(2);
        testq.Enqueue(4);

        Assert.True(testq.IsFull());
    }
    [Fact]
    public void TestIsFullExc()
    {
        var testq = new Queue<int>(2);
        testq.Enqueue(2);
        testq.Enqueue(4);

        Assert.Throws<IndexOutOfRangeException>(() => testq.Enqueue(6));
    }
    [Fact]
    public void TestIsEmpty()
    {
        var testq = new Queue<int>();
        testq.Enqueue(2);
        testq.Enqueue(4);

        testq.Dequeue();
        testq.Dequeue();

        Assert.True(testq.IsEmpty());
    }
    [Fact]
    public void TestIsEmptyExc()
    {
        var testq = new Queue<int>();
        testq.Enqueue(2);
        testq.Enqueue(4);

        testq.Dequeue();
        testq.Dequeue();

        Assert.Throws<IndexOutOfRangeException>(() => testq.Dequeue());
    }
}