using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu
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
            ingredients.Add("Macaroni Noodles");
            ingredients.Add("Cheese Product");
            ingredients.Add("Pork Sausage");
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

        /// <summary>
        /// ToString Implementation to refactor all Menu items
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{size} Meteor Mac and Cheese";
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
    } // End of MeteorMacAndCheese class
}
