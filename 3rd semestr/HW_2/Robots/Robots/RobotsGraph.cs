using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class RobotsGraph
    {
        /// <summary>
        /// Size of the matrix
        /// </summary>
        public int matrixSize { get; set; }

        /// <summary>
        /// Base matrix
        /// </summary>
        public int[,] oldMatrix { get; set; }

        /// <summary>
        /// Changed matrix
        /// </summary>
        public int[,] newMatrix { get; set; }

        /// <summary>
        /// Shows if point is visited
        /// </summary>
        public bool[] visited { get; set; }

        /// <summary>
        /// Answer
        /// </summary>
        public bool result { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="matrix">Base matrix</param>
        /// <param name="size">Size of the matrix</param>
        /// <param name="robotAmount">Amount of robots</param>
        /// <param name="robotCoordinates">Coordinates of robots</param>
        public RobotsGraph(int[,] matrix, int size, int robotAmount, int[] robotCoordinates)
        {
            this.result = true;
            this.matrixSize = size;
            this.oldMatrix = matrix;
            this.newMatrix = new int[this.matrixSize, this.matrixSize];
            this.visited = new bool[size];
            for (int i = 0; i < matrixSize; ++i)
            {
                visited[i] = false;
            }
            this.BuildNewMatrix(0);
            bool flag = false;
            for (int j = 0; j < robotAmount; ++j)
            {
                for (int k = 0; k < robotAmount; ++k)
                {
                    if (this.WayExists(robotCoordinates[j], robotCoordinates[k]))
                        flag = true;
                }
                if (!flag)
                {
                    this.result = false;
                    return;
                }
                flag = false;
            }
        }

        /// <summary>
        /// Method which is used to build a new tree
        /// </summary>
        /// <param name="index">From which index to build</param>
        public void BuildNewMatrix(int index)
        {
            visited[index] = true;
            for (int i = 0; i < matrixSize; ++i)
            {
                if ((oldMatrix[index, i] != 0) && (!visited[i]))
                {
                    visited[i] = true;
                    for (int j = 0; j < matrixSize; ++j)
                    {
                        if ((oldMatrix[i, j] != 0) && (!visited[j]))
                        {
                            newMatrix[index, j] = 1;
                            newMatrix[j, index] = 1;
                            this.BuildNewMatrix(j);
                        }
                    }
                }
            }
            for (int i = 0; i < matrixSize; ++i)
            {
                visited[i] = false;
            }
        }

        /// <summary>
        /// If two points are connected
        /// </summary>
        /// <param name="firstPoint">First point coordinate</param>
        /// <param name="secondPoint">Second point coordinate</param>
        /// <returns>Connection information</returns>
        public bool WayExists(int firstPoint, int secondPoint)
        {
            if (newMatrix[firstPoint,secondPoint] == 1)
                return true;
            visited[firstPoint] = true;
            for (int i = 0; i < matrixSize; ++i)
            {
                if ((oldMatrix[firstPoint, i] != 0) && (!visited[i]))
                {
                    if (this.WayExists(i, secondPoint))
                        return true;
                }
            }
            return false;
        }

    }
}
