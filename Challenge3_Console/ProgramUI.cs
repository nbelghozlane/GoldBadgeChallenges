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
        private BadgeRepository badgeRepository = new BadgeRepository();

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
            //BadgeClass newBadge = new BadgeClass();
        }

        private void EditBadge()
        {

        }

        private void ViewAllBadges()
        {

        }

        private void SeedBadgeList()
        {

        }
    }
}
