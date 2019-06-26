using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    public static class MainMenu
    {
        public static string nameMenu = "MainMenu";

        public static void ShowNameMenu(string nameMenu)
        {
            Console.WriteLine(nameMenu + "\n");
        }

        public static void ShowOptions(List<string> optionList)
        {
            for (int i = 0; i < optionList.Count; i++)
            {
                Console.WriteLine(optionList[i]);
            }
        }

        public static List<Action> ListOfMethods(List<Action> listOfMethods)
        {
            return listOfMethods;
        }

        public static List<string> ListOfCommands(List<string> listOfCommands)
        {
            return listOfCommands;
        }

        public static void Start(string nameMenu, /*List<string> optionList,*/ List<Action> listOfMethods/*, List<string> listOfCommands*/)
        {
            Console.WriteLine(nameMenu + "\n");
            for (int i = 0; i < listOfMethods.Count; i++)
            {
                Console.WriteLine(i + ". " + listOfMethods[i].Method.Name);
            }
            string commandString = null;
            do
            {
                try
                {
                    commandString = Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("incorrect value");
                    Console.ReadLine();
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    ClearCurrentConsoleLine();
                }
                for (int i = 0; i < listOfMethods.Count; i++)
                {
                    if (commandString == listOfMethods[i].Method.Name)
                    {
                        try
                        {
                            listOfMethods[i]();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("null"); ;
                        }
                        
                    }
                }
            } while (commandString != "Exit");
            Console.Clear();
        }

        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
}
