using System;
using System.Collections.Generic;

public class CircularBuffer<T>
{
    private Queue<T> elements;
    private readonly int capacity = 0;
    public CircularBuffer(int capacity)
    {
        this.capacity = capacity;
        this.elements = new Queue<T>();
    }
   
    public T Read()
    {
        if (elements.Count == 0)
            throw new InvalidOperationException();

        T element = elements.Dequeue();

        return element;
    }

    public void Write(T value)
    {
        if (!IsFull())
            elements.Enqueue(value);
        else throw new InvalidOperationException();
    
    }

    public void Overwrite(T value)
    {
        if (!IsFull())
            Write(value);
        else
        {
            elements.Dequeue();
            elements.Enqueue(value);
        }
    }

    public void Clear() => elements.Clear();

    private bool IsFull()
    {
        return elements.Count < capacity ? false : true;
    }
}