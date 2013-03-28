using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class List
    {
        /// <summary>
        /// Class which is used to build a list
        /// </summary>
        public class ListElement
        {
            public string Data { get; set; }
            public ListElement Next { get; set; }
            public int Num { get;set; }

            public ListElement(string str, int val)
            {
                this.Data = str;
                this.Num = val;
                this.Next = null;
            }
        }

        /// <summary>
        /// Head of the list
        /// </summary>
        public ListElement head = null;

        /// <summary>
        /// Method which is used to print the list
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
        /// Method which is used to add a value to the list
        /// </summary>
        public void Add(string word, int val)
        {
            ListElement j = new ListElement(word, val);
            ListElement i = this.head;
            if (head == null)
            {
                head = j;
                return;
            }
            while (i.Next != null)
                i = i.Next;
            i.Next = j;
        }

        /// <summary>
        /// Method which is used to delete a value from the list
        /// </summary>
        public void Delete(string word)
        {
            if (head == null)
            {
                Console.WriteLine("Empty List");
                return;
            }
            ListElement i = this.head;
            if (i.Data == word)
            {
                head = i.Next;
                return;
            }
            while (i.Next != null)
            {
                if (i.Next.Data == word)
                {
                    i.Next = i.Next.Next;
                    return;
                }
                i = i.Next;
            }
            Console.WriteLine("No such word");
        }

        /// <summary>
        /// Method which is used to find out if this value exists
        /// </summary>
        public int Exist(string word)
        {
            ListElement i = this.head;
            int iter = -1;
            while (i != null)
            {
                if (i.Data == word)
                    return iter + 1;
                i = i.Next;
                ++iter;
            }
            return iter;
        }

        /// <summary>
        /// Method which returns position of the element in the list
        /// </summary>
        public ListElement Position(int position)
        {
            ListElement i = this.head;
            for (int j = 0; j < position; j++)
            {
                i = i.Next;
            }
            return i;
        }
    }
}
