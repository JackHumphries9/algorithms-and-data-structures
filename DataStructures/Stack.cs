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

    public void Push(T item)
    {
        this.array[top++] = item;
    }

    public T Pop()
    {
        return this.array[top--];
    }

    public T Peek()
    {
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

    public Stack(int maxsize)
    {
        this.maxsize = maxsize;
        array = new T[maxsize];
    }

    public int add(int x, int y)
    {
        //throw new NotImplementedException("Not implemented");
        return x + y;
    }
}
