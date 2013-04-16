using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixSort
{
    public class MatrixSort
    {
        /// <summary>
        /// Height of the matrix
        /// </summary>
        public int ArrayHigh { get; set; }

        /// <summary>
        /// Length of the matrix
        /// </summary>
        public int ArrayLen { get; set; }

        public void Swap(ref int number1, ref int number2)
        {
            int temp = number1;
            number1 = number2;
            number2 = temp;
        }
        /// <summary>
        /// Sort the matrix
        /// </summary>
        /// <param name="a">ref matrix</param>
        public void InsertSort(ref int[,] a)
        {
            int row = 0;
            for (int i = 0; i < ArrayLen; i++)
            {
                row = i;
                while ((row >= 0) && (row != ArrayLen - 1) && (a[0, row + 1] < a[0, row]))
                {
                    for (int j = 0; j < ArrayHigh; j++)
                    {
                        Swap(ref a[j, row], ref a[j, row + 1]);
                    }
                        --row;
                }
            }
        }
    }
}
