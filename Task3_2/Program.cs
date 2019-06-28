using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3_2Logic;

namespace Task3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string masterString;
            string[] tempString = null;
            char[] tempCharArray = null;
            char[] sortedArray = null;

            do
            {
                Console.Clear();
                Console.WriteLine("'exit' - exit from the program" +
                    "\n'input' - input stings" +
                    "\n'merge' - merge strings");

                if (tempString != null)
                {
                    for (int i = 0; i < tempString.Length; i++)
                    {
                        Console.Write(tempString[i] + " ");
                    }
                }

                Console.WriteLine();
                if (sortedArray != null)
                {
                    for (int i = 0; i < sortedArray.Length; i++)
                    {
                        Console.Write(sortedArray[i]);
                    }
                }

                Console.WriteLine();
                masterString = Console.ReadLine();
                switch(masterString)
                {
                    case "input":
                        {
                            Console.WriteLine("input two strings in format 'string1/string2', plese:");
                            try
                            {
                                tempString = Console.ReadLine().Split('/');
                                tempCharArray = MergeStrings(tempString[0], tempString[1]);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("error input, press 'Enter' to continue, plese");
                                tempString = null;
                                Console.ReadLine();
                            }
                            break;
                        }
                    case "merge":
                        {
                            try
                            {
                                sortedArray = Task3_2Logic.Class1.SorterArray(tempCharArray, new CharComparable());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("error input, press 'Enter' to continue, plese");
                                Console.ReadLine();
                            }

                            break;
                        }
                }

            } while (masterString != "exit");
        }

        public static char[] MergeStrings(string st1, string st2)
        {
            string tempStr = st1 + st2;
            char[] temp = new char[(tempStr).Length];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = tempStr[i];
            }
            return temp;
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
