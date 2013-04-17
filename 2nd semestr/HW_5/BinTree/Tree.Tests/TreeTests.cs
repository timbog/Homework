using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using BinTree;
namespace Tree.Tests
{
    [TestClass]
    public class TreeTests
    {
        [TestMethod]
        public void SumTest()
        {
            Sum sum = new Sum();
            sum.Value = -1;
            sum.Symbol = '+';
            Number num1 = new Number();
            num1.Value = 6;
            num1.Symbol = 'x';
            num1.Left = null;
            num1.Right = null;
            Number num2 = new Number();
            num2.Value = 2;
            num2.Symbol = 'x';
            num2.Left = null;
            num2.Right = null;
            sum.Left = num1;
            sum.Right = num2;
            Assert.AreEqual(8, sum.Count());
        }

        [TestMethod]
        public void DifferenceTest()
        {
            Difference dif = new Difference();
            dif.Value = -1;
            dif.Symbol = '+';
            Number num1 = new Number();
            num1.Value = 6;
            num1.Symbol = 'x';
            num1.Left = null;
            num1.Right = null;
            Number num2 = new Number();
            num2.Value = 2;
            num2.Symbol = 'x';
            num2.Left = null;
            num2.Right = null;
            dif.Left = num1;
            dif.Right = num2;
            Assert.AreEqual(4, dif.Count());
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            Multiplication mul = new Multiplication();
            mul.Value = -1;
            mul.Symbol = '+';
            Number num1 = new Number();
            num1.Value = 6;
            num1.Symbol = 'x';
            num1.Left = null;
            num1.Right = null;
            Number num2 = new Number();
            num2.Value = 2;
            num2.Symbol = 'x';
            num2.Left = null;
            num2.Right = null;
            mul.Left = num1;
            mul.Right = num2;
            Assert.AreEqual(12, mul.Count());
        }

        [TestMethod]
        public void DivisionTest()
        {
            Division div = new Division();
            div.Value = -1;
            div.Symbol = '+';
            Number num1 = new Number();
            num1.Value = 6;
            num1.Symbol = 'x';
            num1.Left = null;
            num1.Right = null;
            Number num2 = new Number();
            num2.Value = 2;
            num2.Symbol = 'x';
            num2.Left = null;
            num2.Right = null;
            div.Left = num1;
            div.Right = num2;
            Assert.AreEqual(3, div.Count());
        }
        [TestMethod]
        public void BuildTest()
        {
            CountTree tree = new CountTree();
            StreamReader streamReader = new StreamReader("input1.txt");
            string str = "";
            while (!streamReader.EndOfStream)
            {
                str += streamReader.ReadLine();
            }
            int temp = 0;
            tree.Build(ref temp, str);
            Assert.AreEqual(tree.head.Symbol, '/');
        }

        [TestMethod]
        public void CountThisTreeTest()
        {
            CountTree tree = new CountTree();
            StreamReader streamReader = new StreamReader("input.txt");
            string str = "";
            while (!streamReader.EndOfStream)
            {
                str += streamReader.ReadLine();
            }
            int temp = 0;
            tree.Build(ref temp, str);
            Assert.AreEqual(tree.CountThisTree(), 16);
        }
    }
}
