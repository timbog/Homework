using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{

    interface Calculator
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
    class PointerStack
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
        public int numbers(char c)
        {
	        if (c == '0')
		        return 0;
	        if (c == '1')
		        return 1;
	        if (c == '2')
		        return 2;
	        if (c == '3')
		        return 3;
	        if (c == '4')
		        return 4;
	        if (c == '5')
		        return 5;
	        if (c == '6')
		        return 6;
	        if (c == '7')
		        return 7;
	        if (c == '8')
		        return 8;
	        if (c == '9')
		        return 9;
            return -1;
        }

        public int count(string str)
        {
            int i = 0;
            int temp = 0;
            int digit = 0;
            int number = 0;
            while (i < str.Length)
            {
                if (numbers(str[i]) != -1)
                {
                    if (int.Parse(str) > 0)
			        digit = numbers(str[i]);	
			        number = (number * 10) + digit;	

    }
    class ArrayStack
    {
        private int[] data;
        private int size;
        private int current = -1;
       
        public ArrayStack(int size)
        {
                this.size = size;
                data = new int[size];
        }
 
        public void Push(int number)
        {
                data[++current] = number;
        }
 
        public int Pop()
        {
                return data[current--];
        }
        public void print()
        {
            for (int i = 0; i < this.size; ++i)
            {
                Console.WriteLine(this.data[i]);
            }
        }
       
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayStack stack = new ArrayStack(12);
            stack.Push(1);
            stack.Push(17);
            stack.print();
        }
    }
}
