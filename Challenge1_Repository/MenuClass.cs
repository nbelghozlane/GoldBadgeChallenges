using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1_Repository
{
    public class MenuClass
    {
        //POCO
        public int MealNumber { get; set; } //Do an enum?
        public string MealName { get; set; }
        public string MealDescription { get; set; }
        public string Ingredients { get; set; }//make a list?
        public double Price { get; set; }

        public MenuClass(int mealNumber, string mealName, string mealDescription, string ingredients, double price)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            MealDescription = mealDescription;
            Ingredients = ingredients;
            Price = price;
        }
    }
}
