using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    public class PointerStack : Stack
    {
        public class StackElement
        {
            public int data;
            public StackElement next;
            public StackElement(int number)
            {
                this.data = number;
                this.next = null;
            }
        }

        private StackElement head = null;

        public void Push(int number)
        {
            StackElement i = this.head;
            StackElement j = new StackElement(number);
            j.next = i;
            this.head = j;
        }

        public int Pop()
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
