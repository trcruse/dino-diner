using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    public enum Size
    {
        Small,
        Medium,
        Large
    } 

    public abstract class Side
    {
        /// <summary>
        /// inherited classes have their own access to the variable
        /// </summary>
        protected double price;
        public double Price {
           get
           {
                return price;
           }
            set
            {
                price = value;

            }
                
        }


        protected uint calories;
        public uint Calories {
            get
            {
                return calories;
            }
            set
            {

            }

        }


        protected  List<string> ingredients;
        public virtual List<string> Ingredients
        {
            get;
        }


        protected Size size;
        /// <summary>
        /// multiple implementations in different classes
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

        
    }
}
