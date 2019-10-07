using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu 
{

    /// <summary>
    /// Inherits from base class Entree
    /// </summary>
    public class Brontowurst : Entree
    {
        /// <summary>
        ///  Private fields for use in Hold Methods
        /// </summary>
        private bool bun = true;
        private bool peppers = true;
        private bool onion = true;
        
        

        /// <summary>
        /// This method lists ingredients to the Entree if not hold off
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {"Brautwurst"};
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onion) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for price and calories
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// method to implement removing bun
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// method to implement holding peppers
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }

        // Method to Hold Onion
        public void HoldOnion()
        {
            this.onion = false;
        }

        /// <summary>
        /// ToString Implementation to refactor all Menu items
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Brontowurst";
        }


    }
} // End of Brontowurst class
