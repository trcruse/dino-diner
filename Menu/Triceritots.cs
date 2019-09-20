using System;
using System.Collections.Generic;
using System.Text;


namespace Menu
{
    public class Triceritots : Side
    {
        
        public Triceritots()
        {
            Price = 0.99;
            Calories = 352;
            Ingredients.Add("Potato");
            Ingredients.Add("Salt");
            Ingredients.Add("Vegetable Oil");
        }

        public override Size Size
        {
            set
            {
                size = value;
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
    }
} // End of Triceritots class
