using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class HashFunction2 : Hash
    {
        /// <summary>
        /// Method which is used to count a hash function
        /// </summary>
        public int HashF(string str, int max)
        {
            int len = str.Length;
            int hashf = 0;
            if (len <= 1)
                hashf = str[0];
            else
                hashf = str[0] + str[len - 1];
            return hashf % max;
        }
    }
}
