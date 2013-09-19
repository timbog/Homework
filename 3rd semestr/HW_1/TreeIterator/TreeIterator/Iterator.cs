using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeIterator
{
    class Iterator
    {
        /// <summary>
        /// Method whichs prints a tree in the rising order
        /// </summary>
        /// <param name="tree">Tree to print</param>
        public void Work(Tree tree)
        {
            if (tree.head == null)
            {
                throw new Exception("Empty tree");
            }
            if ((tree.head.Left != null))
            {
                Tree tmp = new Tree();
                tmp.head = tree.head.Left;
                this.Work(tmp);
            }
            tree.head.Left = null;
            if (tree.head.Left == null)
                Console.WriteLine(tree.head.Value);
            if ((tree.head.Right != null))
            {
                Tree tmp = new Tree();
                tmp.head = tree.head.Right;
                this.Work(tmp);
            }
            tree.head.Right = null;
        }
    }
}
