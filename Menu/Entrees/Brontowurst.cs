using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;

namespace DinoDiner.Menu.Entrees
{
    public class Brontowurst
    {
        /// <summary>
        ///  Private fields for use in Hold Methods
        /// </summary>
        private bool bun = true;
        private bool peppers = true;
        private bool onion = true;
        
        public double Price { get; set; }

        public uint Calories { get; set; }

        /// <summary>
        /// This method lists ingredients to the Entree if not hold off
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst"};
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onion) ingredients.Add("Onion");
                return ingredients;
            }
        }

        // Price and Calories
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        // Method to Hold Bun
        public void HoldBun()
        {
            this.bun = false;
        }

        // Method to Hold Peppers
        public void HoldPeppers()
        {
            this.peppers = false;
        }

        // Method to Hold Onion
        public void HoldOnion()
        {
            this.onion = false;
        }


    }
} // End of Brontowurst class
