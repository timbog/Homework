using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolList
{
    public class Change
    {
        /// <summary>
        /// Filter method
        /// </summary>
        /// <param name="list">List</param>
        /// <param name="function">Bool Function with int parameter</param>
        /// <returns>Changed with this function list</returns>
        public static List<int> Filter(List<int> list, Func<int, bool> function)
        {
            List<int> tmp = new List<int>();
            for (int i = 0; i < list.Count(); ++i)
            {
                if (function(list[i]))
                {
                    tmp.Add(list[i]);
                }
            }
            return tmp;
        }
    }
}
