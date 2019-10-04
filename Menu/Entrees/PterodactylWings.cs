using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu
{
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

        //Sets price and calories
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

    }
} // End of PterodactylWings class
