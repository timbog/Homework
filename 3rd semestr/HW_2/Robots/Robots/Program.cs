using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class Program
    {
        static void Main(string[] args)
        {
            const int pointAmount = 3;
            int[,] matrix = new int[pointAmount, pointAmount];
            Console.WriteLine("Enter matrix:");
            for (int i = 0; i < pointAmount; ++i)
            {
                for (int j = 0; j < pointAmount; ++j)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter amount of robots:");
            int robotAmount = int.Parse(Console.ReadLine());
            int[] robotCoordinates = new int[robotAmount];
            Console.WriteLine("Enter positions of the robots:");
            for (int i = 0; i < robotAmount; ++i)
            {
                robotCoordinates[i] = int.Parse(Console.ReadLine());
            }
            RobotsGraph graph = new RobotsGraph(matrix, robotCoordinates);
            if (graph.Result)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
