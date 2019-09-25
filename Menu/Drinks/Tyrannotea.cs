using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {

        /// <summary>
        /// Lemon property
        /// </summary>
        public bool Lemon { get; set; } = false;


        /// <summary>
        /// Sweet property
        /// </summary>
        public bool Sweet { get; set; } = false;


        /// <summary>
        /// constructor for each class that implements Price, Calories, and Ingredients
        /// </summary>
        public Tyrannotea()
        {
            Price = 0.99;
            Calories = 8;
            ingredients.Add("Water");
            ingredients.Add("Tea");

            // If lemon was added???????????????
            ingredients.Add("Lemon");

            // If sweet ????????????
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
                        Price = 0.99;
                        Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Sets lemon to true
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
        }

        public void AddSweet()
        {
            this.Sweet = true;
        }

    } // End of Tyrannotea class
}
