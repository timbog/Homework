using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private static int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
        static void Main(string[] args)
        {
            int i = 0;
            Console.Write("Enter number: ");
            i = int.Parse(Console.ReadLine());
            Console.Write("Factorial is : ");
            Console.WriteLine(Factorial(i));
        }
    }
}
