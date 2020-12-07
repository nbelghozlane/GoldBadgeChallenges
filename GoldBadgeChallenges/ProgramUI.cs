﻿using Challenge1_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadgeChallenges
{
    class ProgramUI
    {
        private MenuRepository _menuRepo = new MenuRepository();
        //private MenuRepositoryClass _menuRepo = new MenuRepositoryClass
        public void Run()
        {
            SeedMenuList();
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Welcome to Komodo Cafe Menu Application!\n" +
                    "Please select an option below (enter in number):\n" +
                    " \n" +
                    "1. Create New Menu Item\n" +
                    "2. View List Of All Menu Items\n" +
                    "3. Delete Menu Item\n" +
                    "4. Exit\n" +
                    " ");

                string UserInput = Console.ReadLine();

                switch (UserInput)
                {
                    case "1":
                        CreateNewMenuItem();
                        break;
                    case "2":
                        ViewAllMenuItems();
                        break;
                        //ViewMenuItemByMealNumber?
                    case "3":
                        DeleteMenuItem();
                        break;
                    case "4":
                        Console.WriteLine("Thank you for using Komodo Cafe Menu Application! Goodbye!");
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

        private void CreateNewMenuItem()
        {
            MenuClass newMenuItem = new MenuClass();

            //MealNumber
            Console.WriteLine("Enter the meal number you'd like to assign to the menu item:");
            newMenuItem.MealNumber = Console.ReadLine();

            //MealName
            Console.WriteLine("Enter the meal name:");
            newMenuItem.MealName = Console.ReadLine();

            //MealDescription
            Console.WriteLine("Enter a description of the meal:");
            newMenuItem.MealDescription = Console.ReadLine();

            //Ingredients
            Console.WriteLine("Enter the ingredients in the meal (seperate each ingredient with a comma):");
            newMenuItem.Ingredients = Console.ReadLine();

            //Price
            Console.WriteLine("Enter the price of the meal (enter in decimal format, example: 1.99):");
            string priceAsString = Console.ReadLine();
            newMenuItem.Price = double.Parse(priceAsString);

            _menuRepo.CreateMenuItems(newMenuItem);
        }

        private void ViewAllMenuItems()
        {

        }

        private void DeleteMenuItem()
        {

        }

        private void SeedMenuList()
        {

        }

    }
}
