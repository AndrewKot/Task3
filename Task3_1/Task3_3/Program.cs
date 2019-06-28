using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Task3_3Logic;

namespace Task3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = null;
            string[] tempString;
            string masterString;

            do
            {
                Console.Clear();
                Console.WriteLine("'exit' - exit from the program" +
                    "\n'input' - input data");
                
                if (data != null)
                {
                    try
                    {
                        Console.WriteLine(Task3_3Logic.Class1.Insertion(data[0], data[1], data[2], data[3]));
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("error input, press 'Enter' to continue, plese");
                        Console.ReadLine();
                    }
                    
                }

                masterString = Console.ReadLine();

                switch (masterString)
                {
                    case "input":
                        {
                            Console.WriteLine("input number1, number2, initial index and final index in format 'number1/number2/inialIndex/finalIndex'");
                            try
                            {
                                data = null;
                                tempString = Console.ReadLine().Split('/');
                                data = new int[tempString.Length];
                                for (int i = 0; i < tempString.Length; i++)
                                {
                                    data[i] = Convert.ToInt32(tempString[i]);
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("error input");
                                Console.ReadLine();
                                data = null;
                            }
                            break;
                        }
                    default:
                        break;
                }
            } while (masterString != "exit");
        }
    }
}
