using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalNetwork
{
    public class Network
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="connectMatrix">Graph</param>
        /// <param name="osMatrix">Matrix with the names of the operation systems</param>
        /// <param name="virusMatrix">Matrix which shows the state of each computer</param>
        public Network(int[,] connectMatrix, string[] osMatrix, bool[] virusMatrix, int[] probabilityMatrix)
        {
            this.LinkMatrix = connectMatrix;
            this.SystemMatrix = osMatrix;
            this.VirusMatrix = virusMatrix;
            this.ProbabilityMatrix = probabilityMatrix;
        }
        /// <summary>
        /// Graph
        /// </summary>
        public int[,] LinkMatrix { get; set; }
  
        /// <summary>
        /// Matrix with the names of the operation systems
        /// </summary>
        public string[] SystemMatrix { get; set; }

        /// <summary>
        /// Matrix which shows the state of each computer
        /// </summary>
        public bool[] VirusMatrix { get; set; }

        /// <summary>
        /// Matrix with probabilities of the infections
        /// </summary>
        public int[] ProbabilityMatrix { get; set; }
 
        /// <summary>
        /// One step of the program
        /// </summary>
        public void OneMove(int[,] randomMatrix)
        {
            bool[] newInfection = new bool[LinkMatrix.GetLength(0)];
            for (int i = 0; i < LinkMatrix.GetLength(0); i++)
            {
                newInfection[i] = false;
            }
            for (int i = 0; i < LinkMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < LinkMatrix.GetLength(0); j++)
                {
                    if ((LinkMatrix[i, j] == 1) && (VirusMatrix[j]) && (!VirusMatrix[i]) && (!newInfection[j]))
                    {
                        int temp = randomMatrix[i,j];
                        if (String.Equals(SystemMatrix[i], "Windows"))
                            VirusMatrix[i] = temp <= ProbabilityMatrix[0];
                        if (String.Equals(SystemMatrix[i], "Linux"))
                            VirusMatrix[i] = temp <= ProbabilityMatrix[1];
                        if (String.Equals(SystemMatrix[i], "MacOS"))
                            VirusMatrix[i] = temp <= ProbabilityMatrix[2];
                        if (VirusMatrix[i])
                            newInfection[i] = true;
                    }
                }               
            }
        }
        /// <summary>
        /// Shows if all computers are infected 
        /// </summary>
        /// <returns>State of the system</returns>
        public bool allInfected()
        {
            for (int i = 0; i < VirusMatrix.Length; ++i)
            {
                if (!VirusMatrix[i])
                    return false;         
            }
            return true;
        }
        /// <summary>
        /// Shows which computers are infected
        /// </summary>
        /// <returns>State of the system</returns>
        public bool[] GetState()
        {
            int[,] randomMatrix = new int[LinkMatrix.GetLength(0), LinkMatrix.GetLength(0)];
            Random random = new Random();
            for (int i = 0; i < LinkMatrix.GetLength(0); ++i)
            {
                for (int j = 0; j < LinkMatrix.GetLength(0); ++j)
                {
                    int temp1 = random.Next(0, 100);
                    randomMatrix[i, j] = temp1;
                }
            }
            OneMove(randomMatrix);
            return VirusMatrix;
        }
    }
}
