using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack
    {
        /// <summary>
        /// This class is used to build a stack
        /// </summary>
        private class StackElement
        {
            public int Data { get; set; }
            public StackElement Next { get; set; }
            public StackElement(int value)
            {
                this.Data = value;
                this.Next = null;
            }
        }

        /// <summary>
        /// This is a head of the stack
        /// </summary>
        private StackElement head = null;

        /// <summary>
        /// This method is used to print a stack
        /// </summary>
        public void Print()
        {
            StackElement i = this.head;
            if (i == null)
                Console.Write("Empty Stack");
            while (i != null)
            {
                Console.Write(i.Data);
                i = i.Next;
            }
        }

        /// <summary>
        /// This method is used to add an element to the stack
        /// </summary>
        public void Add(int number)
        {
            StackElement j = new StackElement(number);
            j.Next = this.head;
            this.head = j;
        }

        /// <summary>
        /// This method is used to take top of the stack
        /// </summary>
        public int Pop()
        {
            StackElement i = this.head;
            if (i == null)
            {
                Console.WriteLine("Empty Stack");
                return -1;
            }
            this.head = i.Next;
            return i.Data;
        }
    }
}
