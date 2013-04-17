using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BinTree
{
    class Program
    {
        static void Main(string[] args)
        {
            CountTree tree = new CountTree();
            StreamReader streamReader = new StreamReader("input.txt");
            string str = "";
            while (!streamReader.EndOfStream)
            {
                str += streamReader.ReadLine();
            }
            int temp = 0;
            tree.Build(ref temp, str);
            Console.WriteLine(tree.CountThisTree());
            tree.PrintThisTree();
        }
    }
}
