using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinTree
{
    public class CountTree
    {
        /// <summary>
        /// Head of the tree
        /// </summary>
        public Tree head {get;set;}

        /// <summary>
        /// Type of the Symbol
        /// </summary>
        /// <param name="c">Symbol</param>
        /// <returns>Type of the Symbol</returns>
        private Tree SymbolType(char c)
        {
            if (c == '+')
                return new Sum();
            if (c == '-')
                return new Difference();
            if (c == '*')
                return new Multiplication();
            if (c == '/')
                return new Division();
            return new Number();
        }

        /// <summary>
        /// Method which builds a tree
        /// </summary>
        /// <param name="index">From which index to build(set 0 by default)</param>
        /// <param name="str">Which string to read</param>
        public void Build(ref int index, string str)
        {
            Tree tmp = new Sum();
            while ((index < str.Length) && ((str[index] == ' ') || (str[index] == ')')))
                ++index;
            if ((str[index] == '+') || (str[index] == '-') || (str[index] == '/') || (str[index] == '*'))
            {
                tmp = SymbolType(str[index]);
                tmp.Symbol = str[index];
                tmp.Value = -1;
                ++index;
            }
            if ((index < str.Length) && (str[index] == '('))
            {
                CountTree tree1 = new CountTree();
                ++index;
                tree1.Build(ref index, str);
                CountTree tree2 = new CountTree();
                ++index;
                tree2.Build(ref index, str);
                tmp.Left = tree1.head;
                tmp.Right = tree2.head;
            }
            int j = index;
            int number = 0;
            while ((j < str.Length) && ((int)str[j] - (int)'0') < 10 && ((int)str[j] - (int)'0') >= 0)
            {

                number = (number * 10) + (int)str[j] - (int)'0';
                ++j;
            }
            if (number != 0)
            {
                tmp = SymbolType(str[index]);
                index = j;
                tmp.Value = number;
                tmp.Symbol = 'x';
            }
            this.head = tmp;
        }

        /// <summary>
        /// Method which counts the tree
        /// </summary>
        /// <returns>Value of the tree</returns>
        public int CountThisTree()
        {
            return this.head.Count();
        }

        /// <summary>
        /// Method which prints the tree
        /// </summary>
        public void PrintThisTree()
        {
            this.head.Print();
        }
    }
}
