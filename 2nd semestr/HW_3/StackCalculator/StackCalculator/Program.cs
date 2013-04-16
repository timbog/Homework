using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayStack stack = new ArrayStack(25);
            Calculator calculator = new Calculator(stack);
            Console.Write("Enter arifmetic expression: ");
            string str = Console.ReadLine();
            Console.Write("Result is: ");
            Console.Write(calculator.ExecuteOperation(str));
        }
    }
}
