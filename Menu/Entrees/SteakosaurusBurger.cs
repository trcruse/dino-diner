using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu
{
    public class SteakosaurusBurger : Entree
    {

        /// <summary>
        ///  Private fields for use in Hold Methods
        /// </summary>
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;

        /// <summary>
        /// This method lists ingredients to the Entree if not hold off
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {"Steakburger Pattie"};
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
      
                return ingredients;
            }
        }

        //Sets price and calories
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        //Implement methods for holding Bun, Pickle, Ketchup, Mustard
        public void HoldBun()
        {
            this.bun = false;
        }

        public void HoldPickle()
        {
            this.pickle = false;
        }

        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        public void HoldMustard()
        {
            this.mustard = false;
        }

        /// <summary>
        /// ToString Implementation to refactor all Menu items
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }


    }
} // End of SteakosaurusBurger class
