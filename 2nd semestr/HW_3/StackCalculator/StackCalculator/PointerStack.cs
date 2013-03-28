using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    public class PointerStack : IStack
    {
        /// <summary>
        /// Class Stack Element
        /// </summary>
        public class StackElement
        {
            public int Data { get; set; }
            public StackElement Next { get; set; }
            public StackElement(int number)
            {
                this.Data = number;
                this.Next = null;
            }
        }
        /// <summary>
        /// Head of the stack
        /// </summary>
        private StackElement head = null;

        /// <summary>
        /// Method which puts a number on the top of the stack
        /// </summary>
        public void Push(int number)
        {
            StackElement i = this.head;
            StackElement j = new StackElement(number);
            j.Next = i;
            this.head = j;
        }

        /// <summary>
        /// Method which takes a number from the top of the stack
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

        /// <summary>
        /// Method which counts an ariphmetic expression
        /// </summary>
        public int Count(string str)
        {
            int top = 0;
            int number = 0;
            int result = 0;
            for (int i = 0; i < str.Length; ++i)
            {
                if ((str[i] != '+') && (str[i] != '*') && (str[i] != '-') && (str[i] != '/') && (str[i] != '_'))
                {
                    number = (number * 10) + (int)str[i] - (int)'0';
                }
                else
                {
                    result = number;
                    if (str[i] != '_')
                        top = this.Pop();
                    if (str[i] == '+')
                        result = top + number;
                    if (str[i] == '-')
                        result = top - number;
                    if (str[i] == '*')
                        result = top * number;
                    if (str[i] == '/')
                        result = top / number;
                    this.Push(result);
                    result = 0;
                    number = 0;
                }
            }
            return this.Pop();
        } 
    }
}
