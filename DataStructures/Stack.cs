namespace DataStructures;
public class Stack<T>
{
    private int maxsize = 10;
    private int top = 0;
    private T[] array;
    public Stack()
    {
        array = new T[maxsize];
    }

    public Stack(int maxsize)
    {
        this.maxsize = maxsize;
        array = new T[maxsize];
    }

    public void Push(T item)
    {
        this.array[top++] = item;
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            throw new IndexOutOfRangeException("Cannot pop an empty stack");
        }
        return this.array[top--];
    }

    public T Peek()
    {
        if (IsFull())
        {
            throw new IndexOutOfRangeException("Cannot push to a full stack");
        }
        return this.array[top - 1];
    }

    public bool IsEmpty()
    {
        return this.top == 0;
    }

    public bool IsFull()
    {
        return this.top == this.maxsize;
    }

}
