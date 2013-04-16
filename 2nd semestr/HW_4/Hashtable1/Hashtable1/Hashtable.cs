using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class HashTable
    {
        /// <summary>
        /// Size of the hashtable
        /// </summary>
        private int size;

        /// <summary>
        /// Array of the lists
        /// </summary>
        private List[] data;

        /// <summary>
        /// Hash function
        /// </summary>
        public IHash hash;

        /// <param name="amount">Size of the hashtable</param>
        public HashTable(int amount, IHash hash)
        {
            this.size = amount;
            this.hash = hash;
            data = new List[amount];
            for (int i = 0; i < amount; ++i)
            {
                data[i] = new List();
            }
        }

        /// <summary>
        /// Method which is used to add a word to the hashtable
        /// </summary>
        public void AddToTable(string str)
        {
            int index = this.hash.HashF(str, this.size);
            if (this.data[index].Exist(str) == -1)
            {
                this.data[index].Add(str, 1);
            }
            else
            {
                ++this.data[index].Position(this.data[index].Exist(str)).num;
            }
        }

        /// <summary>
        /// Method which is used to delete the value from the hashtable
        /// </summary>
        public void DeleteFromTable(string str)
        {
            int index = this.hash.HashF(str, this.size);
            if (this.data[index].Exist(str) >= 0)
            {
                --this.data[index].Position(this.data[index].Exist(str)).num;
                if (this.data[index].Position(this.data[index].Exist(str)).num == 0)
                    this.data[index].Delete(str);
            }
        }

        /// <summary>
        /// Method which is used to find a word in the hashtable
        /// </summary>
        public bool Search(string str)
        {
            int index = this.hash.HashF(str, this.size);
            return (this.data[index].Exist(str) != -1);
        }
    }
}
