using System;
using System.Collections.Generic;
using System.Text;


namespace Menu.Drinks 
{
    public class JurrasicJava : Drink
    {

        /// <summary>
        /// Property Defaults ice to false
        /// </summary>
        private bool ice = false;

        private bool roomForCream = false;

        private bool decaf = false;

        public JurrasicJava()
        {
            //Price = 0.99;
            //Calories = 8;
            Ingredients.Add("Water");
            Ingredients.Add("Coffee");
        }


       public void LeaveRoomForCream()
        {
            this.roomForCream = false;
        }


        public void AddIce()
        {
            this.ice = true;
        }

    } // End of JurrasicJava class
}
