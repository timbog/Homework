using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    interface Stack
    {
        void Push(int number);

        int Pop();

        int Count(string str);
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayStack stack = new ArrayStack(20);
            string str = Console.ReadLine();
            Console.Write("Enter Arifmetic expression: ");
            Console.WriteLine(stack.Count(str));
        }
    }
}
