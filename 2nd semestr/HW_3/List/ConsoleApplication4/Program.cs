using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class List
    {
        private class ListElement
        {
            public int Data;
            public ListElement Next;
            public ListElement(int value)
            {
                this.Data = value;
                this.Next = null;
            }
        }

        private ListElement head = null;

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

        public void Add(int number)
        {
            ListElement j = new ListElement(number);
            ListElement i = this.head;
            j.Next = i;
            this.head = j;
        }

        public bool IsEmpty()
        {
            if (this.head == null)
                return true;
            return false;
        }

        public void Delete(int number)
        {
            if (head == null)
            {
                Console.WriteLine("Empty List");
                return;
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
            Console.WriteLine("No such element");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List list = new List();
            Console.WriteLine("Enter 0 exit");
            Console.WriteLine("Enter 1 to print the list");
            Console.WriteLine("Enter 2 to add a number to the list");
            Console.WriteLine("Enter 3 to delete a number from the list");
            int command = 1;
            int num = 0;
            while (command != 0)
            {
                Console.WriteLine("Enter operation number: ");
                command = int.Parse(Console.ReadLine());
                if (command == 1)
                {
                    Console.WriteLine("List is");
                    list.Print();
                }
                if (command == 2)
                {
                    Console.WriteLine("Enter number to add: ");
                    num = int.Parse(Console.ReadLine());
                    list.Add(num);
                }
                if (command == 3)
                {
                    Console.WriteLine("Enter number to delete: ");
                    num = int.Parse(Console.ReadLine());
                    list.Delete(num);
                }
            }
        }
    }
}