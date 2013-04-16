using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    public class Calculator
    {
        private IStack stack;

        /// <summary>
        /// Method which allows to choose realisation of the stack
        /// </summary>
        public Calculator(IStack stck)
        {
            this.stack = stck;
        }
        /// <summary>
        /// Method which executes counting operation
        /// </summary>
        public int ExecuteOperation(string str)
        {
            int top = 0;
            int number = 0;
            int result = 0;
            for (int i = 0; i < str.Length; ++i)
            {
                if ((str[i] != '+') && (str[i] != '*') && (str[i] != '-') && (str[i] != '/') && (str[i] != ' '))
                {
                    number = (number * 10) + (int)str[i] - (int)'0';
                }
                else
                {
                    result = number;
                    if (str[i] != ' ')
                        top = stack.Pop();
                    if (str[i] == '+')
                        result = top + number;
                    if (str[i] == '-')
                        result = top - number;
                    if (str[i] == '*')
                        result = top * number;
                    if (str[i] == '/')
                        result = top / number;
                    stack.Push(result);
                    result = 0;
                    number = 0;
                }
            }
            return stack.Pop();
        }
    }
}
