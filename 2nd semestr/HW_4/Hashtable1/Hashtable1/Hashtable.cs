using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public interface Hash
    {
        int HashF(string str, int max);
    }

    public class HashFunction1 : Hash
    {
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

    public class HashFunction2 : Hash
    {
        public int HashF(string str, int max)
        {
            int len = str.Length;
            int hashf = 0;
            if (len <= 1)
                hashf = str[0];
            else
                hashf = str[0] + str[len - 1];
            return hashf % 101;
        }
    }

    public class HashTable
    {
        private int size;

        private List[] data;

        public Hash hash;

        public HashTable(int s, Hash hs)
        {
            this.size = s;
            this.hash = hs;
            data = new List[s];
            for (int i = 0; i < s; ++i)
            {
                data[i] = new List();
            }
        }

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

        public bool Search(string str)
        {
            int index = this.hash.HashF(str, this.size);
            if (this.data[index].Exist(str) != -1)
                return true;
            return false;
        }
    }
}
