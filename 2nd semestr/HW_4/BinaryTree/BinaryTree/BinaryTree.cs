using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinaryTree
    {
        public class TreeElement
        {
            public int value;
            public TreeElement left;
            public TreeElement right;
        }

        private TreeElement head;

        public BinaryTree()
        {
            this.head = null;
        }

        public void Add (int val)
        {
	        TreeElement tmp = new TreeElement();
	        tmp.value = val;
	        tmp.left = null;
	        tmp.right = null;
            if (this.head == null)
            {
                this.head = tmp;
                return;
            }

    }
}
