using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Drinks
{
    public class Water : Drink
    {
        /// <summary>
        /// Property for bool lemon to default as false
        /// </summary>
        private bool lemon = false;


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
            this.lemon = true;
        }




    } // End of Water class
} 
