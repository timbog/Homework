using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class Program
    {
        public const int arraySize = 3;

        public static void SpiralWrite(int[,] a)
        {
            int line = arraySize / 2;
            int row = arraySize / 2;
            int stopper = 1;
            while (stopper <= arraySize)
            {
                if (stopper % 2 != 0)
                {
                    for (int iterator = 0; iterator < stopper; ++iterator)
                    {
                        Console.Write(a[line, row]);
                        Console.Write(" ");
                        --line;
                    }
                    if (line < 0)
                        break;
                    for (int iterator = 0; iterator < stopper; ++iterator)
                    {
                        Console.Write(a[line, row]);
                        Console.Write(" ");
                        ++row; ;
                    }
                }
                else
                {
                    for (int iterator = 0; iterator < stopper; ++iterator)
                    {
                        Console.Write(a[line, row]);
                        Console.Write(" ");
                        ++line;
                    }
                    if (line > arraySize)
                        break;
                    for (int iterator = 0; iterator < stopper; ++iterator)
                    {
                        Console.Write(a[line, row]);
                        Console.Write(" ");
                        --row;
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
