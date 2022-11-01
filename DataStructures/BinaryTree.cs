using System.Collections.Generic;
using System;
namespace DataStructures;

public class Node<T> where T : IComparable
{
    private T data;
    public Node<T> Left, Right;

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

    public string PreOrder(ref string buff, Node<T>? node = null)
    {
        if (node == null)
        {
            node = this.root;
        }

        buff = buff + node.Data.ToString() + ", ";

        if (node.Left != null)
        {
            this.PreOrder(ref buff, node.Left);
        }

        if (node.Right != null)
        {
            this.PreOrder(ref buff, node.Right);
        }

        return buff;
    }

    public string InOrder(ref string buff, Node<T>? node = null)
    {
        if (node == null)
        {
            node = this.root;
        }

        if (node.Left != null)
        {
            this.InOrder(ref buff, node.Left);
        }

        buff = buff + node.Data.ToString() + ", ";

        if (node.Right != null)
        {
            this.InOrder(ref buff, node.Right);
        }


        return buff;
    }

    public string PostOrder(ref string buff, Node<T>? node = null)
    {
        if (node == null)
        {
            node = this.root;
        }

        if (node.Left != null)
        {
            this.PostOrder(ref buff, node.Left);
        }

        if (node.Right != null)
        {
            this.PostOrder(ref buff, node.Right);
        }

        buff = buff + node.Data.ToString() + ", ";

        return buff;
    }

}

