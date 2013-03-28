using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    interface IStack
    {
        void Push(int number);

        int Pop();

        int Count(string str);
    }

    class Program
    {
        static void Main(string[] args)
        {
            PointerStack stack = new PointerStack();
            Calculator calculator = new Calculator(stack);
            Console.Write("Enter arifmetic expression: ");
            string str = Console.ReadLine();
            Console.Write("Result is: ");
            Console.Write(calculator.ExecuteOperation(str));
        }
    }
}
