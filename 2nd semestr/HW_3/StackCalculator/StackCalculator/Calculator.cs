using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    class Calculator
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
            return stack.Count(str);
        }
    }
}
