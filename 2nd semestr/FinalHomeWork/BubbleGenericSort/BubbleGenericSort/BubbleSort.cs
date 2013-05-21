using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BubbleGenericSort
{
    public class BubbleSort<T>
    {
        /// <summary>
        /// Sort method
        /// </summary>
        /// <param name="array">Array to sort</param>
        /// <param name="size">Size of the array</param>
        /// <param name="comparator">Comparator to compare</param>
        /// <returns>Sorted array</returns>
        public T[] Sort(T[] array, int size, Comparator comparator)
        {
            for (int j = 0; j < size - 1; ++j)
            {
                for (int i = 0; i < size - j - 1; ++i)
                {
                    if (comparator.Compare(array[i], array[i + 1]))
                    {
                        T temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
            return array;
        }
    }
}
