using Challenge1_Repository;
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

        /*[TestMethod]
        public void DeleteMenuItems_ShouldReturnTrue(string mealName)
        {
            //Arrange
            MenuClass menuItems = new MenuClass();
            menuItems.MealName = "Cheeseburger";
            MenuRepositoryClass menuRepo = new MenuRepositoryClass();

            //Act
            bool deleteMenuItem = menuRepo.DeleteMenuItems("Cheeseburger");

            //Assert
            Assert.IsTrue(deleteMenuItem);

        }*/
    }
}
