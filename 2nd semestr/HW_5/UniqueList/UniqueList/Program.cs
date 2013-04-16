using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueList
{
    class Program
    {
        static void Main(string[] args)
        {
            UniqueList list= new UniqueList();
            list.Add(5);
            list.Add(6);
            list.Delete(5);
            list.Print();
        }
    }
}
