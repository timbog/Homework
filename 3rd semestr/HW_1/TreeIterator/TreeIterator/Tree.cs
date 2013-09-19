using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeIterator
{
    public class Tree
    {
        /// <summary>
        /// Node itself
        /// </summary>
        public class Node
        {
            /// <summary>
            /// Number
            /// </summary>
            public int Value { get; set; }

            /// <summary>
            /// Left Branch
            /// </summary>
            public Node Left { get; set; }

            /// <summary>
            /// Right branch
            /// </summary>
            public Node Right { get; set; }
        }

        /// <summary>
        /// Head of the tree
        /// </summary>
        public Node head { get; set; }

        /// <summary>
        /// Method which adds a value to the tree
        /// </summary>
        /// <param name="value">Value to add</param>
        public void AddValue(int value)
        {
            Node tmp = new Node();
            tmp.Value = value;
            tmp.Left = null;
            tmp.Right = null;
            if (this.head == null)
            {
                this.head = tmp;
                return;
            }
            Node tmp1 = this.head;
            while ((tmp1.Left != null) || (tmp1.Right != null))
            {
                if ((value < tmp1.Value) && (tmp1.Left != null))
                    tmp1 = tmp1.Left; 
                if ((value >= tmp1.Value) && (tmp1.Right != null))
                    tmp1 = tmp1.Right;
                if (((value < tmp1.Value) && (tmp1.Left == null)) || ((value >= tmp1.Value) && (tmp1.Right == null)))
                    break;
            }
            if (value < tmp1.Value)
                tmp1.Left = tmp;
            else
                tmp1.Right = tmp;
        }
    }
}
