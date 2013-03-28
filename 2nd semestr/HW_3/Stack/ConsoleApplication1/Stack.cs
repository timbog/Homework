using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{

    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            Console.WriteLine("Enter 0 exit");
            Console.WriteLine("Enter 1 to print the stack");
            Console.WriteLine("Enter 2 to add a number to the stack");
            Console.WriteLine("Enter 3 to take a number from the stack");
            int command = 1;
            int num = 0;
            while (command != 0)
            {
                Console.Write("Enter operation number: ");
                command = int.Parse(Console.ReadLine());
                if (command == 1)
                {
                    Console.Write("Stack is: ");
                    stack.Print();
                    Console.WriteLine();
                }
                if (command == 2)
                {
                    Console.Write("Enter number to add: ");
                    num = int.Parse(Console.ReadLine());
                    stack.Add(num);
                }
                if (command == 3)
                {
                    Console.Write(stack.Pop());
                }
            }
        }
    }
}
