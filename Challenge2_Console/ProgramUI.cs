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
            SeedClaimList();
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
            Console.Clear();

            List<ClaimClass> listOfClaims = _claimRepo.ViewAllClaims();

            string ClaimsTable = string.Format("{0,-15} {1,-15} {2,-15} {3,-15} {4,-25} {5,-20} {6,-15}\n", 
                "Claim ID", "Claim Type", "Description", "Amount", "Date Of Incident", "Date Of Claim", "Is Valid");
            Console.WriteLine(ClaimsTable);

            foreach (ClaimClass claim in listOfClaims)
            {
                string ClaimsOutput = string.Format("{0,-15} {1,-15} {2,-15} {3,-15} {4,-25} {5,-20} {6,-15}", claim.ClaimID, claim.ClaimType, claim.Description, claim.ClaimAmount,
                    claim.DateOfIncident, claim.DateOfClaim, claim.IsValid);
                Console.WriteLine(ClaimsOutput);
            }

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

            Console.WriteLine("Enter the date of the incident (ex: 12/09/2020; month/day/year):"); 
            DateTime inputIncidentDate = DateTime.Parse(Console.ReadLine());
            newClaim.DateOfIncident = inputIncidentDate;

            Console.WriteLine("Enter the date of the claim (ex: 12/09/2020; month/day/year):");
            DateTime inputClaimDate = DateTime.Parse(Console.ReadLine());
            newClaim.DateOfClaim = inputClaimDate;

            TimeSpan TimeBetweenIncidentAndClaim = new TimeSpan();
            TimeBetweenIncidentAndClaim = newClaim.DateOfClaim - newClaim.DateOfIncident;
            //Console.WriteLine(TimeBetweenIncidentAndClaim.Days);
            //Console.ReadLine();

            if (TimeBetweenIncidentAndClaim.Days > 30)
            {
                Console.WriteLine("This claim is invalid.");
            }
            else if (TimeBetweenIncidentAndClaim.Days <= 30)
            {
                Console.WriteLine("The claim is valid.");
            }

            _claimRepo.CreateNewClaim(newClaim);
            
        }

        private void SeedClaimList()
        {

            DateTime claim1ClaimDate = new DateTime(2020, 12, 10);
            DateTime claim1IncidentDate = new DateTime(2020, 12, 01);

            ClaimClass claim1 = new ClaimClass("1", ClaimType.Car, "Car was rear-ended.", "$1000.00", claim1IncidentDate, claim1ClaimDate, true);

            _claimRepo.CreateNewClaim(claim1);
        } 
    }
}
