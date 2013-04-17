using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinTree
{
    public class Difference:Operation
    {
        /// <summary>
        /// Method which substracts right branch from the left branch
        /// </summary>
        /// <returns>Result of Substraction</returns>
        public override int Count()
        {
            return this.Left.Count() - this.Right.Count();
        }

        /// <summary>
        /// Method which prints "-"
        /// </summary>
        public override void PrintSymbol()
        {
            Console.Write("-");
        }
    }
}
