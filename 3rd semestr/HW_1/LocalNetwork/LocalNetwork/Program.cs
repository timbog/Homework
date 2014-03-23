using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LocalNetwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount of computers:");
            int amount = int.Parse(Console.ReadLine());

            Console.WriteLine("Write down, separating with Enter, operating system of the computers, ");
            Console.WriteLine("M for MacOs, W for Windows, L for Linux");
            Console.WriteLine("For Example:");
            Console.WriteLine("W");
            Console.WriteLine("M");
            Console.WriteLine("L");
            Console.WriteLine("M");
            Console.WriteLine();
            string[] osMatrix = new string[amount];
            string tempString;
            for (int i = 0; i < amount; ++i)
            {
                tempString = Console.ReadLine();
                if (String.Equals(tempString, "W"))
                {
                    osMatrix[i] = "Windows";
                }
                if (String.Equals(tempString, "M"))
                {
                    osMatrix[i] = "MacOS";
                }
                if (String.Equals(tempString, "L"))
                {
                    osMatrix[i] = "Linux";
                }
            }

            int temp = 0;
            int[,] matrix = new int[amount, amount];
            Console.WriteLine("Enter matrix of connections without spaces:");
            for (int i = 0; i < amount; ++i)
            {
                temp = int.Parse(Console.ReadLine());
                for (int j = 0; j < amount; ++j)
                {
                    matrix[i, amount - j - 1] = temp % 10;
                    temp = temp / 10;
                }
            }

            bool[] virusMatrix = new bool[amount];
            Console.WriteLine("Enter array of infected computers without spaces:");
            Console.WriteLine("For example:10001010111");
            for (int i = 0; i < amount; ++i)
            {
                virusMatrix[i] = Console.Read() == 49;
            }

            int[] probabilityMatrix = new int[3];
            probabilityMatrix[0] = 40;
            probabilityMatrix[1] = 60;
            probabilityMatrix[2] = 30;

            Network network = new Network(matrix, osMatrix, virusMatrix, probabilityMatrix);

            bool[] state = network.GetState();
            Console.WriteLine();
            while (!network.allInfected())
            {
                state = network.GetState();
                for (int i = 0; i < amount; ++i)
                {
                    Console.Write("Computer № ");
                    Console.Write(i + 1);
                    Console.Write("||");
                    Console.Write(osMatrix[i]);
                    Console.Write("||");
                    if (state[i])
                        Console.WriteLine("Infected");
                    else
                        Console.WriteLine("Normal");
                }
                Console.WriteLine();
                Thread.Sleep(5000);
            }
            Console.WriteLine("All computers are infected");
        }
    }
}
