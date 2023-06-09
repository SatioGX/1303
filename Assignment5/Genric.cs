using System;

public class MyStack<T>
{
    private int size;
    private int position;
    private T[] items;

    public MyStack(int size)
    {
        if (size <= 0)
        {
            throw new ArgumentException("Size must be greater than zero.");
        }

        this.size = size;
        this.items = new T[size];
        this.position = 0;
    }

    public void Push(T obj)
    {
        if (position >= size)
        {
            throw new InvalidOperationException("Stack is full. Cannot push more items.");
        }

        items[position++] = obj;
    }

    public T Pop()
    {
        if (position <= 0)
        {
            throw new InvalidOperationException("Stack is empty. Cannot pop an item.");
        }

        return items[--position];
    }

    public T Peak()
    {
        if (position <= 0)
        {
            throw new InvalidOperationException("Stack is empty. Cannot peak at an item.");
        }

        return items[position - 1];
    }
}
