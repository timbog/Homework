using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication4;
namespace Spiral.Test
{
    [TestClass]
    public class SpiralTest
    {
        [TestMethod]
        public void SpiralTest1()
        {
            int[,] matrix = new int[Program.arraySize, Program.arraySize];
            for (int i = 0; i < Program.arraySize; ++i)
            {
                for (int j = 0; j < Program.arraySize; ++j)
                {
                    matrix[i, j] = j;
                }
            }
            Program.SpiralWrite(matrix);           
        }
    }
}
