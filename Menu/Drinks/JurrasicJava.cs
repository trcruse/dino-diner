using System;
using System.Collections.Generic;
using System.Text;



namespace DinoDiner.Menu
{

    /// <summary>
    /// Inherits from base class Drink 
    /// </summary>
    public class JurrasicJava : Drink
    {

        /// <summary>
        /// Property overrides Ice implementation in base Drink class, and defaults ice to false
        /// </summary>
        public override bool Ice { get; set; } = false;

        /// <summary>
        /// boolean property to implement within LeaveRoomForCream method
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// boolean property to implement
        /// </summary>
        public bool Decaf { get; set; } = false;


        /// <summary>
        /// Constructor that defaults the Price, Calories, and Ingredients for JurrasicJava
        /// </summary>
        public JurrasicJava()
        {
            Price = 0.99;
            Calories = 8;
            ingredients.Add("Water");
            ingredients.Add("Coffee");
        }

        /// <summary>
        /// Implementing method for RoomForCream set to true
        /// </summary>
       public void LeaveRoomForCream()
       {
           this.RoomForCream = true;
       }

        /// <summary>
        /// Implementing method for Ice set to true
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
        }


        /// <summary>
        /// ToString Implementation to refactor all Menu items
        /// </summary>
        public override string ToString()
        {
            if (Decaf)
            {
                return $"{size} Decaf Jurrasic Java";
            }
            else
            {
                return $"{size} Jurrasic Java";
            }
            //size.ToString() + "Decaf"
        }

    } // End of JurrasicJava class
}
