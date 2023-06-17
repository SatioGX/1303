using _1303_midterm_KevinSoo_000411471.Question_10;
using _1303_midterm_KevinSoo_000411471.Question_9;

public class Program
{
    public static void Main()
    {
        //Question 9
        Console.WriteLine("QUESTION 9------------------------");
        Q9 func = new Q9();
        func.Function2("Hello");
        func.Function2("");
        func.Function2(null);
        Console.WriteLine("\n \n");

        //Question 10
        Console.WriteLine("QUESTION 10------------------------");
        Vehicle motorcycle = new Motorcycle();
        Console.WriteLine("Motorcycle - Number of Wheels: " + motorcycle.GetNumberOfWheels());
        Console.WriteLine("Motorcycle - Max Speed: " + motorcycle.GetMaxSpeed());

        Vehicle car = new Car();
        Console.WriteLine("Car - Number of Wheels: " + car.GetNumberOfWheels());
        Console.WriteLine("Car - Max Speed: " + car.GetMaxSpeed());
        Console.WriteLine("\n \n");

        //Question 11
        Console.WriteLine("QUESTION 11------------------------");
        Stack<int> stack = new Stack<int>();

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Console.WriteLine("Peek: " + stack.Peek());  // Output: Peek: 3

        Console.WriteLine("Pop: " + stack.Pop());  // Output: Pop: 3
        Console.WriteLine("Pop: " + stack.Pop());  // Output: Pop: 2

        stack.Push(4);
        stack.Push(5);

        Console.WriteLine("Peek: " + stack.Peek());  // Output: Peek: 5
        Console.WriteLine("Pop: " + stack.Pop());  // Output: Pop: 5
        Console.WriteLine("\n \n");

    }

}