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
            MatrixSort matrixSort = new MatrixSort();
            int number1 = 5;
            int number2 = 6;
            matrixSort.Swap(ref number1, ref number2);
            Assert.AreEqual(number1, 6);
            Assert.AreEqual(number2, 5);
        }

        [TestMethod]
        public void InsertSortTest()
        {
            int[,] matrix = new int[3, 3];
            MatrixSort matrixSort = new MatrixSort();
            matrixSort.ArrayHigh = 3;
            matrixSort.ArrayLen = 3;
            matrix[0, 0] = 3;
            matrix[0, 1] = 4;
            matrix[0, 2] = 1;
            matrix[1, 0] = 5;
            matrix[1, 1] = 6;
            matrix[1, 2] = 1;
            matrix[2, 0] = 8;
            matrix[2, 1] = 2;
            matrix[2, 2] = 4;
            matrixSort.InsertSort(ref matrix);
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