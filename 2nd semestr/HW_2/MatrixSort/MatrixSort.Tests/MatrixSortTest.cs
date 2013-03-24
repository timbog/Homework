using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatrixSort;

namespace MatrixSort.Tests
{
    [TestClass]
    public class MatrixSortTest
    {
        [TestMethod]
        public void SwapTest()
        {
            int number1 = 5;
            int number2 = 6;
            MatrixSort.Swap(ref number1, ref number2);
            Assert.AreEqual(number1, 6);
            Assert.AreEqual(number2, 5);
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
            MatrixSort.InsertSort(matrix);
            Assert.AreEqual(matrix[0, 0], 1);
            Assert.AreEqual(matrix[0, 1], 3);
            Assert.AreEqual(matrix[0, 2], 4);
            Assert.AreEqual(matrix[1, 0], 1);
            Assert.AreEqual(matrix[1, 1], 5);
            Assert.AreEqual(matrix[1, 2], 6);
            Assert.AreEqual(matrix[2, 0], 4);
            Assert.AreEqual(matrix[2, 1], 8);
            Assert.AreEqual(matrix[2, 2], 2);
        }
    }
}
