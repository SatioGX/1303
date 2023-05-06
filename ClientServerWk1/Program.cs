// See https://aka.ms/new-console-template for more information
using ClientServerWk1;
using System;
namespace ClntSrvrWk1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program was called with");
            for(int i = 0; i < args.Length; i++) 
            { 
                Console.WriteLine(args[i]); 
            }

            Program program = new Program();
            program.PrintNumbers();

            int inches = program.FeetToInches(3);
            Console.WriteLine($"3 feet is: {inches}");
            string msg = "this is our first program in C#";
            var msg2 = "new message";

            
            var arr = new int[] { 1, 2, 3 };
            bool isThisGood = true;

            var p1 = new Point();
            p1.x = 10;
            p1.y = 12;

            var a = 5;
            int b = 20;
            b = a;

            Point p2 = p1;
        }

        public void PrintNumbers()
        {
            Console.WriteLine("this is a test");

            for (int i = 0; i <= 1000; i++)
            {
                Console.Write(" ");
                Console.Write(i);
            }

            Console.WriteLine("end of loop");

        }

        public int FeetToInches(int feet)
        {
            int inches = feet * 12;
            return inches;
            Console.WriteLine("Kevin");
            Console.WriteLine("Student Number: 000411471");
        }
        
    }

    
}

