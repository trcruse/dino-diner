using System;
using System.Collections.Generic;
using System.Text;



namespace DinoDiner.Menu
{
    /// <summary>
    /// Inherits from the Side base class
    /// </summary>
    public class Triceritots : Side
    {

        /// <summary>
        /// constructor for Triceritots to implement Price, Calories, and Ingredients
        /// </summary>
        public Triceritots()
        {
            Price = 0.99;
            Calories = 352;
            ingredients.Add("Potato");
            ingredients.Add("Salt");
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
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 352;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
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
            return $"{size} Triceritots";
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
        /// 
        /// </summary>
        public override string[] Special
        {
            get
            {
                return new string[0];
            }
        }
    }// End of Triceritots class
} 
