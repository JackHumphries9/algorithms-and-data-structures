namespace DataStructures.Tests;
using DataStructures;

public class BinarySearchTreeTest
{
    public Node<Char> createTestTree()
    {
        var root = new Node<Char>('A');
        root.Left = new Node<Char>('B');
        root.Right = new Node<Char>('C');
        root.Left.Left = new Node<Char>('D');
        root.Left.Right = new Node<Char>('E');
        root.Right.Left = new Node<Char>('F');
        root.Right.Right = new Node<Char>('G');
        root.Left.Right.Right = new Node<Char>('H');

        return root;
    }

    [Fact]
    public void TestAssert()
    {
        Assert.True(true);
    }
}