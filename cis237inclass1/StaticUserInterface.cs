using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    static class StaticUserInterface
    {
        //No Variables
        //No Properties
        //No Construcors (but we could if we needed to)

        //*****************************
        //Methods
        //*****************************
        public static int GetUserInput()
        {
            //Print out a menu
            PrintMenu();  //calling a method

            //Get the input from the user
            String input = Console.ReadLine();

            //While te imput is not valid re-get the input
            while (input != "1" && input != "2")
            {

                //Print Error message
                PrintErrorMessage();

                //re-pring the menu
                PrintMenu();

                //et the input from the console again
                input = Console.ReadLine();

            }
            //At this pint, I kow the input is a valid number of either
            //a 1 or a 2.

            return Int32.Parse(input);
        }

        public static void Output(string outputString)
        {
            Console.WriteLine(outputString);
        }


        private static void PrintMenu()
        {
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("1. Print List");
            Console.WriteLine("2. Exit");
        }

        private static void PrintErrorMessage()
        {
            Console.WriteLine("That is not a valid entry Dave");
            Console.WriteLine("Please make a valid choice");
            Console.WriteLine();
        }
    }
}
