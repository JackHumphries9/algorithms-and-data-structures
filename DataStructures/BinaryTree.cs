using System.Collections.Generic;
using System;
namespace DataStructures;

public class Node<T> where T : IComparable
{
    private T data;
    public Node<T>? Left, Right;

    public Node(T item)
    {
        data = item;
        Left = null;
        Right = null;
    }
    public T Data
    {
        set { data = value; }
        get { return data; }
    }
}

public class BinaryTree<T> where T : IComparable
{
    protected Node<T>? root;
    public BinaryTree()  //creates an empty tree
    {
        root = null;
    }
    public BinaryTree(Node<T> node)  //creates a tree with node as the root
    {
        root = node;
    }

    public string PreOrder()
    {
        var buffer = "";
        if (this.root != null)
        {
            this.preOrder(ref buffer, this.root);
        }
        buffer = buffer.Substring(0, buffer.Length - 2);
        return buffer;
    }

    private string preOrder(ref string buff, Node<T> node)
    {
        buff = buff + node.Data.ToString() + ", ";

        if (node.Left != null)
        {
            this.preOrder(ref buff, node.Left);
        }

        if (node.Right != null)
        {
            this.preOrder(ref buff, node.Right);
        }

        return buff;
    }

    public string InOrder()
    {
        var buffer = "";
        if (this.root != null)
        {
            this.inOrder(ref buffer, this.root);
        }
        buffer = buffer.Substring(0, buffer.Length - 2);
        return buffer;
    }

    private string inOrder(ref string buff, Node<T> node)
    {
        if (node.Left != null)
        {
            this.inOrder(ref buff, node.Left);
        }

        buff = buff + node.Data.ToString() + ", ";

        if (node.Right != null)
        {
            this.inOrder(ref buff, node.Right);
        }

        return buff;
    }

    public string PostOrder()
    {
        var buffer = "";
        if (this.root != null)
        {
            this.postOrder(ref buffer, this.root);
        }
        buffer = buffer.Substring(0, buffer.Length - 2);
        return buffer;
    }

    private string postOrder(ref string buff, Node<T> node)
    {
        if (node.Left != null)
        {
            this.postOrder(ref buff, node.Left);
        }

        if (node.Right != null)
        {
            this.postOrder(ref buff, node.Right);
        }

        buff = buff + node.Data.ToString() + ", ";

        return buff;
    }

}

