using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_2
{
    class Program
    {
        //List<char> downRegister = new List<char>
        //{
        //    'a',
        //    'b',
        //    'c',
        //    'd',
        //    'e',
        //    'f',
        //};

        //List<string> keyList = new List<string>(this.yourDictionary.Keys);
        public static Dictionary<int, string> countries;
        public static Dictionary<int, char> downRegister = new Dictionary<int, char>();
        public static Dictionary<int, char> upRegister = new Dictionary<int, char>();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            countries = new Dictionary<int, string>(1);
            countries.Add(1, "Great Britian");

            Console.WriteLine(countries);

            foreach (KeyValuePair<int, string> keyValue in countries)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }

            for (char c = 'A'; c <= 'Z'; c++)
            {
                int key = c - 'A';
                downRegister.Add(key, c);
            }

            for (char c = 'a'; c <= 'z'; c++)
            {
                int key = c - 'a';
                upRegister.Add(key, c);
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

            


            Console.ReadLine();
        }
    }
}
