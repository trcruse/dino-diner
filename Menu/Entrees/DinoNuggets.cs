using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Inherits from the Entree base class
    /// </summary>
    public class DinoNuggets : Entree
    {
        /// <summary>
        ///  Private field for use in Add Method
        /// </summary>
        private uint chickenNug = 6;

        /// <summary>
        /// This method lists ingredients to the Entree and increments # of Nuggets
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {};
                for (int i = 0; i < chickenNug; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor that initializes each property per nugget value
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59*chickenNug;
        }

        /// <summary>
        /// Implement method for adding a nugget at additional 0.25
        /// Notifys property change in Ingredients and Special per each food implementation in
        /// each class requirements
        /// </summary>
        public void AddNugget()
        {
            chickenNug = chickenNug + 1;
            this.Price += 0.25;
            this.Calories += 59;

            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// ToString Implementation to refactor all Menu items
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }

        /// <summary>
        /// Gets a description of the order item
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Dino-Nuggets, use a single string “# Extra Nuggets” where # is the number of 
        /// nuggets above 6 for the special case of extra nuggets.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
               
                if (chickenNug > 6)
                {
                    special.Add($"{chickenNug - 6} Extra Nuggets");
                }
                return special.ToArray();
            }
        }


    }// End of DinoNuggets class
} 
