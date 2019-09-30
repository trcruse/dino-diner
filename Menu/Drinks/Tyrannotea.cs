using System;
using System.Collections.Generic;
using System.Text;
using Menu;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Inherits from the Drink base class
    /// </summary>
    public class Tyrannotea : Drink
    {

        /// <summary>
        /// boolean Lemon property set default to false
        /// </summary>
        public bool Lemon { get; set; } = false;


        /// <summary>
        /// boolean Sweet property set default to false
        /// </summary>
        public bool Sweet { get; set; } = false;


        /// <summary>
        /// constructor for Tyrannotea that implements Price, Calories, and Ingredients by default
        /// </summary>
        public Tyrannotea()
        {
            Price = 0.99;
            Calories = 8;
            ingredients.Add("Water");
            ingredients.Add("Tea");
        }


        /// <summary>
        /// override method leads into enum abstract to make changes in Price and Calories for called enum Sizes
        /// </summary>
        public override Size Size
        {
            set
            {
                //uint variable to adjust calorie intake for each drink size with sweetner
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
        /// Sets lemon to true when Lemon is added, as well as adds ingredient "Lemon" to the list
        /// </summary>
        public void AddLemon()
        {
            ingredients.Add("Lemon");
            this.Lemon = true;
        }

        /// <summary>
        /// Sets Sweet to true when Sweetner is added, as well as adds ingredient "Cane Sugar" to the list
        /// </summary>
        public void AddSweet()
        {
            ingredients.Add("Cane Sugar");
            this.Sweet = true;
        }

        /// <summary>
        /// Implements Sweet to remove sweet from calorie list
        /// </summary>
        public void RemoveSweet()
        {
            this.Sweet = false;
        }

    } // End of Tyrannotea class
}
