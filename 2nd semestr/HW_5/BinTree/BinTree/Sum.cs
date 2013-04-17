using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinTree
{
    public class Sum:Operation
    {
        /// <summary>
        /// Method which summs left and right branches
        /// </summary>
        /// <returns>Result of summing</returns>
        public override int Count()
        {
            return this.Left.Count() + this.Right.Count();
        }
        /// <summary>
        /// Method which prints "+"
        /// </summary>
        public override void PrintSymbol()
        {
            Console.Write("+");
        }
    }
}
