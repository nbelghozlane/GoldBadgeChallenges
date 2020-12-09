using Challenge2_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2_Console
{
    class ProgramUI
    {
        private ClaimRepository _claimRepo = new ClaimRepository();

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

        private void ViewAllClaims()
        {
            /* Drew's source:
             * Console.WriteLine($"|{"Left",-7}|{"Right",7}|{"FarRight",14}|");

            const int FieldWidthRightAligned = 30;
            Console.WriteLine($"{Math.PI,FieldWidthRightAligned} - default formatting of the pi number");
            Console.WriteLine($"{Math.PI,FieldWidthRightAligned:F3} - display only three decimal digits of the pi number");
            Console.WriteLine($"{Math.PI,FieldWidthRightAligned:F3} - display only three decimal digits of the pi number");*/
        }

        private void WorkOnNextClaim()
        {

        }

        private void CreateNewClaim()
        {
            Console.Clear();
            ClaimClass newClaim = new ClaimClass();

            Console.WriteLine("Enter the Claim ID number:");
            newClaim.ClaimID = Console.ReadLine();

            Console.WriteLine("Choose the claim type (enter in number):\n" +
                "1. Car\n" +
                "2. Home\n" +
                "3. Theft\n");

            string claimTypeString = Console.ReadLine();
            int claimTypeInt = int.Parse(claimTypeString);
            newClaim.ClaimType = (ClaimType)claimTypeInt;

            Console.WriteLine("Enter a description of the claim:");
            newClaim.Description = Console.ReadLine();

            Console.WriteLine("Enter the claim dollar amount:");
            newClaim.ClaimAmount = Console.ReadLine();

            Console.WriteLine("Enter the date of the incident:"); //include a specific date format month, day , year etc.
            newClaim.DateOfIncident = Console.ReadLine();

            Console.WriteLine("Enter the date of the claim:");
            newClaim.DateOfClaim = Console.ReadLine();

            Console.WriteLine("Is this claim valid? (Claim is only valid if it is made 30 days or less after the incident took place.)"); //Hit enter to determine if this claim is valid or not.

            /*DateTime incidentDate = new DateTime();
            newClaim.DateOfIncident = incidentDate.ToString("yyyy,MM,dd");
            Console.ReadLine();

            DateTime claimDate = new DateTime();
            newClaim.DateOfClaim = claimDate.ToString("yyyy,MM,dd");
            Console.ReadLine();

            TimeSpan TimeBetweenIncidentAndClaim = claimDate - incidentDate;
            Console.WriteLine(TimeBetweenIncidentAndClaim.TotalDays);
            Console.ReadLine();


            if (TimeBetweenIncidentAndClaim > 30d)
            {
                return false;
                Console.WriteLine("This claim is invalid.")
            }
            else if (timeSpan <= 30days)
            {
                return true;
                Console.WriteLine("The claim is valid.")
            }*/      
            
        }
    }
}
