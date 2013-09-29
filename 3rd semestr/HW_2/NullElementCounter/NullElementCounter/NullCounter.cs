using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullElementCounter
{
    public class NullCounter
    {
        /// <summary>
        /// Method which counts amount of null elements
        /// </summary>
        /// <param name="array">Array to look throw</param>
        /// <returns>Amount of null elements</returns>
        public int Count(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] == 0)
                    ++count;
            }
            return count;
        }
    }
}
