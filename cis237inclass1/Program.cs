using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a new instance of the user interface class
            UserInterface ui = new UserInterface();


            //Here is a new employying being created using the default 
            //constructor that we wrote in the employee class
            //Even though we arnt using it, I want you to see a single instance
            //of one vs an array of them.
            Employee myEmployee = new Employee();

            //Lets make an array to hold a bumch of instances of the Employee class
            Employee[] employees = new Employee[10];

            //Lets add some employees to our array
            employees[0] = new Employee("David", "Barnes", 835.00m);  //"m" a the end convers to a decimal
            employees[1] = new Employee("James", "Kirk", 453.00m);
            employees[2] = new Employee("Jean-Luc", "Pircard", 290.00m);
            employees[3] = new Employee("Benjamin", "Sisko", 587.30m);
            employees[4] = new Employee("John", "Deere", 456.00m);
            employees[5] = new Employee("Poop", "Nuggett", 684.00m);

            //Get some input from the user
            int choice = ui.GetUserInput();

            //While the chouse they slected is not 2, continue to do work
            while (choice != 2)
            {
                //See if the input they sent is equal to 1.
                if (choice == 1)
                {
                    //Create a sring that can me concated to 
                    string outputString = "";

                    //Print out the emploees in the array
                    foreach (Employee employee in employees)
                    {
                        if (employee != null)
                        {

                            //concat to te outputstring
                            outputString += employee.ToString() +
                                Environment.NewLine;
                        }
                    }

                    //Use the US class to print out the string
                    ui.Output(outputString);
                }

                //re-prompt te user for input
                choice = ui.GetUserInput();
            }
        }
    }
}
