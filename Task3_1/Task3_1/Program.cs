using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3_1Logic;
using UserInterface;

namespace Task3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<int> _int = new List<int>
            {
                1,2,3,4,5,6,9,8,7,5,1,2,3,6,5,4,3,2,1
            };

            List<int> _int2 = new List<int>
            {
                1,2,3,4,5,4,3,2,1,0,0,9
            };

            Console.WriteLine(Task3_1Logic.FundingNumberClass.LeftSum(_int, 3));
            Console.WriteLine(Task3_1Logic.FundingNumberClass.RightSum(_int, 3));

            Console.WriteLine();

            Console.WriteLine(Task3_1Logic.FundingNumberClass.Number(_int2));

            List<Action> a = new List<Action> { };
            a.Add(Console.WriteLine);

            Console.WriteLine();
            int f = 1;
            Console.WriteLine(f);
            f = Plus(f);
            Console.WriteLine(f);

            List<string> optionList = new List<string> { "Exit" };
            List<Action> methodList = new List<Action>();

            MainMenu.Start("MainMenu", optionList, methodList, optionList);

            Console.ReadLine();
        }

        public static int Plus(int plus)
        {
            return ++plus;
        }
    }
}
