using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TreeIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.AddValue(8);
            tree.AddValue(7);
            tree.AddValue(9);
            tree.AddValue(10);
            tree.AddValue(3);
            tree.AddValue(2);
            tree.AddValue(12);
            tree.AddValue(11);
            Iterator iterator = new Iterator();
            iterator.Work(tree);
        }
    }
}
