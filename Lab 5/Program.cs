using System;

public class Node
{
    public int data;
    public Node next;

    public Node(int data)
    {
        this.data = data;
        next = null;
    }
}

public class LinkedList
{
    private Node head;

    public void Append(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = newNode;
        }
    }

    public void Reverse()
    {
        Node prev = null;
        Node current = head;
        while (current != null)
        {
            Node nextNode = current.next;
            current.next = prev;
            prev = current;
            current = nextNode;
        }
        head = prev;
    }

    public void Display()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.data + " ");
            current = current.next;
        }
        Console.WriteLine();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        LinkedList linkedList = new LinkedList();
        linkedList.Append(56);
        linkedList.Append(24);
        linkedList.Append(101);

        Console.WriteLine("Original list:");
        linkedList.Display();

        linkedList.Reverse();

        Console.WriteLine("Reversed list:");
        linkedList.Display();
    }
}
