namespace DataStructures.Tests;
using DataStructures;

// REFERENCES

// Constructor LinkedList<T>()
// void AddItem(T item);
// void AppendItem(T item);
// string AsString();
// int Length();

public class LinkedListTests
{
    [Fact]
    public void TestAddItem()
    {
        var ll = new LinkedList<int>();

        ll.AddItem(1);

        Assert.True(ll.AsString() == "[1]");
    }
    [Fact]
    public void TestAddItems()
    {
        var ll = new LinkedList<int>();

        ll.AddItem(3);
        ll.AddItem(2);
        ll.AddItem(1);

        Assert.True(ll.AsString() == "[1, 2, 3]");
    }
    [Fact]
    public void TestNumberOfItems()
    {
        var ll = new LinkedList<int>();

        ll.AddItem(3);
        ll.AddItem(2);
        ll.AddItem(1);

        Assert.True(ll.Length() == 3);
    }

    [Fact]
    public void TestIsPresentItem()
    {
        var ll = new LinkedList<int>();

        ll.AddItem(6);
        ll.AddItem(4);
        ll.AddItem(2);

        Assert.True(ll.IsPresentItem(4));
    }

    [Fact]
    public void TestIsntPresentItem()
    {
        var ll = new LinkedList<int>();

        ll.AddItem(6);
        ll.AddItem(4);
        ll.AddItem(2);

        Assert.False(ll.IsPresentItem(8));
    }

    [Fact]
    public void TestIsntPresentItemOnEmpty()
    {
        var ll = new LinkedList<int>();

        Assert.False(ll.IsPresentItem(8));
    }

    [Fact]
    public void TestRemoveItem()
    {
        var ll = new LinkedList<int>();

        ll.AddItem(3);

        ll.RemoveItem(3);

        Assert.True(ll.AsString() == "[]");
    }

    [Fact]
    public void TestRemoveItemMiddle()
    {
        var ll = new LinkedList<int>();

        ll.AddItem(3);
        ll.AddItem(6);
        ll.AddItem(9);

        ll.RemoveItem(6);

        Assert.True(ll.AsString() == "[9, 3]" && ll.Length() == 2);
    }

    [Fact]
    public void TestRemoveItems()
    {
        var ll = new LinkedList<int>();

        ll.AddItem(3);
        ll.AddItem(6);
        ll.AddItem(9);

        ll.RemoveItem(3);
        ll.RemoveItem(9);

        Assert.True(ll.AsString() == "[6]" && ll.Length() == 1);
    }

    [Fact]
    public void TestAppendItem()
    {
        var ll = new LinkedList<int>();

        ll.AppendItem(4);

        Assert.True(ll.AsString() == "[4]" && ll.Length() == 1);
    }
    [Fact]
    public void TestAppendItems()
    {
        var ll = new LinkedList<int>();

        ll.AppendItem(4);
        ll.AppendItem(8);
        ll.AppendItem(12);

        Assert.True(ll.AsString() == "[4, 8, 12]" && ll.Length() == 3);
    }

    // [Fact]
    // public void TestInsertInOrder()
    // {
    //     var ll = new LinkedList<int>();

    //     ll.AppendItem(3);
    //     ll.AppendItem(5);
    //     ll.AppendItem(9);

    //     ll.InsertInOrder(7);

    //     Assert.True(ll.AsString() == "[3, 5, 7, 9]" && ll.Length() == 4);
    // }
    // [Fact]

    // public void TestCheckListInOrder()
    // {
    //     var ll = new LinkedList<int>();

    //     ll.AppendItem(3);
    //     ll.AppendItem(9);
    //     ll.AppendItem(5);

    //     Assert.Throws<InvalidDataException>(() => ll.InsertInOrder(7));
    // }
}