using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1_Repository
{
    public class MenuRepositoryClass
    {
        private List<MenuClass> _menuItems = new List<MenuClass>();

        //Create new menu items
        public void CreateMenuItems(MenuClass menuItem)
        {
            _menuItems.Add(menuItem);
        }

        //Read - List of all menu items
        public List<MenuClass> GetMenuList()
        {
            return _menuItems;
        }

        //Delete menu items
        public bool DeleteMenuItems(string mealName)
        {
            MenuClass menuItem = GetMenuItemsByMealName(mealName);

            if (menuItem == null)
            {
                return false;
            }

            int initialCount = _menuItems.Count;
            _menuItems.Remove(menuItem);
            if (initialCount > _menuItems.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Get menu items by meal name
        public MenuClass GetMenuItemsByMealName(string mealName)
        {
            foreach (MenuClass menuItem in _menuItems)
            {
                if (menuItem.MealName.ToLower() == mealName.ToLower())
                {
                    return menuItem;
                }
            }
            return null;
        }
    }
}
