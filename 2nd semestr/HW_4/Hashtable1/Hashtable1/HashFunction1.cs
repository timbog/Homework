using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class HashFunction1 : Hash
    {
        /// <summary>
        /// Method which is used to count a hash function
        /// </summary>

        public int HashF(string str, int max)
        {
            int result = 0;
            int i = 0;
            while (i < str.Length)
            {
                result = result + str[i];
                ++i;
            }
            return result % max;
        }
    }
}
