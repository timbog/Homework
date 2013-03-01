using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class List
    {

        private int size;

        private int[] value;

        public void CreateList(int size)
        {
            this.size = size;
            value = new int[size];
        }

        public void remove(int number)
        {
            for (int i = 0; i < size; ++i)
            {
                if (value[i] == number)
                {
                    value[i] = 0;
                }
            }
        }

        public void Put(int number)
        {
            for (int j = 0; j < size; ++j)
            {
                if (value[j] == 0)
                {
                    value[j] = number;
                    break;
                }
            }
        }

        public void print()
        {
            for (int j = 0; j < size; ++j)
            {
                Console.WriteLine(value[j]);
            }
        }
    }
        
    class Program
    {
        static void Main(string[] args)
        {
            List a = new List();
            a.CreateList(4);
            a.Put(1);
            a.print();
        }
    }
}
