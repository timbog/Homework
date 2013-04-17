using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinTree
{
    public class Division:Operation
    {
        /// <summary>
        /// Method which divides left branch by right branch
        /// </summary>
        /// <returns>Division of the branchrs</returns>
        public override int Count()
        {
            return this.Left.Count() / this.Right.Count();
        }
        /// <summary>
        /// Method which prints "/"
        /// </summary>
        public override void PrintSymbol()
        {
            Console.Write("/");
        }
    }
}
