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
                    return iter + 1;
                i = i.next;
                ++iter;
            }
            return iter;
        }
    }

    class HashTable
    {
        private int size;

        private List[] data;

        public HashTable(int s)
        {
            this.size = s;
            data = new List[s];
            for (int i = 0; i < s; ++i)
            {
                data[i] = new List();
                data[i].head = null;
            }
        }

        public int hash(string str, int max)
        {
            int result = 0;
            int i = 0;
            while (i < str.Length)
            {

                result = result + str[i];
                ++i;
            }
            return result % max;
        }

        public void addToTable(string str)
        {
            int index = hash(str, this.size);
            if (this.data[index].exist(str) == -1)
            {
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

        public void printHt()
        {
            for (int i = 0; i < this.size; ++i)
                this.data[i].print();
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
            if (this.data[index].exist(str) != -1)
                return true;
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HashTable ht = new HashTable(35);
            Console.WriteLine("Enter 1 to add a word to the hashtable");
            Console.WriteLine("Enter 2 to delete a word from the hashtable");
            Console.WriteLine("Enter 3 to find a word in the hashtable");
            Console.WriteLine("Enter 4 to exit");
            int command = -1;
            string s = "nothing";
            while (command != 4)
            {
                Console.Write("Enter number of operation: ");
                command = int.Parse(Console.ReadLine());
                if (command == 1)
                {
                    Console.WriteLine("Enter a word to add: ");
                    s = Console.ReadLine();
                    ht.addToTable(s);
                }
                if (command == 2)
                {
                    Console.WriteLine("Enter a word to delete: ");
                    s = Console.ReadLine();
                    ht.deleteFromTable(s);
                }
                if (command == 3)
                {
                    Console.WriteLine("Enter a word to find: ");
                    s = Console.ReadLine();
                    if (ht.search(s))
                        Console.WriteLine("Contains");
                    else
                        Console.WriteLine("Doesn't contain");
                }
            }
        }
    }
}