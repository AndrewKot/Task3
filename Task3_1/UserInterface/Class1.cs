using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    public static class MenuMeny
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

        public static void Start(string nameMenu, List<string> optionList, List<Action> listOfMethods, List<string> listOfCommands)
        {
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
                }
                for (int i = 0; i < listOfCommands.Count; i++)
                {
                    if (commandString == listOfCommands[i])
                    {
                        listOfMethods[i]();
                    }
                }
            } while (commandString != listOfCommands[0]);
        }
    }
}
