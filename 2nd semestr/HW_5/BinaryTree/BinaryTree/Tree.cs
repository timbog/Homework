using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace BinaryTree
{
    public class Tree
    {
        public class TreeElement
        {
            public TreeElement Left { get; set; }

            public TreeElement Right { get; set; }

            public char Element { get; set; }

            public int Value { get; set; }
        }

        public TreeElement head { get; set; }

        public Tree()
        {
            this.head = null;
        }
        public void Build(ref int index)
        {
            StreamReader streamReader = new StreamReader("input.txt");
            string str = "";
            while (!streamReader.EndOfStream)
            {
                str += streamReader.ReadLine();
            }
            TreeElement tmp = new TreeElement();
            while (((str[index] == ' ') || (str[index] == ')')) && (index < str.Length))
                ++index;
            if ((str[index] == '+') || (str[index] == '-') || (str[index] == '/') || (str[index] == '*'))
            {
                tmp.Element = str[index];
                tmp.Value = -1;
                ++index;
            }
            if ((index < str.Length) && (str[index] == '('))
            {
                Tree tree1 = new Tree();
                ++index;
                tree1.Build(ref index);
                Tree tree2 = new Tree();
                ++index;
                tree2.Build(ref index);
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
                index = j;
                tmp.Value = number;
                tmp.Element = 'x';
            }
            this.head = tmp;
        }
        public void Print()
        {
            TreeElement tmp = this.head;
            if (tmp == null)
            {
                Console.WriteLine("Empty tree");
                return;
            }
            if (tmp.Element == 'x')
                Console.Write(tmp.Value);
            else
            {
                Console.Write("(");
                Tree tempTree1 = new Tree();
                tempTree1.head = tmp.Left;
                tempTree1.Print();
                Console.Write(tmp.Element);
                Tree tempTree2 = new Tree();
                tempTree2.head = tmp.Right;
                tempTree2.Print();
                Console.Write(")");
            }

        }
    }
}
