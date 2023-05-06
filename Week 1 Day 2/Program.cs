// See https://aka.ms/new-console-templusing System;

namespace _1303Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Console.WriteLine("Enter one or more lines - press CTRL Z to exit");
            string line;

            do
            {
                Console.Write("===>");
                line = Console.ReadLine();
                if (line != null)
                {
                    Console.WriteLine($"{line}");
                }
            } while (line != null);
        }
    }
}