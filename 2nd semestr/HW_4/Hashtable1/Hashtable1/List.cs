using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class List
    {
        public class ListElement
        {
            public string data;
            public ListElement next;
            public int num;

            public ListElement(string a, int b)
            {
                this.data = a;
                this.num = b;
                this.next = null;
            }
        }

        public ListElement head = null;

        public void Add(string word, int val)
        {
            ListElement j = new ListElement(word, val);
            ListElement i = this.head;
            if (head == null)
            {
                head = j;
                return;
            }
            while (i.next != null)
                i = i.next;
            i.next = j;
        }

        public void Delete(string word)
        {
            if (head == null)
            {
                Console.WriteLine("Empty List");
                return;
            }
            ListElement i = this.head;
            if (i.data == word)
            {
                head = i.next;
                return;
            }
            while (i.next != null)
            {

                if (i.next.data == word)
                {
                    i.next = i.next.next;
                    return;
                }
                i = i.next;
            }
            Console.WriteLine("No such word");
        }

        public int Exist(string word)
        {
            ListElement i = this.head;
            int iter = -1;
            while (i != null)
            {
                if (i.data == word)
                    return iter + 1;
                i = i.next;
                ++iter;
            }
            return iter;
        }

        public ListElement Position(int position)
        {
            ListElement i = this.head;
            for (int j = 0; j < position; j++)
            {
                i = i.next;
            }
            return i;
        }

    }
}
