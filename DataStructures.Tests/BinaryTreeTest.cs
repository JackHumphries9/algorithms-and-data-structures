namespace DataStructures.Tests;
using DataStructures;

public class BinaryTreeTest
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
    public void TestPreOrder()
    {
        var root = createTestTree();

        var tree = new BinaryTree<Char>(root);
        var buffer = "";
        tree.PreOrder(ref buffer);

        buffer = buffer.Substring(0, buffer.Length - 2);

        //throw new Exception(buffer);
        Assert.True(buffer == "A, B, D, E, H, C, F, G");
    }
    [Fact]
    public void TestInOrder()
    {
        var root = createTestTree();

        var tree = new BinaryTree<Char>(root);
        var buffer = "";
        tree.InOrder(ref buffer);

        buffer = buffer.Substring(0, buffer.Length - 2);
        Assert.True(buffer == "D, B, E, H, A, F, C, G");
    }
    [Fact]
    public void TestPostOrder()
    {
        var root = createTestTree();


        var tree = new BinaryTree<Char>(root);
        var buffer = "";
        tree.PostOrder(ref buffer);

        buffer = buffer.Substring(0, buffer.Length - 2);

        //throw new Exception(buffer);
        Assert.True(buffer == "D, H, E, B, F, G, C, A");
    }

}