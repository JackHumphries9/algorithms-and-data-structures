using System.Collections.Generic;
namespace DataStructures;

class Link<T>
{
    private T data;
    private Link<T> next;

    public Link(T item) //constructor with an item
    {
        this.data = item;
        this.next = null;
    }
    public Link(T item, Link<T> list) //constructor with item and list
    {
        this.data = item;
        this.next = list;
    }

    public T Data //property for data
    {
        set { this.data = value; }
        get { return this.data; }
    }

    public Link<T> Next //property for next
    {
        set { this.next = value; }
        get { return this.next; }
    }
}

public class LinkedList<T> where T : IComparable
{
    private Link<T> list = null; //default value – empty list

    public void AddItem(T item)
    {
        this.list = new Link<T>(item, this.list);
    }

    public void AppendItem(T item) //add item to front of list
    {
        Link<T> newItem = new Link<T>(item);
        Link<T> temp = list;

        if (temp == null)
        {
            list = newItem;
            return;
        }

        // Traverse list
        while (temp.Next != null)
        {
            temp = temp.Next;
        }

        temp.Next = newItem;
    }

    public string AsString() //write items to string and return
    {
        Link<T> temp = list;
        string buffer = "[";
        int c = 0;
        int max = this.Length();

        while (temp != null) // move one link and add head to the buffer
        {
            c++;
            if (c == max)
            {
                buffer = buffer + temp.Data.ToString();
            }
            else
            {
                buffer = buffer + temp.Data.ToString() + ", ";
            }
            temp = temp.Next;
        }
        buffer = buffer + "]";
        return buffer;
    }

    public int Length() // returns number of items in list
    {
        Link<T> temp = list;
        int count = 0;
        while (temp != null) // move one link and add 1 to count
        {
            count++;
            temp = temp.Next;
        }
        return count;
    }

    public bool IsPresentItem(T item)
    {
        Link<T> temp = list;
        bool flag = false;
        while (temp != null) // move one link and add 1 to count
        {
            if (temp.Data.Equals(item))
            {
                flag = true;
                break;
            }
            temp = temp.Next;
        }

        return flag;
    }
    public void RemoveItem(T item)
    {
        Link<T> current = list;
        Link<T> prev = null;

        while (current != null) // move one link and add 1 to count
        {
            if (current.Data.Equals(item))
            {
                if (prev == null) { list = current.Next; break; }
                prev.Next = current.Next;
                break;
            }
            prev = current;
            current = current.Next;
        }
    }

    public void InsertInOrder(T item)
    {
        Link<T> temp = list;
        Link<T> prev = null;
        if (list == null)
        {
            AddItem(item);
            return;
        }


        while (temp != null)
        { 
            if (temp.Data.CompareTo(item) > 0)
            {
                temp = temp.Next;
                prev = temp;
                continue;
            }
        }
    }
}
