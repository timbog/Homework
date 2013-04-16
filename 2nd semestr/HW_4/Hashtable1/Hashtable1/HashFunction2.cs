using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class HashFunction2 : IHash
    {
        /// <summary>
        /// Method which is used to count a hash function
        /// </summary>
        public int HashF(string str, int max)
        {
           return str.GetHashCode() % (max - 1);
        }
    }
}
