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

        public void Print()
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
    public class HashTable : List
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
            }
        }

        public int Hash(string str, int max)
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

        public void AddToTable(string str)
        {
            int index = Hash(str, this.size);
            if (this.data[index].Exist(str) == -1)
            {
                this.data[index].Add(str, 1);
            }
            else
            {
                ++this.data[index].Position(Exist(str)).num;
            }
        }

        public void PrintHt()
        {
            for (int i = 0; i < this.size; ++i)
                this.data[i].Print();
        }

        public void DeleteFromTable(string str)
        {
            int index = Hash(str, this.size);
            if (this.data[index].Exist(str) >= 0)
            {
                --this.data[index].Position(Exist(str)).num;
                if (this.data[index].Position(Exist(str)).num == 0)
                    this.data[index].Delete(str);
            }
        }

        public bool Search(string str)
        {
            int index = Hash(str, this.size);
            if (this.data[index].Exist(str) != -1)
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
                    ht.AddToTable(s);
                }
                if (command == 2)
                {
                    Console.WriteLine("Enter a word to delete: ");
                    s = Console.ReadLine();
                    ht.DeleteFromTable(s);
                }
                if (command == 3)
                {
                    Console.WriteLine("Enter a word to find: ");
                    s = Console.ReadLine();
                    if (ht.Search(s))
                        Console.WriteLine("Contains");
                    else
                        Console.WriteLine("Doesn't contain");
                }
            }
        }
    }
}