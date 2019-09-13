using System.Collections.Generic;
using DinoDiner.Menu.Entrees;

namespace DinoDiner.Menu.Entrees
{
    public class PrehistoricPBJ
    {
        private bool peanutButter = true;
        private bool jelly = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        // Method to list ingredients
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        // Sets prices and calories
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        //Method to hold peanut butter
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }

        //Method to hold jelly
        public void HoldJelly()
        {
            this.jelly = false;
        }
    }
} // end of PrehistoricPBJ class
