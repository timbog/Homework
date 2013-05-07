using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldFunction
{
    public class Change
    {
        /// <summary>
        /// Fold function
        /// </summary>
        /// <param name="list">List</param>
        /// <param name="value">Start value</param>
        /// <param name="function">Changing function</param>
        /// <returns>Integer result of Fold function</returns>
        public static int Fold(List<int> list, int value, Func<int, int, int> function)
        {
            for (int i = 0; i < list.Count; ++i)
            {
                value = function(value, list[i]);
            }
            return value;
        }
    }
}
