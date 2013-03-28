using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    public class ArrayStack : IStack
    {
        /// <summary>
        /// Array of elements
        /// </summary>
        private int[] Data;

        /// <summary>
        /// Number of the current element of the stack
        /// </summary>
        private int Current = -1;

        /// <param name="size">Size of the stack</param>
        public ArrayStack(int size)
        {
            Data = new int[size];
        }

        /// <summary>
        /// Method which puts a number on the top of the stack
        /// </summary>
        public void Push(int number)
        {
            Data[++Current] = number;
        }

        /// <summary>
        /// Method which takes a number from the top of the stack
        /// </summary>
        public int Pop()
        {
            return Data[Current--];
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
