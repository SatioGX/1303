using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5
{
    public class MyStack
    {
        public MyStack()
        {
        }

        private const int Size = 5;
        private int position;

        private object[] items = new object[Size];

        public void Push(object obj)
        {
            items[position++] = obj;

        }

        public object Pop()
        {
            return items[--position];
        }
    }
}

