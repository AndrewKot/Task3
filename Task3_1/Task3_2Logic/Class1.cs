using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_2Logic
{
    public class Class1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="N"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        public static T[] SorterArray<T>(T[] array, IComparer<T> comparer)
        {
            T[] temp = new T[array.Length];

            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = array[i];
            }

            Array.Sort(temp, comparer);
            T[] filteredTemp = temp.Distinct().ToArray();

            return filteredTemp;
        }
    }
}
