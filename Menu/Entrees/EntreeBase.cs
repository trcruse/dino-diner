using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A base class representing entrees
    /// </summary>
    public abstract class Entree : IMenuItem
    {

        /// <summary>
        /// inherited classes have their own access to the variable Price
        /// </summary>
        protected double price;
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;

            }
        }

        /// <summary>
        /// inherited classes have their own access to the variable Calories
        /// </summary>
        protected uint calories;
        public uint Calories
        {
            get
            {
                return calories;
            }
            set
            {
                calories = value;
            }
        }


        /// <summary>
        /// inherited classes have their own access to the variable Ingredients
        /// </summary>
        protected List<string> ingredients;
        public abstract List<string> Ingredients
        {
            get;
        }
    } // End of EntreeBase class
}
