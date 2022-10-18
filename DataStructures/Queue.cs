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

        if (this.head == maxsize - 1)
        {
            this.head = 0;
        }
        else
        {
            this.head++;
        }

        this.numItems++;
    }
    public T Dequeue()
    {
        if (IsEmpty())
        {
            throw new IndexOutOfRangeException("Cannot Dequeue on an empty queue");
        }

        var t = this.array[this.tail];

        if (this.tail == maxsize - 1)
        {
            this.tail = 0;
        }
        else
        {
            this.tail++;
        }


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

    public int Count()
    {
        return numItems;
    }

    public String AsString()
    {
        return String.Join(", ", this.array.Select(i => i.ToString()).ToArray());
    }
}
