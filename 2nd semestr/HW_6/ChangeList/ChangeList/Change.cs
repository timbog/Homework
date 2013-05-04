using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
{
    public class Change
    {
        /// <summary>
        /// Changing function
        /// </summary>
        /// <param name="list">List to change</param>
        /// <param name="function">Operation to do</param>
        /// <returns>Changed list</returns>
        public static List <int> Map(List <int> list, Func <int, int> function)
        {
            List <int> tmp = new List <int>();
            for (int i = 0; i < list.Count(); ++i)
            {
                tmp.Add(function(list[i]));
            }
            return tmp;
        }
    }
}
