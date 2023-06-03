using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//public class MyStack
//{
//    public MyStack()
//    {
//    }

//    private const int Size = 5;
//    private int position;

//    private object[] items = new object[Size];

//    public void Push(object obj)
//    {
//        items[position++] = obj;

//    }

//    public object Pop()
//    {
//        return items[--position];
//    }
//}
public class MyStack
{
    private int size;
    private int position;
    private object[] items;

    public MyStack(int size)
    {
        if (size <= 0)
        {
            throw new ArgumentException("Size must be greater than zero.");
        }

        this.size = size;
        this.items = new object[size];
        this.position = 0;
    }

    public void Push(object obj)
    {
        if (position >= size)
        {
            throw new InvalidOperationException("Stack is full. Cannot push more items.");
        }

        items[position++] = obj;
    }

    public object Pop()
    {
        if (position <= 0)
        {
            throw new InvalidOperationException("Stack is empty. Cannot pop an item.");
        }

        return items[--position];
    }

    public object Peak()
    {
        if (position <= 0)
        {
            throw new InvalidOperationException("Stack is empty. Cannot peak at an item.");
        }

        return items[position - 1];
    }
}
