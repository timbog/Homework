using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BubbleGenericSort
{
    public class Comparator
    {
        /// <summary>
        /// Compare method
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="value1">First value</param>
        /// <param name="value2">Second value</param>
        /// <returns>If first value is bigger</returns>
        public bool Compare<T>(T value1, T value2)
        {
            int temp1 = value1.GetHashCode();
            int temp2 = value2.GetHashCode();
            return (temp1 > temp2);
        }
    }
}
