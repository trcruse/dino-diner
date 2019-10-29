using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;


namespace DinoDiner.Menu
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


        private bool sweet;
        /// <summary>
        /// boolean Sweet property set default to false
        /// </summary>
        public bool Sweet
        {
            get
            {
                return sweet;
            }
            set
            {
                sweet = value;
                NotifyOfPropertyChanged("Description");
            }
        }

        

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
        /// Notifys property change in Calories and Price per each Size implementation in
        /// each class requirements
        /// </summary>
        public override Size Size
        {
            set
            {
                uint multiply;
                size = value;
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
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
        /// Notifys property change in Ingredients and Special per each food implementation in
        /// each class requirements
        /// </summary>
        public void AddLemon()
        {
            ingredients.Add("Lemon");
            this.Lemon = true;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
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

        /// <summary>
        /// ToString Implementation to refactor all Menu items
        /// </summary>
        public override string ToString()
        {
            if (Sweet)
            {
                return $"{size} Sweet Tyrannotea";
            }
            else
            {
                return $"{size} Tyrannotea";
            }
        }

        /// <summary>
        /// Gets a description of the order item from ToString method
        /// Sweet and Size are integrated, not in Special
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
                // If Lemon is true
                if (Lemon) special.Add("Add Lemon");

                if (!Ice) special.Add("Hold Ice");
                
                return special.ToArray();
            }
        }


    } // End of Tyrannotea class
}
