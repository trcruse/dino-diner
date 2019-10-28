using System;
using System.Collections.Generic;
using System.Text;



/// <summary>
/// Inherits from base class Drink 
/// </summary>
namespace DinoDiner.Menu
{
    /// <summary>
    /// Inherits from base class Drink
    /// </summary>
    public class Sodasaurus : Drink
    {

        /// <summary>
        /// protected backing variable for flavor
        /// </summary>
        protected SodasaurusFlavor flavor;
        /// <summary>
        /// Inheritance from SodasaurusFlavor enum allowing for correct drink flavor
        /// </summary>
        public SodasaurusFlavor Flavor
        { 
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
                NotifyOfPropertyChanged("Description");
            }
        }


        /// <summary>
        /// constructor for Sodasaurus that implements Price, Calories, and Ingredients at default
        /// </summary>
        public Sodasaurus()
        {
            Price = 1.50;
            Calories = 112;
            ingredients.Add("Water");
            ingredients.Add("Natural Flavors");
            ingredients.Add("Cane Sugar");
        }


        /// <summary>
        /// override method leads into enum Size class to make changes in Price and Calories for called enum Sizes
        /// Notifys property change in Price and Calories per each Size implementation in
        /// each class requirements
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                switch (size)
                {
                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                }
            }
            get
            {
                
                return size;
            }
        }


        /// <summary>
        /// ToString Implementation to refactor all Menu items
        /// </summary>
        public override string ToString()
        {
            return $"{size} {flavor} Sodasaurus";    
        }

        /// <summary>
        /// Gets a description of the order item
        /// Size is integrated
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }


        /// <summary>
        /// contains any special instructions for the food preparation
        /// All drinks require Hold Ice except Jurassic Java
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                //If Ice is false
                if (!Ice) special.Add("Hold Ice");

                return special.ToArray();
            }
        }

    } // End of Sodasaurus class
}
