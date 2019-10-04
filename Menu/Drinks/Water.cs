using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu
{
    /// <summary>
    /// Inherits from the Drink base class
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// Boolean Lemon property to default as false
        /// </summary>
        public bool Lemon { get; set; } = false;


        /// <summary>
        /// constructor for Water that implements Price, Calories, and Ingredients to default value
        /// </summary>
        public Water()
        {
            Price = 0.10;
            Calories = 0;
            ingredients.Add("Water"); 
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
                        Price = 0.10;
                        Calories = 0;
                        break;
                    case Size.Medium:
                        Price = 0.10;
                        Calories = 0;
                        break;
                    case Size.Large:
                        Price = 0.10;
                        Calories = 0;
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Property to Add Lemon when true, and adds "Lemon" to ingriedent list
        /// </summary>
        public void AddLemon()
        {
            ingredients.Add("Lemon");
            this.Lemon = true;
        }

        /// <summary>
        /// ToString Implementation to refactor all Menu items
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{size} Water";
        }

    } // End of Water class
} 
