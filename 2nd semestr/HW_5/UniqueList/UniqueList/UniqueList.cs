using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueList
{
    public class UniqueList
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
        /// Method which adds a value to the list
        /// </summary>
        /// <param name="value">Value to add to the list</param>
        public void Add(int value)
        {
            ListElement tmp = new ListElement(value);
            if (this.head == null)
            {
                this.head = tmp;
                return;
            }
            ListElement iterator = this.head;
            while (iterator != null)
            {
                if (iterator.Data == value)
                    throw new Exception("Already exists");
                if (iterator.Next == null)
                    break;
                iterator = iterator.Next;
            }
            iterator.Next = tmp;
        }

        /// <summary>
        /// Method which deletes a value from the list
        /// </summary>
        /// <param name="number"></param>
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

        /// <summary>
        /// Printing method
        /// </summary>
        public void Print()
        {
            ListElement iterator = this.head;
            if (iterator == null)
                throw new Exception("Empty List");
            while (iterator != null)
            {
                Console.WriteLine(iterator.Data);
                iterator = iterator.Next;
            }
        }
        /// <summary>
        /// Value of the head
        /// </summary>
        /// <returns>Head value</returns>
        public int HeadValue()
        {
            return this.head.Data;
        }

        /// <summary>
        /// Emty or not empty list
        /// </summary>
        /// <returns>If list is empty</returns>
        public bool IsEmpty()
        {
            return (this.head == null);
        }
    }
}
