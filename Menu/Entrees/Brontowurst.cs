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
        /// method to implement holding peppers
        /// Notifys property change in Ingredients and Special per each food implementation in
        /// each class requirements
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Method for Holding Onion
        /// Notifys property change in Ingredients and Special per each food implementation in
        /// each class requirements
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// ToString Implementation to refactor all Menu items
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Brontowurst";
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
        /// Integrates strings for food specifications in each class
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                //If onion, peppers, and bun are false
                if (!bun) special.Add("Hold Bun");
                if (!peppers) special.Add("Hold Peppers");
                if (!onion) special.Add("Hold Onion");
                
                return special.ToArray();
            }
        }


    }// End of Brontowurst class
} 