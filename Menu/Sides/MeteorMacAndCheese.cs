using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    public class MeteorMacAndCheese : Side
    {

        /// <summary>
        /// constructor for MeteorMacAndCheese to implement Price, Calories, and Ingredients
        /// </summary>
        public MeteorMacAndCheese()
        {
            Price = 0.99;
            Calories = 420;
            Ingredients.Add("Macaroni Noodles");
            Ingredients.Add("Cheese Product");
            Ingredients.Add("Pork Sausage");
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
                        Calories = 420;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
                        break;
                }
            }
            get
            {
                return size;
            }
        }

    } // End of MeteorMacAndCheese class
}
