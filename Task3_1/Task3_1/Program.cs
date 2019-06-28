using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3_1Logic;
using UserInterface;
using System.Reflection;

namespace Task3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> list = new List<int>();
            Random random = new Random();
            string masterString;
            string[] tempArray;

            do
            {
                Console.Clear();
                Console.WriteLine("'random' - input random array\n'exit' - exit from the program" +
                    "\n'userArray' - input user array\n'search' - find element");
                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write(list[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine();
                masterString = Console.ReadLine();
                switch(masterString)
                {
                    case "random":
                        {
                            Console.WriteLine("enter minValu, maxValu, size in format 'minValue/maxValue/size'");
                            try
                            {
                                tempArray = Console.ReadLine().Split('/');
                                int minValue = Convert.ToInt32(tempArray[0]);
                                int maxValue = Convert.ToInt32(tempArray[1]);
                                int size = Convert.ToInt32(tempArray[2]);
                                list.Clear();
                                for (int i = 0; i < size; i++)
                                {
                                    list.Add(random.Next(minValue, maxValue));
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("input error, press 'Enter' to continue, please");
                                Console.ReadLine();
                            }
                            
                            break;
                        }
                    case "userArray":
                        {
                            Console.WriteLine("fill array in format 'a[0]/a[1]/.../a[n]'");
                            try
                            {
                                tempArray = Console.ReadLine().Split('/');
                                list.Clear();
                                for (int i = 0; i < tempArray.Length; i++)
                                {
                                    list.Add(Convert.ToInt32(tempArray[i]));
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("input error, press 'Enter' to continue, please");
                                Console.ReadLine();
                            }
                            break;
                        }
                    case "search":
                        {
                            try
                            {
                                Console.WriteLine(Task3_1Logic.FundingNumberClass.Number(list));
                                Console.ReadLine();
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("input error, press 'Enter' to continue, please");
                                Console.ReadLine();
                            }
                            break;
                        }
                }
            } while (masterString != "exit");
        }
    }
}
