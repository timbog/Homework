using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    public class ArrayStack : Stack
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
