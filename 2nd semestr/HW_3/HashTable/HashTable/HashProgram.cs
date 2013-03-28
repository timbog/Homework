using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class HashProgram
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