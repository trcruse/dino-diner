using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Inherits from the Entree base class
    /// </summary>
    public class DinoNuggets : Entree
    {
        /// <summary>
        ///  Private field for use in Add Method
        /// </summary>
        private uint chickenNug = 6;

        /// <summary>
        /// This method lists ingredients to the Entree and increments # of Nuggets
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {};
                //if (chickenNug) 
                for (int i = 0; i < chickenNug; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        // Sets price and calories for each nugget
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59*chickenNug;
        }

        //Implement method for adding a nugget at additional 0.25
        public void AddNugget()
        {
            chickenNug = chickenNug + 1;
            this.Price += 0.25;
            this.Calories += 59;
            
        }

        /// <summary>
        /// ToString Implementation to refactor all Menu items
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }


    }
} // End of DinoNuggets class
