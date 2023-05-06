using _1303Day2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Week_1_Day_2.Assignment1
{
    internal class Assignment_1
    {
        static void Main(string[] args)
        {
            Assignment_1 program = new Assignment_1();

            Console.WriteLine("Hello World");

            Console.WriteLine("Select an option from 1 to 10");
            program.GetUserChoice();
        }

        public int GetUserChoice()
        {
            int number = 0;
            string line;

            do
            {
                Console.WriteLine("===>");
                line = Console.ReadLine();
                switch (line)
                {
                    case "1":
                        number = 1;
                        Console.WriteLine($"Option: 1");
                        return number;
                    case "2":
                        number = 2;
                        Console.WriteLine($"Option: 2");
                        return number;
                    case "3":
                        number = 3;
                        Console.WriteLine($"Option: 3");
                        return number;
                    case "4":
                        number = 4;
                        Console.WriteLine($"Option: 4");
                        return number;
                    case "5":
                        number = 5;
                        Console.WriteLine($"Option: 5");
                        return number;
                    case "6":
                        number = 6;
                        Console.WriteLine($"Option: 6");
                        return number;
                    case "7":
                        number = 7;
                        Console.WriteLine($"Option: 7");
                        return number;
                    case "8":
                        number = 8;
                        Console.WriteLine($"Option: 8");
                        return number;
                    case "9":
                        number = 9;
                        Console.WriteLine($"Option: 9");
                        return number;
                    case "10":
                        number = 10;
                        Console.WriteLine($"Option: 10");
                        return number;
                    default:
                        Console.WriteLine("Invalid Option Try again");
                        GetUserChoice();
                        return number;
                }
            } while (number != null);

        }
    }
}
