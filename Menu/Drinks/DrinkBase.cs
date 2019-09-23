﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Drinks
{
   
        public enum Size
        {
            Small,
            Medium,
            Large
        }

        public abstract class Drink
        {

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
            protected List<string> ingredients;
            public virtual List<string> Ingredients
            {
                get;
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


        } //end of public abstract

}
