using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CreateStack
    {

        private int size;

        private int high = -1;

        private int[] value;

        public CreateStack(int size)
        {
                this.size = size;
                value = new int[size];
        }

        public int Take()
        {
                return value[high - 1];
        }
 
        public void Put(int number)
        {
                value[high + 1] = number;
        }
 
        public int Top()
        {
                return value[high];
        }

        public void Print()
        {
            for (int i = 0; i < size; ++i)
            {
                Console.WriteLine(value[i]);
        } 
}

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
