using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixSort
{
    public class MatrixSort
    {
        const int arrayLen = 3;
        const int arrayHigh = 3;

        public static void Swap(ref int number1, ref int number2)
        {
            int temp = number1;
            number1 = number2;
            number2 = temp;
        }

        public static void InsertSort(int[,] a)
        {

            int row = 0;
            for (int i = 0; i < arrayLen; i++)
            {
                row = i;
                while ((row != arrayLen - 1) && (a[0,row + 1] < a[0,row]))
                {
                    for (int j = 0; j < arrayHigh; j++)
                    {
                        Swap(ref a[j , row], ref a[j, row + 1]);
                    }
                    if (row != 0)
                        --row;
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
