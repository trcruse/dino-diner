using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;

namespace DinoDiner.Menu.Entrees
{
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
            this.Price = 4.25 + 0.25;
            
        }


    }
} // End of DinoNuggets class
