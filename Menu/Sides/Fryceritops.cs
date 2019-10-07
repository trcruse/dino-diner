using System;
using System.Collections.Generic;
using System.Text;



namespace DinoDiner.Menu
{
    /// <summary>
    /// Inherits from the Side base class
    /// </summary>
    public class Fryceritops : Side
    {
        /// <summary>
        /// constructor for each class that implements Price, Calories, and Ingredients
        /// </summary>
        public Fryceritops()
        {
            Price = 0.99;
            Calories = 222;
            ingredients.Add("Potato");
            ingredients.Add("Salt");
            ingredients.Add("Vegetable Oil");
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
                        Price = 0.99;
                        Calories = 222;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
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
        /// <returns></returns>
        public override string ToString()
        {
            return $"{size} Fryceritops";
        }

    } //End of Fryceritops class
} 
