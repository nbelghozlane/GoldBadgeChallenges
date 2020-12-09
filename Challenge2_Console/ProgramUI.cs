using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2_Console
{
    class ProgramUI
    {
        public void Run()
        {
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Hello! Welcome to the Komodo Claims Department Application!\n" +
                "Please select a menu option:\n" +
                " \n" +
                "1. View All Claims\n" +
                "2. Work On Next Claim\n" +
                "3. Create New Claim\n" +
                "4. Exit\n" +
                " ");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        ViewAllClaims();
                        break;
                    case "2":
                        WorkOnNextClaim();
                        break;
                    case "3":
                        CreateNewClaim();
                        break;
                    case "4":
                        Console.WriteLine("Thank you for using the Komodo Claims Department Application! Goodbye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }

                Console.WriteLine("Please press any key to continue.");
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
