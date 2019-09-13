using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap
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
        /// Made available throughout entire class
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Made available throughout entire class
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// This method lists ingredients to the Entree if not hold off
        /// </summary>
        public List<string> Ingredients
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


    }
} // End of VelociWrap class
