using System;
using System.Collections.Generic;
using System.Text;
using Menu;

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

            
        }


        /// <summary>
        /// override method leads into abstract to make changes in Price and Calories for called enum Sizes
        /// </summary>
        public override Size Size
        {
            set
            {
                uint multiply;
                size = value;
                if (Sweet == true)
                {
                    multiply = 2;
                  
                }
                else
                {
                    multiply = 1;
                }
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 8*multiply;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16 * multiply;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32 * multiply;
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
            ingredients.Add("Lemon");
            this.Lemon = true;
        }

        public void AddSweet()
        {
            ingredients.Add("Sweet");
            this.Sweet = true;
        }

        public void RemoveSweet()
        {
            this.Sweet = false;
        }

    } // End of Tyrannotea class
}
