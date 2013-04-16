using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class PointerList
    {
        /// <summary>
        /// Class with which list is built
        /// </summary>
        private class ListElement
        {
            public int Data { get; set; }
            public ListElement Next { get; set; }
            public ListElement(int value)
            {
                this.Data = value;
                this.Next = null;
            }
        }

        /// <summary>
        /// Head of the list
        /// </summary>
        private ListElement head = null;

        /// <summary>
        /// Printing method
        /// </summary>
        public void Print()
        {
            ListElement i = this.head;
            if (i == null)
                Console.WriteLine("Empty List");
            while (i != null)
            {
                Console.WriteLine(i.Data);
                i = i.Next;
            }
        }

        /// <summary>
        /// Method which adds a value to the list
        /// </summary>
        public void Add(int number)
        {
            ListElement j = new ListElement(number);
            j.Next = this.head;
            this.head = j;
        }

        /// <summary>
        /// Method which shows if list is empty
        /// </summary>
        public bool IsEmpty()
        {
            return (this.head == null);
        }

        /// <summary>
        /// Method which deletes a value from the list
        /// </summary>
        public void Delete(int number)
        {
            if (head == null)
            {
                throw new Exception("Emty List");
            }
            ListElement i = this.head;
            if (i.Data == number)
            {
                head = i.Next;
                return;
            }
            while (i.Next != null)
            {

                if (i.Next.Data == number)
                {
                    i.Next = i.Next.Next;
                    return;
                }
                i = i.Next;
            }
            throw new Exception("No such element");
        }
    }
}