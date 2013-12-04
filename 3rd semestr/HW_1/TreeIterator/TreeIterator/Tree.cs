using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TreeIterator
{
    public class Tree : IEnumerable
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
        public Node Head { get; set; }

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
            if (this.Head == null)
            {
                this.Head = tmp;
                return;
            }
            Node tmp1 = this.Head;
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

        /// <summary>
        /// Method which shows what the node contains
        /// </summary>
        /// <param name="node">Node</param>
        /// <returns>Number inside the node</returns>
        public int ShowValue(Node node)
        {
            return node.Value;
        }

        /// <summary>
        /// Returns new Iterator
        /// </summary>
        /// <returns>Iterator</returns>
        public IEnumerator GetEnumerator()
        {
            return new Iterator(this);
        }

        /// <summary>
        /// Returns GetEnumerator()
        /// </summary>
        /// <returns>GetEnumerator()</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        /// <summary>
        /// Iterator itself
        /// </summary>
        class Iterator : IEnumerator
        {
            /// <summary>
            /// Constructor which makes a list from a tree
            /// </summary>
            /// <param name="tree">Concrete Tree</param>
            public Iterator(Tree tree)
            {
                MakeList(tree);
            }

            /// <summary>
            /// Position in the list
            /// </summary>
            int position = -1;

            /// <summary>
            /// List which is full of tree elements
            /// </summary>
            private List <Node> list = new List <Node>();

            /// <summary>
            /// Method which builds a list from tree
            /// </summary>
            /// <param name="tree">Concrete tree</param>
            private void MakeList(Tree tree)
            {
                if ((tree.Head.Left == null) && (tree.Head.Right == null))
                {
                    list.Add(tree.Head);
                    return;
                }
                Tree tempTree1 = new Tree();
                tempTree1.Head = tree.Head.Left;
                MakeList(tempTree1);
                this.list.Add(tree.Head);
                Tree tempTree2 = new Tree();
                tempTree2.Head = tree.Head.Left;
                MakeList(tempTree2);
            }

            /// <summary>
            /// Method which increases the position
            /// </summary>
            /// <returns>If iteraror is not out of list</returns>
            public bool MoveNext()
            {
                position++;
                return (position < list.Count);
            }

            /// <summary>
            /// Method which returns us to the beginning of the list 
            /// </summary>
            public void Reset()
            {
                position = -1;
            }

            /// <summary>
            /// Returns cuurent element
            /// </summary>
            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }
            
            /// <summary>
            /// Returns current element
            /// </summary>
            public Node Current
            {
                get
                {
                    return this.list[position];
                }
            }
        }
    }
}
