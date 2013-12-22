using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LocalNetwork;

namespace LocalNetwork.Tests
{
    [TestClass]
    public class LocalNetworkTests
    {
        [TestMethod]
        public void OneMoveTest()
        {
            int[,] matrix = new int[3,3];
            matrix[0, 0] = 0;
            matrix[0, 1] = 1;
            matrix[0, 2] = 0;
            matrix[1, 0] = 1;
            matrix[1, 1] = 0;
            matrix[1, 2] = 1;
            matrix[2, 0] = 0;
            matrix[2, 1] = 1;
            matrix[2, 2] = 0;
            string[] osMatrix = new string[3];
            osMatrix[0] = "Windows";
            osMatrix[1] = "Linux";
            osMatrix[2] = "MacOS";
            bool[] virusMatrix = new bool[3];
            virusMatrix[0] = true;
            virusMatrix[1] = false;
            virusMatrix[2] = false;
            int[] probabilityMatrix = new int[3];
            probabilityMatrix[0] = 100;
            probabilityMatrix[1] = 100;
            probabilityMatrix[2] = 100;
            Network network = new Network(matrix, osMatrix, virusMatrix, probabilityMatrix);
            bool[] state = network.GetState();
            Assert.IsTrue(!network.allInfected());
            state = network.GetState();
            Assert.IsTrue(network.allInfected());
        }
    }
}
