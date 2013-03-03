using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class StackElement
    {
        public int data;
        public StackElement next;
        public StackElement(int a)
        {
            this.data = a;
            this.next = null;
        }
    }
    class Stack
    {
        public StackElement head = null;
        public void print()
        {
            StackElement i = this.head;
            if (i == null)
                Console.WriteLine("Empty Stack");
            while (i != null)
            {
                Console.WriteLine(i.data);
                i = i.next;
            }
        }

        public void add(int number)
        {
            StackElement i = this.head;
            StackElement j = new StackElement(number);
            j.next = i;
            this.head = j;
        }

        public int take()
        {
            StackElement i = this.head;
            if (i == null)
            {
                Console.WriteLine("Empty Stack");
                return -1;
            }
            this.head = i.next;
            return i.data;
        }

    }
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
                Console.WriteLine("Enter operation number: ");
                command = int.Parse(Console.ReadLine());
                if (command == 1)
                {
                    Console.WriteLine("Stack is");
                    stack.print();
                }
                if (command == 2)
                {
                    Console.WriteLine("Enter number to add: ");
                    num = int.Parse(Console.ReadLine());
                    stack.add(num);
                }
                if (command == 3)
                {
                    Console.WriteLine(stack.take());
                }
            }
        }
    }
}
