using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree;
namespace BinaryTree
{
    class CountTree
    {
        public int Count(Tree tree)
        {
            Tree tree1 = new Tree();
            Tree.TreeElement tmp = tree.head;
            if (tmp == null)
            {
                Console.WriteLine("Empty tree");
                return 0;
            }
            int result = 0;
            if (tmp.Element == 'x')
                result = tmp.Value;
            else
            {
                Tree tempTree1 = new Tree();
                tempTree1.head = tmp.Left;
                Tree tempTree2 = new Tree();
                tempTree2.head = tmp.Right;
                if (tmp.Element == '+')
                    result = this.Count(tempTree1) + this.Count(tempTree2);
                if (tmp.Element == '-')
                    result = this.Count(tempTree1) - this.Count(tempTree2);
                if (tmp.Element == '*')
                    result = this.Count(tempTree1) * this.Count(tempTree2);
                if (tmp.Element == '/')
                    result = this.Count(tempTree1) / this.Count(tempTree2);
            }
            return result;
        }
    }
}
