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
}
