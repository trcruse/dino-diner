using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu
{

    /// <summary>
    /// abstract method is intended to be a base class for Sides
    /// </summary>
    public abstract class Side : IMenuItem
    {
        /// <summary>
        /// inherited classes have their own access to the variable Price
        /// </summary>
        protected double price;
        public double Price { get; set;}

        /// <summary>
        ///  inherited classes have their own access to the variable Calories
        /// </summary>
        private uint calories;
        public uint Calories { get;set; }

        /// <summary>
        ///  inherited classes have their own access to the variable Ingredients
        /// </summary>
        protected List<string> ingredients = new List<string>();
        public virtual List<string> Ingredients
        {
            get
            {
                return new List<string> (ingredients);
            }
        }

        /// <summary>
        ///  inherited classes have their own access to the variable Size
        /// </summary>
        protected Size size;
        /// <summary>
        /// virtual allows multiple implementations in different classes
        /// </summary>
        public virtual Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        
    } // End of SideBase class
}
