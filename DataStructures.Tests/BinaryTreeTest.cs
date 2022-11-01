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

        //throw new Exception(buffer);
        Assert.True(tree.PreOrder() == "A, B, D, E, H, C, F, G");
    }
    [Fact]
    public void TestInOrder()
    {
        var root = createTestTree();

        var tree = new BinaryTree<Char>(root);
        Assert.True(tree.InOrder() == "D, B, E, H, A, F, C, G");
    }
    [Fact]
    public void TestPostOrder()
    {
        var root = createTestTree();

        var tree = new BinaryTree<Char>(root);

        Assert.True(tree.PostOrder() == "D, H, E, B, F, G, C, A");
    }

}