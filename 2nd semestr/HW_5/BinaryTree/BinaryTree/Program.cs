using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            int index = 0;
            tree.Build(ref index);
            tree.Print();
            CountTree countTree = new CountTree();
            Console.WriteLine(countTree.Count(tree));
        }
    }
}
