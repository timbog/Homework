﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Robots.Tests
{
    [TestClass]
    public class RobotsTests
    {
        [TestMethod]
        public void RobotsGraphTest()
        {
            int[,] matrix = new int[4, 4];
            matrix[0, 0] = 0;
            matrix[0, 1] = 1;
            matrix[0, 2] = 0;
            matrix[0, 3] = 0;
            matrix[1, 0] = 1;
            matrix[1, 1] = 0;
            matrix[1, 2] = 1;
            matrix[1, 3] = 0;
            matrix[2, 0] = 0;
            matrix[2, 1] = 1;
            matrix[2, 2] = 0;
            matrix[2, 3] = 1;
            matrix[3, 0] = 0;
            matrix[3, 1] = 0;
            matrix[3, 2] = 1;
            matrix[3, 3] = 0;
            int[] coordinates = new int[2];
            coordinates[0] = 0;
            coordinates[1] = 3;
            RobotsGraph graph = new RobotsGraph(matrix, coordinates);
            Assert.IsFalse(graph.Result);
        }
    }
}
