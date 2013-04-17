using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinTree
{
    public abstract class Tree
    {
        /// <summary>
        /// Number
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Symbol of the operation
        /// </summary>
        public char Symbol { get; set; }

        /// <summary>
        /// Left Branch
        /// </summary>
        public Tree Left { get; set; }

        /// <summary>
        /// Right branch
        /// </summary>
        public Tree Right { get; set; }

        /// <summary>
        /// Method which prints the tree
        /// </summary>
        public abstract void Print();

        /// <summary>
        /// Method which counts the tree
        /// </summary>
        /// <returns>Tree value</returns>
        public abstract int Count();
    }
}
