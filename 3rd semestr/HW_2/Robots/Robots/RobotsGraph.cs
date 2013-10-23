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
        private int MatrixSize;

        /// <summary>
        /// Base matrix
        /// </summary>
        private int[,] OldMatrix;

        /// <summary>
        /// Changed matrix
        /// </summary>
        private int[,] NewMatrix;

        /// <summary>
        /// Shows if point is visited
        /// </summary>
        private bool[] Visited;

        /// <summary>
        /// Answer
        /// </summary>
        public bool Result { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="matrix">Base matrix</param>
        /// <param name="size">Size of the matrix</param>
        /// <param name="robotAmount">Amount of robots</param>
        /// <param name="robotCoordinates">Coordinates of robots</param>
        public RobotsGraph(int[,] matrix, int[] robotCoordinates)
        {
            this.Result = true;
            this.MatrixSize = matrix.GetLength(0);
            this.OldMatrix = matrix;
            this.NewMatrix = new int[this.MatrixSize, this.MatrixSize];
            this.Visited = new bool[matrix.Length];
            for (int i = 0; i < MatrixSize; ++i)
            {
                Visited[i] = false;
            }
            this.BuildNewMatrix(0);
            bool flag = false;
            for (int j = 0; j < robotCoordinates.Length; ++j)
            {
                for (int k = 0; k < robotCoordinates.Length; ++k)
                {
                    if (this.WayExists(robotCoordinates[j], robotCoordinates[k]))
                        flag = true;
                }
                if (!flag)
                {
                    this.Result = false;
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
            Visited[index] = true;
            for (int i = 0; i < MatrixSize; ++i)
            {
                if ((OldMatrix[index, i] != 0) && (!Visited[i]))
                {
                    Visited[i] = true;
                    for (int j = 0; j < MatrixSize; ++j)
                    {
                        if ((OldMatrix[i, j] != 0) && (!Visited[j]))
                        {
                            NewMatrix[index, j] = 1;
                            NewMatrix[j, index] = 1;
                            this.BuildNewMatrix(j);
                        }
                    }
                }
            }
            for (int i = 0; i < MatrixSize; ++i)
            {
                Visited[i] = false;
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
            if (NewMatrix[firstPoint,secondPoint] == 1)
                return true;
            Visited[firstPoint] = true;
            for (int i = 0; i < MatrixSize; ++i)
            {
                if ((NewMatrix[firstPoint, i] != 0) && (!Visited[i]))
                {
                    if (this.WayExists(i, secondPoint))
                        return true;
                }
            }
            return false;
        }
    }
}
