using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu.Drinks
{
    public class JurrasicJava : Drink
    {

        /// <summary>
        /// Property Defaults ice to false
        /// </summary>
        public override bool Ice { get; set; } = false;

        public bool RoomForCream { get; set; } = false;

        public bool Decaf { get; set; } = false;

        public JurrasicJava()
        {
            Price = 0.99;
            Calories = 8;
            ingredients.Add("Water");
            ingredients.Add("Coffee");
            
        }


       public void LeaveRoomForCream()
        {
            this.RoomForCream = true;
        }


        public void AddIce()
        {
            this.Ice = true;
        }

    } // End of JurrasicJava class
}
