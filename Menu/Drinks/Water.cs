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
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
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
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// ToString Implementation to refactor all Menu items
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{size} Water";
        }

        /// <summary>
        /// Gets a description of the order item
        /// Sweet and Decaf, and Size are integrated
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Specials for Drinks should use “Hold Ice”,Water have “Add Lemon” as an option.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();

                //if Lemon is true
                if (Lemon) special.Add("Add Lemon");

                //If Ice is false
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }

    } // End of Water class
} 
