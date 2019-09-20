using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;

namespace DinoDiner.Menu.Entrees
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

       

    }
} // End of PterodactylWings class
