using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5
{
    public class TestStack
    {
        public void Test1()
        {
            var stack = new MyStack();

            stack.Push("book1");
            stack.Push("paper1");
            stack.Push("paper2");
            stack.Push("paper3");
            stack.Push("paper4");
            // stack.Push("paper5");

            var s1 = stack.Pop();

            var intStack = new MyStack();
            intStack.Push(12);
            intStack.Push(13);
            var i = intStack.Pop();

            Console.WriteLine($"i: {i.GetType()}");
            Console.WriteLine($"s1: {s1.GetType()}");

        }
    }
}
