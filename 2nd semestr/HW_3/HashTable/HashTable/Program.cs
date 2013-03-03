using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class ListElement
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
    class List
    {

        public ListElement head = null;

        public void print()
        {
            ListElement i = this.head;
            if (i == null)
                Console.WriteLine("Empty List");
            while (i != null)
            {
                Console.WriteLine(i.data);
                i = i.next;
            }
        }

        public void add(string word, int val)
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

        public void delete(string word)
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

        public int exist(string word)
        {
            ListElement i = this.head;
            int iter = -1;
            while (i != null)
            {
                if (i.data == word)
                    return iter;
                i = i.next;
                ++iter;
            }
            return iter;
        }
    }

    class HashTable : List
    {
        private List[] data;
        private int size;

        public int hash(string str, int max)
        {
            int result = 0;
            int i = 0;
            while (i < str.Length)
            {
                
                result = str[i];
                ++i;
            }
            return result % max;
        }

        public void createHashTable(int amount)
        {
	        List[] arrayList = new List[amount];
	        this.data = arrayList;
	        this.size = amount;
        }

        public void addToTable(string str)
        {
            int index = hash(str, this.size);

            if (this.data[index].exist(str) == -1)
            {
                Console.WriteLine("dgffg");
                this.data[index].add(str, 1);
            }
            else
            {
                ListElement i = this.data[index].head;
                int iter = 0;
                while (iter != this.data[index].exist(str))
                {
                    ++iter;
                    i = i.next;
                }
                ++i.num;
            }
        }
        public void deleteFromTable(string str)
        {
            int index = hash(str, this.size);
            if (this.data[index].exist(str) >= 0)
            {
                ListElement i = this.data[index].head;
                int iter = 0;
                while (iter != this.data[index].exist(str))
                {
                    ++iter;
                    i = i.next;
                }
                --i.num;
                if (i.num == 0)
                    this.data[index].delete(str);
            }

        }

        public bool search(string str)
        {
            int index = hash(str, this.size);
                if (this.data[index].exist(str) >= 0)
		        return true;
	        return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HashTable ht = new HashTable();
            ht.createHashTable(15);
            Console.WriteLine("Enter word");
            string str = Console.ReadLine(); 
            ht.addToTable(str);           
            if (ht.search(str))
            {
                Console.WriteLine("Yes");
            }
            else
             Console.WriteLine("No");   
        }
    }
}
