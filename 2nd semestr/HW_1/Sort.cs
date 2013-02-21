using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        const int arrayLen = 5;
        private static void InsertSort(int[] a)
        {
            int temp1 = 0;
            int temp2 = 0;
            for (int i = 0; i < arrayLen; i++)
            {
                temp2 = i;
                while ((temp2 != arrayLen - 1) && (a[temp2 + 1] < a[temp2]))
                {
                    temp1 = a[temp2];
                    a[temp2] = a[temp2 + 1];
                    a[temp2 + 1] = temp1;
                    if (temp2 != 0)
                        --temp2;
                    else
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] array = new int[arrayLen];
            Console.Write("Enter array: ");
            for (int i = 0; i < arrayLen; ++i) 
                array[i] = int.Parse(Console.ReadLine());
            InsertSort(array);
            Console.Write("Sorted array is: ");
            for (int i = 0; i < arrayLen; ++i)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }
        }
    }
}
