using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueu
{
    class Program
    {
        static void Main(string[] args)
        {
            Queu queu = new Queu();
            queu.EnQueu(4, 5);
            queu.EnQueu(3, 3);
            Console.WriteLine(queu.Dequeu());
        }
    }
}
