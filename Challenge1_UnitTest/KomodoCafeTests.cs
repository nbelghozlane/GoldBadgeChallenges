using Challenge1_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Challenge1_UnitTest
{
    [TestClass]
    public class KomodoCafeTests
    {
        [TestMethod]
        public void CreateMenuItems_ShouldNotGetNull()
        {
            //Arrange
            MenuClass menuItems = new MenuClass();
            menuItems.MealName = "Cheeseburger";
            MenuRepositoryClass menuRepo = new MenuRepositoryClass();

            //Act
            menuRepo.CreateMenuItems(menuItems);
            MenuClass menuItemsFromMenu = menuRepo.GetMenuItemsByMealName("Cheeseburger");
         
            //Assert
            Assert.IsNotNull(menuItemsFromMenu);
        }

        [TestMethod]
        public void DeleteMenuItems_ShouldReturnTrue()
        {
            //Arrange
            MenuClass menuItems = new MenuClass();
            menuItems.MealName = "Burger";
            MenuRepositoryClass menuRepo = new MenuRepositoryClass();

            //Act
            menuRepo.CreateMenuItems(menuItems);
            bool deleteMenuItem = menuRepo.DeleteMenuItems("Burger");

            //Assert
            Assert.IsTrue(deleteMenuItem);
        }

        [TestMethod]
        public void GetMenuList_IsNotNull()
        {
            //Arrange
            MenuRepositoryClass menuRepo = new MenuRepositoryClass();

            //Act
            List<MenuClass> menuItemsList = menuRepo.GetMenuList(); 

            //Assert
            Assert.IsNotNull(menuItemsList);
        }

        [TestMethod]
        public void GetMenuItemsByMealName()
        {
            //Arrange
            MenuRepositoryClass menuRepo = new MenuRepositoryClass();
            MenuClass addedMenuItem = new MenuClass("1", "Burger Meal", "Burger w/ French Fries", "Beef patty, bun & cheese w/ french fries", 3.00);
            menuRepo.CreateMenuItems(addedMenuItem);

            //Act
            MenuClass menuItemByName = menuRepo.GetMenuItemsByMealName(addedMenuItem.MealName);

            //Assert
            Assert.AreEqual(addedMenuItem, menuItemByName);
        }
    }
}

