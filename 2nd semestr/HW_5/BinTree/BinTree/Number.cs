using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinTree
{
    public class Number:Tree
    {
        /// <summary>
        /// Method which prints value
        /// </summary>
        public override void Print()
        {
            Console.Write(' ');
            Console.Write(Value);
            Console.Write(' ');
        }
        /// <summary>
        /// Method which returns value
        /// </summary>
        /// <returns>Value</returns>
        public override int Count()
        {
            return (this.Value);
        }
    }
}
