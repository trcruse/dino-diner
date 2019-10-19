using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu
{
    /// <summary>
    /// Inherits from the Entree base class
    /// </summary>
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

       /// <summary>
       /// Constructor that sets Price and Calories to intial value
       /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        /// <summary>
        /// Holding bun method
        /// Notifys property change in Ingredients and Special per each food implementation in
        /// each class requirements
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holding pickle method implementation
        /// Notifys property change for the ingredients and special functions
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holding Ketchup method implementation
        /// Notifys property change for the ingredients and special functions
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holding Mustard method implementation
        /// Notifys property change for the ingredients and special functions
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// ToString Implementation to refactor all Menu items
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }

        /// <summary>
        /// Gets a description of the order item
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Specials implements food instructions per class requirements
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();

                //if bun is false
                if (!bun) special.Add("Hold Bun");
                //if pickle is false
                if (!pickle) special.Add("Hold Pickle");
                //if ketchup is false
                if (!ketchup) special.Add("Hold Ketchup");
                //if mustard is false
                if (!mustard) special.Add("Hold Mustard");

                return special.ToArray();
            }
        }

    } // End of SteakosaurusBurger class
}