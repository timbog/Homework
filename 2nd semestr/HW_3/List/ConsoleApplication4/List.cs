using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class List
    {
        static void Main(string[] args)
        {
            PointerList list = new PointerList();
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