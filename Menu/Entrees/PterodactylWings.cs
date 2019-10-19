using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu
{
    /// <summary>
    /// Inherits from the Entree base class
    /// </summary>
    public class PterodactylWings : Entree
    {

        /// <summary>
        /// This method lists ingredients to the Entree if not hold off
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {"Chicken", "Wing Sauce"};
              
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor to set Price and Calories at initial value
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

        /// <summary>
        /// ToString Implementation to refactor all Menu items
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }

        /// <summary>
        /// Gets description of the order item from the ToString method
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
        /// Entrees return an empty string when there's no specifications
        /// </summary>
        public override string[] Special
        {
            get
            {
                return new string[0];
            }
        }

    }// End of PterodactylWings class
} 
