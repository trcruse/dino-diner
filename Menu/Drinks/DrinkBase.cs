using System;
using System.Collections.Generic;
using System.Text;
using Menu;

namespace DinoDiner.Menu.Drinks
{
   
        public abstract class Drink
        {

        /// <summary>
        /// Property for ice 
        /// </summary>
        public virtual bool Ice { get; set; } = true;

            /// <summary>
            /// inherited classes have their own access to the variable Price
            /// </summary>
            protected double price;
            public double Price
            {
                get
                {
                    return price;
                }
                set
                {
                    price = value;
                }
            }


            /// <summary>
            ///  inherited classes have their own access to the variable Calories
            /// </summary>
            protected uint calories;
            public uint Calories
            {
                get
                {
                    return calories;
                }
                set
                {
                    calories = value;
                }
            }



        /// <summary>
        ///  inherited classes have their own access to the variable Ingredients
        /// </summary>

            protected List<string> ingredients = new List<string>();
            public virtual List<string> Ingredients
            {
                get
                {
                    return ingredients;
                }
   
            }

            /// <summary>
            ///  inherited classes have their own access to the variable Size
            /// </summary>
            protected Size size;
            /// <summary>
            /// virtual allows multiple implementations in different classes
            /// </summary>
            public virtual Size Size
            {
                get
                {
                    return size;
                }
                set
                {
                    size = value;
                }
            }


        /// <summary>
        /// Implements method HoldIce setting Ice property to false
        /// </summary>
        public void HoldIce()
        {
            this.Ice = false;
        }


        } //end of public abstract Drink

}
