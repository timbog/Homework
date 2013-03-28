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
        /// Array of lists
        /// </summary>
        private List[] data;

        /// <param name="amount">Size of the hashtable</param>
        public HashTable(int amount)
        {
            this.size = amount;
            data = new List[amount];
            for (int i = 0; i < amount; ++i)
            {
                data[i] = new List();
            }
        }

        /// <summary>
        /// Hash function
        /// </summary>
        public int Hash(string str, int max)
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

        /// <summary>
        /// Method which is used to add a word to the hashtable
        /// </summary>
        public void AddToTable(string str)
        {
            int index = Hash(str, this.size);
            if (this.data[index].Exist(str) == -1)
            {
                this.data[index].Add(str, 1);
            }
            else
            {
                ++this.data[index].Position(this.data[index].Exist(str)).Num;
            }
        }

        /// <summary>
        /// Method which is used to print the hashtable
        /// </summary>
        public void PrintHt()
        {
            for (int i = 0; i < this.size; ++i)
                this.data[i].Print();
        }

        /// <summary>
        /// Method which is used to delete the value from the hashtable
        /// </summary>
        public void DeleteFromTable(string str)
        {
            int index = Hash(str, this.size);
            if (this.data[index].Exist(str) >= 0)
            {
                --this.data[index].Position(this.data[index].Exist(str)).Num;
                if (this.data[index].Position(this.data[index].Exist(str)).Num == 0)
                    this.data[index].Delete(str);
            }
        }

        /// <summary>
        /// Method which is used to find a word in the hashtable
        /// </summary>
        public bool Search(string str)
        {
            int index = Hash(str, this.size);
            return (this.data[index].Exist(str) != -1);
        }
    }
}
