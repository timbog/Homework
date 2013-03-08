using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication5;

namespace MatrixSort.Tests
{
    [TestClass]
    public class MatrixSortTest
    {
        [TestMethod]
        public void swapTest()
        {
            int number1 = 5;
            int number2 = 6;
            Program.swap(ref number1, ref number2);
            Assert.IsTrue(number1 == 6);
            Assert.IsTrue(number2 == 5);
        }
        [TestMethod]
        public void InsertSortTest()
        {
            int[,] matrix = new int[3, 3];
            matrix[0, 0] = 3;
            matrix[0, 1] = 4;
            matrix[0, 2] = 1;
            matrix[1, 0] = 5;
            matrix[1, 1] = 6;
            matrix[1, 2] = 1;
            matrix[2, 0] = 8;
            matrix[2, 1] = 2;
            matrix[2, 2] = 4;
            Program.InsertSort(matrix);
            Assert.IsTrue(matrix[0,0] == 1);
            Assert.IsTrue(matrix[0,1] == 3);
            Assert.IsTrue(matrix[0,2] == 4);
            Assert.IsTrue(matrix[1,0] == 1);
            Assert.IsTrue(matrix[1,1] == 5);
            Assert.IsTrue(matrix[1,2] == 6);
            Assert.IsTrue(matrix[2,0] == 4);
            Assert.IsTrue(matrix[2,1] == 8);
            Assert.IsTrue(matrix[2,2] == 2);
        }
    }
}
