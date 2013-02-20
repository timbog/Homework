using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        private static int Fib(int n)
        {
            if ((n == 1) || (n == 2))
                return 1;
            else
                return Fib(n - 1) + Fib(n - 2);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Fibonacci is: ");
            Console.WriteLine(Fib(i));
        }
    }
}
