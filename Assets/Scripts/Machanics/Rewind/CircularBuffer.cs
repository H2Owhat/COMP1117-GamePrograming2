using System.Collections.Generic;

 public class CircularBuffer<T>
{
    private List<T> buffer;

    private int capacity;

    public CircularBuffer(int capacity)
    {
        buffer = new List<T>(capacity);
        this.capacity = capacity;
    }


    public int count => buffer.Count;


    public void Push(T item)
    {
        if(buffer.Count >= capacity)
        {
            buffer.RemoveAt(0);
        }
        buffer.Add(item);
    }

    public T Pop()
    {
        if(buffer.Count == 0) return default(T);

        int lastIndex = buffer.Count - 1;
        T item = buffer[lastIndex];
        buffer.RemoveAt(lastIndex);

        return item;
    }
}
