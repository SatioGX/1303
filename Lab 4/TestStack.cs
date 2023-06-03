using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TestStack
{
    public void Test1()
    {
        var stack = new MyStack(6);

        stack.Push("book1");
        stack.Push("paper1");
        stack.Push("paper2");
        stack.Push("paper3");
        stack.Push("paper4");
        stack.Push("paper5");
        var s1 = stack.Pop();
        var p = stack.Peak();

        Console.WriteLine($"String: {s1} type: {s1.GetType()} (This has been popped)");
        Console.WriteLine($"String Peak: {p} type: {p.GetType()}");

        var intStack = new MyStack(2);
        intStack.Push(12);
        intStack.Push(13);

        var i = intStack.Pop();
        var pi = intStack.Peak();

        Console.WriteLine($"int: {i} type:{i.GetType()} (This has been popped)");
        Console.WriteLine($"int Peak: {pi} type: {pi.GetType()}");

    }
}