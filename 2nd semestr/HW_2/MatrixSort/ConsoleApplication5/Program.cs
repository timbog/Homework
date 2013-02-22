using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        const int arrayLen = 3;
        const int arrayHigh = 3;
        private static void InsertSort(int[,] a)
        {
            int temp1 = 0;
            int temp2 = 0;
            for (int i = 0; i < arrayLen; i++)
            {
                temp2 = i;
                while ((temp2 != arrayLen - 1) && (a[0,temp2 + 1] < a[0,temp2]))
                {
                    for (int j = 0; j < arrayHigh; j++)
                    {
                        temp1 = a[j,temp2];
                        a[j,temp2] = a[j,temp2 + 1];
                        a[j,temp2 + 1] = temp1;
                    }
                        if (temp2 != 0)
                            --temp2;
                        else
                            break;
                }
            }
        }

        static void Main(string[] args)
        {
            int[,] matrix = new int[arrayHigh,arrayLen];
            Console.WriteLine("Enter matrix:");
            for (int i = 0; i < arrayHigh; ++i)
            {
                for (int j = 0; j < arrayLen; ++j)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Sorted matrix is is:");
            InsertSort(matrix);
            for (int i = 0; i < arrayHigh; ++i)
            {
                for (int j = 0; j < arrayLen; ++j)
                {
                    Console.Write(matrix[i,j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
