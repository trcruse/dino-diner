﻿using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu
{
    /// <summary>
    /// Inherits from the Entree base class
    /// </summary>
    public class TRexKingBurger : Entree
    {

        /// <summary>
        ///  Private fields for use in Hold Methods
        /// </summary>
        private bool bun = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;


        /// <summary>
        /// This method lists ingredients to the Entree if not hold off
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");

                return ingredients;
            }
        }

        /// <summary>
        /// Constructor that sets Price and Calories at initial value
        /// </summary>        
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }

        /// <summary>
        /// Holding Bun method implementation
        /// Notifys property change for the ingredients and special functions
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holding Lettuce method implementation
        /// Notifys property change for the ingredients and special functions
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holding Tomato method implementation
        /// Notifys property change for the ingredients and special functions
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holding Onion method implementation
        /// Notifys property change for the ingredients and special functions
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holding Pickle method implementation
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
        /// Holding Mayo method implementation
        /// Notifys property change for the ingredients and special functions
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// ToString Implementation to refactor all Menu items
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
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
        /// Specials food instructions for class requirements
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();

                //if bun is false
                if (!bun) special.Add("Hold Bun");
                //if lettuce is false
                if (!lettuce) special.Add("Hold Lettuce");
                //if tomato is false
                if (!tomato) special.Add("Hold Tomato"); 
                //if onion is false
                if (!onion) special.Add("Hold Onion");
                //if pickle is false
                if (!pickle) special.Add("Hold Pickle");
                //if ketchup is false
                if (!ketchup) special.Add("Hold Ketchup");
                //if mustard is false
                if (!mustard) special.Add("Hold Mustard");
                //if mayo is false
                if (!mayo) special.Add("Hold Mayo");

                return special.ToArray();
            }
        }

    }// End of TRexKingBurger class
} 