using DataStructures;

public class BinarySearchTree<T> : BinaryTree<T> where T : IComparable
{  //root declared as protected in Parent Class – Binary Tree
    public BinarySearchTree()
    {
        this.root = null;
    }

    public void InsertItem(T item)
    {
        insertItem(item, ref root);
    }

    private void insertItem(T item, ref Node<T>? tree)
    {
        if (this.root == null)
        {
            this.root = new Node<T>(item);
            return;
        }

        if (tree == null)
        {
            tree = new Node<T>(item);
            return;
        }

        var comp = tree.Data.CompareTo(item);

        if (comp == 0)
        {
            throw new Exception("Cannot add the same item into a Binary Search Tree");
        }

        if (comp > 0)
        {
            insertItem(item, ref tree.Left);
        }

        if (comp < 0)
        {
            insertItem(item, ref tree.Right);
        }
    }

    public int Height()
    {
        int h = 0;
        int m = 1;
        if (this.root != null)
        {
            this.height(this.root, ref h, ref m);
        }
        return m;
    }

    private int height(Node<T> node, ref int n, ref int m)
    {
        if (node.Left != null)
        {
            this.height(node.Left, ref n, ref m);
        }

        if (node.Right != null)
        {
            this.height(node.Right, ref n, ref m);
        }

        if (n > m)
        {
            m = n;
            n = 1;
        }

        n++;

        return n;
    }

    public int Count()
    {
        int l = 0;
        if (this.root != null)
        {
            this.count(this.root, ref l);
        }
        return l;
    }

    private int count(Node<T> node, ref int n)
    {
        if (node.Left != null)
        {
            this.count(node.Left, ref n);
        }

        if (node.Right != null)
        {
            this.count(node.Right, ref n);
        }

        n++;

        return n;
    }

    public bool Contains(T item)
    {
        bool c = false;
        if (this.root != null)
        {
            this.contains(this.root, item, ref c);
        }
        return c;
    }

    private void contains(Node<T> node, T item, ref bool c)
    {
        if (c == true)
        {
            return;
        }

        if (item.Equals(node.Data))
        {
            c = true;
        }

        if (node.Left != null)
        {
            this.contains(node.Left, item, ref c);
        }

        if (node.Right != null)
        {
            this.contains(node.Right, item, ref c);
        }
    }
}
