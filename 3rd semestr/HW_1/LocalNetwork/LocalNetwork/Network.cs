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
        public Network(int[,] connectMatrix, string[] osMatrix, bool[] virusMatrix)
        {
            this.LinkMatrix = connectMatrix;
            this.SystemMatrix = osMatrix;
            this.VirusMatrix = virusMatrix;
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
        /// One step of the program
        /// </summary>
        public void OneMove()
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
                    if ((LinkMatrix[i, j] == 1) && (VirusMatrix[j]) && (!VirusMatrix[i]) && (!newInfection[i]))
                    {
                        int random = new Random().Next(0, 1000);
                        if (String.Equals(SystemMatrix[i], "Windows"))
                        {
                            if ((random % 5 == 1) || (random % 5 == 0))
                            {
                                VirusMatrix[i] = true;
                            }
                        }
                        if (String.Equals(SystemMatrix[i], "Linux"))
                        {
                            if (random % 5 == 3)
                            {
                                VirusMatrix[i] = true;
                            }
                        }
                        if (String.Equals(SystemMatrix[i], "MacOS"))
                        {
                            if ((random % 5 == 1) || (random % 5 == 0) || (random % 5 == 3))
                            {
                                VirusMatrix[i] = true;
                            }
                        }
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
            OneMove();
            return VirusMatrix;
        }
    }
}
