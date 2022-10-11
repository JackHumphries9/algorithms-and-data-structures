namespace DataStructures;
public class Queue<T>
{
    private int maxsize = 10;
    private T[] array;
    private int head, tail = 0;
    private int numItems = 0;
    public Queue()
    {
        array = new T[maxsize];
    }
    public Queue(int bufferSize)
    {
        this.maxsize = bufferSize;
        array = new T[maxsize];
    }

    public void Enqueue(T value)
    {
        if (IsFull())
        {
            throw new IndexOutOfRangeException("Cannot Dequeue on an empty queue");
        }

        this.array[this.head] = value;
        this.head++;
        this.numItems++;
    }
    public T Dequeue()
    {
        if (IsEmpty())
        {
            throw new IndexOutOfRangeException("Cannot Dequeue on an empty queue");
        }
        var t = this.array[this.tail];
        this.tail++;
        this.numItems--;
        return t;
    }
    public T Peek()
    {
        return this.array[this.tail];
    }

    public Boolean IsFull()
    {
        return this.numItems >= maxsize;

    }
    public Boolean IsEmpty()
    {
        return this.numItems == 0;
    }
}
