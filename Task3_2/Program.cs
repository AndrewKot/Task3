using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_2
{
    class Program
    {
        public static Dictionary<int, char> downRegister = new Dictionary<int, char>();
        public static Dictionary<int, char> upRegister = new Dictionary<int, char>();
        public static Dictionary<int, char> upDownRegister = new Dictionary<int, char>();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            for (char c = 'A'; c <= 'Z'; c++)
            {
                int key = c - 'A';
                downRegister.Add(key, c);
                upDownRegister.Add(key, c);
            }

            for (char c = 'a'; c <= 'z'; c++)
            {
                int key = c - 'a';
                upRegister.Add(key, c);
                upDownRegister.Add(key + downRegister.Count, c);
            }

            for (int i = 0; i < upRegister.Count; i++)
            {
                Console.Write(upRegister[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < downRegister.Count; i++)
            {
                Console.Write(downRegister[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < upDownRegister.Count; i++)
            {
                Console.Write(upDownRegister[i]);
            }

            Console.WriteLine();

            ///

            for (int i = 0; i < upDownRegister.Count; i++)
            {
                Console.Write(upDownRegister.ElementAt(i).Key);
            }

            Console.WriteLine();

            List<char> aaa = new List<char> { 'a', 'b', 'a', 'A', 'B', 'c' };

            foreach (char item in aaa)
            {
                Console.Write(item);

            }

            Console.WriteLine();
            aaa.Sort();

            foreach (char item in aaa)
            {
                Console.Write(item);

            }

            ///

            string str1 = "abdkfwADREF";
            string str2 = "bgfjeFJEO";
            Console.WriteLine();
            Console.WriteLine(str(str1, str2));

            char[] charArray = { 'a', 'A', 'b', 'A', 'a', 'C', 'c' };
            int[] intArray = { 1, 4, 5, 3, 2, 4, 4, 6, 8, 4, 4, 2, 1 };

            Console.WriteLine();
            for (int i = 0; i < SorterArray(charArray, new CharComparable()).Length; i++)
            {
                Console.Write(SorterArray(charArray, new CharComparable())[i] + " ");
            }
            

            Console.WriteLine();
            for (int i = 0; i < SorterArray(intArray, new IntComparable()).Length; i++)
            {
                Console.Write(SorterArray(intArray, new IntComparable())[i] + " ");
            }
            

            Console.ReadLine();
        }

        public static string str(string str1, string str2)
        {
            string temp;

            temp = str1 + str2;
            List<char> tempList = new List<char>();
            for (int i = 0; i < temp.Length; i++)
            {
                tempList.Add(temp[i]);
            }

            tempList.Sort();
            List<char> tempList1 = tempList.Distinct().ToList();
            temp = null;

            for (int i = 0; i < tempList1.Count; i++)
            {
                temp += tempList1[i];
            }

            

            return temp;
        }

        public static T GetMergedObject<T>(T obj1, T obj2)
        {
            T temp = obj1 + obj2;
            return temp;
        }

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

    public class CharComparable : IComparer<char>
    {
        public int Compare(char x, char y)
        {
            if(x > y)
            {
                return 1;
            }
            else if(x < y)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }

    public class IntComparable : IComparer<int>
    {

        public int Compare(int x, int y)
        {
            if (x > y)
            {
                return 1;
            }
            else if (x < y)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }
    }
}
