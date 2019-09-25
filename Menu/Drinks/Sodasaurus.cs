using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;



namespace DinoDiner.Menu.Drinks
{
    
    /// <summary>
    /// enum assigns names to integral constants, making easy to read names
    /// </summary>
    
    public class Sodasaurus : Drink
    {

        ///NEEDS SODASAURUS FLAVOR camel case
        protected SodasaurusFlavor flavor;

        //public bool Ice { get; set; } = true;


       
        public SodasaurusFlavor Flavor
        { 
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
            }
        }


        /// <summary>
        /// constructor for each class that implements Price, Calories, and Ingredients
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
        /// override method leads into abstract to make changes in Price and Calories for called enum Sizes
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
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

    } // End of Sodasaurus class
}
