using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinTree
{
    public abstract class Operation:Tree
    {
        /// <summary>
        /// Method which prints symbol
        /// </summary>
        public abstract void PrintSymbol();

        /// <summary>
        /// Method which prints a tree
        /// </summary>
        public override void Print()
        {
            Console.Write('(');
            this.Left.Print();
            this.PrintSymbol();
            this.Right.Print();
            Console.Write(')');
        }
    }
}
