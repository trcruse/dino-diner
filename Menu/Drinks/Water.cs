using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water : Drink
    {
        /// <summary>
        /// Property for bool lemon to default as false
        /// </summary>
        public bool Lemon { get; set; } = false;


        /// <summary>
        /// constructor for each class that implements Price, Calories, and Ingredients
        /// </summary>
        public Water()
        {
            Price = 0.10;
            Calories = 0;
            Ingredients.Add("Water"); 

            // If lemon was added???????????????
            Ingredients.Add("Lemon");
        }

        public void AddLemon()
        {
            this.Lemon = true;
        }




    } // End of Water class
} 
