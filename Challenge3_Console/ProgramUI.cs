using Challenge3_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3_Console
{
    class ProgramUI
    {
        private BadgeRepository _badgeRepository = new BadgeRepository();

        public void Run()
        {
            SeedBadgeList();
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Hello! Welcome to Komodo Insurance Badges Application!\n" +
                    "What would you like to do?\n" +
                    " \n" +
                    "1. Create A Badge\n" +
                    "2. Edit A Badge\n" +
                    "3. View All Badges\n" +
                    "4. Exit\n" +
                    " ");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        CreateNewBadge();
                        break;
                    case "2":
                        EditBadge();
                        break;
                    case "3":
                        ViewAllBadges();
                        break;
                    case "4":
                        Console.WriteLine("Goodbye!");
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

        private void CreateNewBadge()
        {
            Console.Clear();
            BadgeClass newBadge = new BadgeClass();
            List<string> listOfDoors = new List<string>();

            Console.WriteLine("What is the Badge ID Number?");
            newBadge.BadgeID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a door that it needs access to:");
            listOfDoors.Add(Console.ReadLine());
            newBadge.DoorNames = listOfDoors;

            Console.WriteLine("Any other doors you want to add? (y/n)");


            _badgeRepository.CreateNewBadge(newBadge);
        }

        private void EditBadge()
        {

        }

        private void ViewAllBadges()
        {
            Console.Clear();
            Dictionary<int, List<string>> listOfBadges = _badgeRepository.ViewAllBadgesAndDoorAccess();

            foreach (var dictionary in listOfBadges)
            {
                List<string> List = new List<string>();
                Console.WriteLine($"Badge ID #: {dictionary.Key}\n" +
                    $"Door Access: {dictionary.Value[0]}");
            }
        }

        private void SeedBadgeList()
        {

        }
    }
}
