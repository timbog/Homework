using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinTree
{
    public class Multiplication:Operation
    {
        /// <summary>
        /// Method which multiplies branches
        /// </summary>
        /// <returns>Multiplication of the branches</returns>
        public override int Count()
        {
            return this.Left.Count() * this.Right.Count();
        }
        /// <summary>
        /// Method which prints "*"
        /// </summary>
        public override void PrintSymbol()
        {
            Console.Write("*");
        }
    }
}
