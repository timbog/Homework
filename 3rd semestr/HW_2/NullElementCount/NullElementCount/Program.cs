using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullElementCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            int count = 0;
            for (int i = 0; i < size; ++i)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] == 0)
                    ++count;
            }
            Console.Write(count);
        }
    }
}