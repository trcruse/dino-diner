using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// A base class representing entrees
    /// </summary>
    public abstract class Entree
    {
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


        protected uint calories;
        public uint Calories
        {
            get
            {
                return calories;
            }
            set
            {

            }

        }



        protected List<string> ingredients;
        public abstract List<string> Ingredients
        {
            get;
        }
    }
}
