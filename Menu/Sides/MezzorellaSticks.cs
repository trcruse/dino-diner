using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu
{
    /// <summary>
    /// Inherits from the Side base class
    /// </summary>
    public class MezzorellaSticks : Side 
    {

        /// <summary>
        /// constructor for MezzorellaSicks to implement Price, Calories, and Ingredients
        /// </summary>
        public MezzorellaSticks()
        {
            Price = 0.99;
            Calories = 540;
            ingredients.Add("Cheese Product");
            ingredients.Add("Breading");
            ingredients.Add("Vegetable Oil");
        }

        /// <summary>
        ///  override method leads into abstract to make changes in Price and Calories for called enum Sizes
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
                        Calories = 540;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 720;
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
            return $"{size} Mezzorella Sticks";
        }

    } // End of MezzorellaSticks class
}
