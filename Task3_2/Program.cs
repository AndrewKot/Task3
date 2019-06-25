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

            

            Console.ReadLine();
        }
    }
}
