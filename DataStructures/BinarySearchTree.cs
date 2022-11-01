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

    private void insertItem(T item, ref Node<T> tree)
    {
        if (tree == null)
        {
            this.root = new Node<T>(item);
        }

        if (tree.Data.CompareTo(item) == 0)
        {
            throw new Exception("Cannot add the same item into a Binary Search Tree");
        }

        if (tree.Data.CompareTo(item) > 1)
        {
            insertItem(item, ref tree.Right);
        }

        if (tree.Data.CompareTo(item) < 1)
        {
            insertItem(item, ref tree.Left);
        }
    }
}
