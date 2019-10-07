﻿using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu
{
    /// <summary>
    /// Inherits from the Entree base class
    /// </summary>
    public class VelociWrap : Entree
    {
        /// <summary>
        /// Private fields for use in Hold Methods
        /// Not called outside of class
        /// </summary>
        private bool dressing = true;

        /// <summary>
        /// Private fields for use in Hold Methods
        /// Not called outside of class
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// Private fields for use in Hold Methods
        /// Not called outside of class
        /// </summary>
        private bool cheese = true;

        

        /// <summary>
        /// This method lists ingredients to the Entree if not hold off
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast"};
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        //Sets price and calories
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        public void HoldDressing()
        {
            this.dressing = false;
        }

        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        public void HoldCheese()
        {
            this.cheese = false;
        }

        /// <summary>
        /// ToString Implementation to refactor all Menu items
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }


    }
} // End of VelociWrap class
