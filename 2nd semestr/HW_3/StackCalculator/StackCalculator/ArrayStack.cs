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
            if (Current == -1)
                throw new Exception("Emty Stack");
            return Data[Current--];
        }
    }
}
