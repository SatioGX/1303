using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1303_midterm_KevinSoo_000411471.Question_9
{
    public class Q9
    {
        public void Function1(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException("Parameter cannot be null or empty.");
            }
            else
            {
                Console.WriteLine("Called function: Parameter is valid: " + str);
            }
        }

        public void Function2(string str)
        {
            try
            {
                Function1(str);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Exception caught: " + ex.Message);
            }
        }
    }

}
