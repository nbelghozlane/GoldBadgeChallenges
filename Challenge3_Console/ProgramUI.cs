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

            Console.WriteLine("What is the Badge ID Number?");
            newBadge.BadgeID = int.Parse(Console.ReadLine());

            bool runDoorAccess = true;
            while (runDoorAccess)
            {
                Console.WriteLine("Enter a door that it needs access to:");
                string door = Console.ReadLine();
                newBadge.DoorNames.Add(door);

                Console.WriteLine("Any other doors you want to add? (y/n)");
                string userInput = Console.ReadLine().ToLower();

                switch (userInput)
                {
                    case "y":
                        runDoorAccess = true;
                        break;
                    case "n":
                        runDoorAccess = false;
                        Console.Clear();
                        _badgeRepository.CreateNewBadge(newBadge);
                        Menu();
                        break;
                }
            }
        }

        private void EditBadge()
        {
            Console.Clear();
            //ViewAllBadges();
            
            Console.WriteLine("What is the ID number of the badge you'd like to update?");
            string idString = Console.ReadLine();
            int idInt = int.Parse(idString);

            Console.WriteLine("What would you like to do?\n" +
                "1. Remove A Door\n" +
                "2. Add A Door");
            string input = Console.ReadLine();
            
            switch (input)
            {
                case "1":
                    List<string> RemoveDoors = new List<string>();   
                    Dictionary<int, List<string>> newDictionary = new Dictionary<int, List<string>>();
                    newDictionary = _badgeRepository.ViewAllBadgesAndDoorAccess();
                    
                    foreach( KeyValuePair<int, List<string>> dictionary in newDictionary)
                    {
                        if (dictionary.Key == idInt)
                        {
                            RemoveDoors = dictionary.Value;
                        }
                    }
                    RemoveDoor(idInt, RemoveDoors);
                    break;

                case "2":
                    List<string> AddDoors = new List<string>();  
                    Dictionary<int, List<string>> newDictionary2 = new Dictionary<int, List<string>>();
                    newDictionary = _badgeRepository.ViewAllBadgesAndDoorAccess();

                    foreach (KeyValuePair<int, List<string>> dictionary in newDictionary)
                    {
                        if (dictionary.Key == idInt)
                        {
                            AddDoors = dictionary.Value;
                        }
                    }
                    AddDoor(idInt, AddDoors);
                    break;
            }      
        }

        private void AddDoor(int badge, List<string> doors)
        {
            Console.WriteLine("Enter a door you want to add:");
            string input = Console.ReadLine();
            doors.Add(input);
            _badgeRepository.UpdateBadge(badge, doors);
        }

        private void RemoveDoor(int badge, List<string> doors)
        {
            Console.WriteLine("Enter a door you want to remove:");
            string input = Console.ReadLine();
            doors.Remove(input);
            _badgeRepository.UpdateBadge(badge, doors);
        }

        private void ViewAllBadges()
        {
            Console.Clear();
            Dictionary<int, List<string>> listOfBadges = _badgeRepository.ViewAllBadgesAndDoorAccess();
           
            //Console.WriteLine("Badge ID     Door Access" );
            
            foreach (KeyValuePair<int, List<string>> dictionary in listOfBadges)
            {
                //List<string> List = new List<string>();

                Console.WriteLine($"Badge ID #: {dictionary.Key}");     //fix formatting

                foreach (string door in dictionary.Value)
                {
                    Console.WriteLine($"Door Access: {door}");
                    
                }
            }
        }

        private void SeedBadgeList()
        {
            BadgeClass badge1 = new BadgeClass(1234, new List<string>() {"A1", "A2"});
            BadgeClass badge2 = new BadgeClass(3456, new List<string>() {"A1", "A3", "C4"});
            BadgeClass badge3 = new BadgeClass(4567, new List<string>() {"B1"});

            _badgeRepository.CreateNewBadge(badge1);
            _badgeRepository.CreateNewBadge(badge2);
            _badgeRepository.CreateNewBadge(badge3);  

        }
    }
}

