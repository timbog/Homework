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
                throw new Exception("Emty Stack");
            this.head = i.Next;
            return i.Data;
        }
    }
}
