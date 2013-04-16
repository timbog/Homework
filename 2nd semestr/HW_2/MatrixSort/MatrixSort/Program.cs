using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            MatrixSort matrixSort = new MatrixSort();
            matrixSort.ArrayHigh = 3;
            matrixSort.ArrayLen = 3;
            int[,] matrix = new int[matrixSort.ArrayHigh, matrixSort.ArrayLen];
            Console.WriteLine("Enter matrix:");
            for (int i = 0; i < matrixSort.ArrayHigh; ++i)
            {
                for (int j = 0; j < matrixSort.ArrayLen; ++j)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Sorted matrix is is:");
            matrixSort.InsertSort(ref matrix);
            for (int i = 0; i < matrixSort.ArrayHigh; ++i)
            {
                for (int j = 0; j < matrixSort.ArrayLen; ++j)
                {
                    Console.Write(matrix[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
