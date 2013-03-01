using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        const int arraySize = 3;
        private static void SpiralWrite(int[,] a)
        {
            int temp1 = arraySize / 2;
            int temp2 = arraySize / 2;
            int stopper = 1;
            while (stopper <= arraySize)
            {
                if (stopper % 2 != 0)
                {
                    for (int iterator = 0; iterator < stopper; ++iterator)
                    {
                        Console.Write(a[temp1, temp2]);
                        Console.Write(" ");
                        temp1 = temp1 - 1;
                    }
                    if (temp1 < 0)
                        break;
                    for (int iterator = 0; iterator < stopper; ++iterator)
                    {
                        Console.Write(a[temp1, temp2]);
                        Console.Write(" ");
                        temp2 = temp2 + 1;
                    }
                }
                else
                {
                    for (int iterator = 0; iterator < stopper; ++iterator)
                    {
                        Console.Write(a[temp1, temp2]);
                        Console.Write(" ");
                        temp1 = temp1 + 1;
                    }
                    if (temp1 > arraySize)
                        break;
                    for (int iterator = 0; iterator < stopper; ++iterator)
                    {
                        Console.Write(a[temp1, temp2]);
                        Console.Write(" ");
                        temp2 = temp2 - 1;
                    }
                }
                ++stopper;
            }
        }

        static void Main(string[] args)
        {
            int[,] matrix = new int[arraySize,arraySize];
            Console.WriteLine("Enter matrix:");
            for (int i = 0; i < arraySize; ++i)
            {
                for (int j = 0; j < arraySize; ++j)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Spiral is:");
            SpiralWrite(matrix);
        }
    }
}
