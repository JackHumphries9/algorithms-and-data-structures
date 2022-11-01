namespace DataStructures.Tests;
using DataStructures;

public class BinarySearchTreeTest
{
    public BinarySearchTree<int> createTestTree1()
    {
        var tree = new BinarySearchTree<int>();

        tree.InsertItem(21);
        tree.InsertItem(7);
        tree.InsertItem(30);
        tree.InsertItem(3);
        tree.InsertItem(9);
        tree.InsertItem(12);
        tree.InsertItem(24);
        tree.InsertItem(39);

        return tree;
    }

    public BinarySearchTree<int> createTestTree2()
    {
        var tree = new BinarySearchTree<int>();

        //[12, 6, 8, 16, 19] 
        tree.InsertItem(12);
        tree.InsertItem(6);
        tree.InsertItem(8);
        tree.InsertItem(16);
        tree.InsertItem(19);

        return tree;
    }

    [Fact]
    public void TestInsertItem()
    {
        var bstree = new BinarySearchTree<int>();
        bstree.InsertItem(12);
        Assert.True(bstree.InOrder() == "12");
    }
    [Fact]
    public void TestInsertItems()
    {
        var bstree = new BinarySearchTree<int>();
        bstree.InsertItem(12);
        bstree.InsertItem(6);
        bstree.InsertItem(18);
        Assert.Equal("6, 12, 18", bstree.InOrder());
    }
    [Fact]
    public void TestHeight1()
    {
        var bstree = createTestTree1();

        Assert.Equal(4, bstree.Height());
    }
    [Fact]
    public void TestCount1()
    {
        var bstree = createTestTree1();

        Assert.Equal(8, bstree.Count());
    }
    [Fact]
    public void TestContains1()
    {
        var bstree = createTestTree1();

        Assert.True(bstree.Contains(9));
    }
    [Fact]
    public void TestNotContains1()
    {
        var bstree = createTestTree1();

        Assert.False(bstree.Contains(4));
    }
    [Fact]
    public void TestHeight2()
    {
        var bstree = createTestTree2();

        Assert.Equal(3, bstree.Height());
    }
    [Fact]
    public void TestCount2()
    {
        var bstree = createTestTree2();

        Assert.Equal(5, bstree.Count());
    }
    [Fact]
    public void TestContains2()
    {
        var bstree = createTestTree2();

        Assert.True(bstree.Contains(19));
    }
    [Fact]
    public void TestNotContains2()
    {
        var bstree = createTestTree2();

        Assert.False(bstree.Contains(4));
    }
}