﻿using Challenge1_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
        public void GetMenuList()
        {
           
        }
    }
}

/*  //Read - List of all menu items
public List<MenuClass> GetMenuList()
{
    return _menuItems;
}*/