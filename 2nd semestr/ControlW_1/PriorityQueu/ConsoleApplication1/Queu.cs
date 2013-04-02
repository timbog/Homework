using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueu
{
    public class Queu
    {
        /// <summary>
        /// Class, with which queu is built
        /// </summary>
        public class QueuElement
        {
            public int Value { get; set; }

            public int Priority { get; set; }

            public QueuElement Next { get; set; }
        }

        /// <summary>
        /// Head of the queu
        /// </summary>
        public QueuElement head{get;set;}

        /// <summary>
        /// Method which adds value and it's priority to the queu
        /// </summary>
        /// <param name="value">Value to add</param>
        /// <param name="priority">Priority of the value</param>
        public void EnQueu(int value, int priority)
        {
            QueuElement tmp = new QueuElement();
            tmp.Value = value;
            tmp.Priority = priority;
            tmp.Next = null;
            if (this.head == null)
            {
                this.head = tmp;
                return;
            }
            tmp.Next = this.head;
            this.head = tmp;
        }

        /// <summary>
        /// Method which deletes element with the highest priority
        /// </summary>
        /// <returns>Value with the highest priority</returns>
        public int Dequeu()
        {
            QueuElement tmp = this.head;

            if (tmp == null)
            {
                Exception Emptyqueu = new Exception("Emty queu");
                throw Emptyqueu;
            }
            int max = tmp.Priority;
            while (tmp.Next != null)
            {
                if (tmp.Next.Priority > max)
                    max = tmp.Next.Priority;
                tmp = tmp.Next;
            }
            tmp = this.head;
            if (tmp.Priority == max)
            {
                this.head = tmp.Next;
                return tmp.Value;
            }
            while (tmp.Next.Priority != max)
                tmp = tmp.Next;
            int result = tmp.Next.Value;
            tmp.Next = tmp.Next.Next;
            return result;
        }
    }
}
