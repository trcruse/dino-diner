using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu
{
    /// <summary>
    /// Inherits from the Entree base class
    /// </summary>
    public class VelociWrap : Entree
    {
        /// <summary>
        /// Private fields for use in Hold Methods
        /// Not called outside of class
        /// </summary>
        private bool dressing = true;

        /// <summary>
        /// Private fields for use in Hold Methods
        /// Not called outside of class
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// Private fields for use in Hold Methods
        /// Not called outside of class
        /// </summary>
        private bool cheese = true;

        

        /// <summary>
        /// This method lists ingredients to the Entree if not hold off
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast"};
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        //Sets price and calories
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        public void HoldDressing()
        {
            this.dressing = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        public void HoldLettuce()
        {
            this.lettuce = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        public void HoldCheese()
        {
            this.cheese = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// ToString Implementation to refactor all Menu items
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
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
                List<string> special = new List<string>();

                //if dressing is false
                if (!dressing) special.Add("Hold Ceasar Dressing");

                //if lettuce is false
                if (!lettuce) special.Add("Hold Romaine Lettuce");

                //if cheese is false
                if (!cheese) special.Add("Hold Parmesan Cheese");

                return special.ToArray();
            }
        }
    }
} // End of VelociWrap class
