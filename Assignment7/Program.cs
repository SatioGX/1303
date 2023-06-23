using System;

namespace Assignment7
{
    public class Program
    {
        static void Main(string[] args)
        {
            // var test = new DelegateExample();
            // test.TestDelegateFunctionality();

            var test = new Program();
            //test.AddNodeToHead_ShouldAdd();

            var linkedList = new LinkedList<int>();

            linkedList.AddTail(new LinkedListNode<int>(2));
            linkedList.AddTail(new LinkedListNode<int>(4));
            linkedList.AddTail(new LinkedListNode<int>(6));

            Console.WriteLine("Before removing tail:");
            Console.WriteLine("Count: " + linkedList.GetCount());
            Console.WriteLine("Head: " + linkedList.Head.Data);
            Console.WriteLine("Tail: " + linkedList.Tail.Data);

            linkedList.RemoveTail();

            Console.WriteLine("After removing tail:");
            Console.WriteLine("Count: " + linkedList.GetCount());
            Console.WriteLine("Head: " + linkedList.Head.Data);
            Console.WriteLine("Tail: " + linkedList.Tail.Data);
        }

        //private void AddNodeToHead_ShouldAdd()
        //{
        //    var linkedList = new LinkedList<int>();

        //    linkedList.AddHead(new LinkedListNode<int>(2));

        //    var count = linkedList.GetCount();
        //    if (count != 1)
        //    {
        //        throw new Exception("Count should be 1");
        //    }
        //}



    }

}