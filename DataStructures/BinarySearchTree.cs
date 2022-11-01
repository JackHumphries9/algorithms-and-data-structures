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
    }
}
