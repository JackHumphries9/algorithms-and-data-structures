using System;
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

    [Fact]
    public void TestString()
    {

        var testq = new Queue<int>(3);
        testq.Enqueue(2);
        testq.Enqueue(4);
        testq.Enqueue(6);

        Assert.True(testq.AsString() == "2, 4, 6");
    }

    [Fact]
    public void TestCircularForwards()
    {
        var testq = new Queue<int>(3);

        testq.Enqueue(2);
        testq.Enqueue(4);
        testq.Enqueue(6);

        testq.Dequeue();
        testq.Dequeue();

        testq.Enqueue(6);

        Assert.True(testq.Count() == 2);
    }

    [Fact]
    public void TestCircularBackwards()
    {
        var testq = new Queue<int>(3);

        testq.Enqueue(2);
        testq.Enqueue(4);
        testq.Enqueue(6);

        testq.Dequeue();
        testq.Dequeue();

        testq.Enqueue(8);
        testq.Dequeue();

        Assert.True(testq.Dequeue() == 8 && testq.Count() == 0);
    }

    public void Stress()
    {
        var testq = new Queue<int>(3);

        testq.Enqueue(1);
        testq.Enqueue(2);
        testq.Enqueue(3);

        testq.Dequeue();
        testq.Dequeue();
        testq.Dequeue();

        testq.Enqueue(4);
        testq.Enqueue(5);

        testq.Dequeue();
        testq.Dequeue();

        testq.Enqueue(6);
        testq.Enqueue(7);

        testq.Dequeue();
        testq.Dequeue();

        testq.Enqueue(8);

        Assert.True(testq.Count() == 0 && testq.Dequeue() == 8);

    }
}