using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Inherits from the Entree base class
    /// </summary>
    public class PrehistoricPBJ : Entree
    {
        /// <summary>
        ///  Private fields for use in Hold Methods
        /// </summary>
        private bool peanutButter = true;

        /// <summary>
        /// private field for use in Hold methods
        /// </summary>
        private bool jelly = true;

        

        /// <summary>
        /// This method lists ingredients to the Entree if not hold off
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        // Sets prices and calories
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        //Method to hold peanut butter
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        //Method to hold jelly
        public void HoldJelly()
        {
            this.jelly = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// ToString Implementation to refactor all Menu items
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
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

        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                //If peanut butter is false
                if (!peanutButter) special.Add("Hold Peanut Butter");
                //If jelly is false
                if (!jelly) special.Add("Hold Jelly");
                return special.ToArray();
            }
        }


    }
} // end of PrehistoricPBJ class
