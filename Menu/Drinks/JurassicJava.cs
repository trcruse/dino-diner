using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;



namespace DinoDiner.Menu
{

    /// <summary>
    /// Inherits from base class Drink 
    /// </summary>
    public class JurassicJava : Drink
    {

        /// <summary>
        /// Property overrides Ice implementation in base Drink class, and defaults ice to false
        /// </summary>
        public override bool Ice { get; set; } = false;

        /// <summary>
        /// boolean property to implement within LeaveRoomForCream method
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        private bool decaf;
        /// <summary>
        /// boolean property to implement
        /// </summary>
        public bool Decaf
        {
            get
            {
                return decaf;
            }
            set
            {
                decaf = value;
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Constructor that defaults the Price, Calories, and Ingredients for JurrasicJava
        /// </summary>
        public JurassicJava()
        {
            Price = 0.99;
            Calories = 8;
            ingredients.Add("Water");
            ingredients.Add("Coffee");
        }

        /// <summary>
        /// override method leads into enum Size class to make changes in Price and Calories for called enum Sizes
        /// Notifys property change in Price and Calories per each food implementation in
        /// each class requirements
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                switch (size)
                {
                    case Size.Small:
                        Price = 0.59;
                        Calories = 2;
                        break;
                    case Size.Medium:
                        Price = 0.99;
                        Calories = 4;
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        break;
                }
            }
            get
            {
               
                return size;
            }
        }


        /// <summary>
        /// Implementing method for RoomForCream set to true
        /// Notifys property change in Ingredients and Special per each food implementation in
        /// each class requirements
        /// </summary>
        public void LeaveRoomForCream()
       {
            this.RoomForCream = true;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Implementing method for Ice set to true
        /// Notifys property change in Ingredients and Special per each food implementation in
        /// each class requirements
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }


        /// <summary>
        /// ToString Implementation to refactor all Menu items
        /// </summary>
        public override string ToString()
        {
            if (Decaf)
            {
                return $"{size} Decaf Jurassic Java";
            }
            else
            {
                return $"{size} Jurassic Java";
            }
            //size.ToString() + "Decaf"
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
        /// contains any special instructions for the food preparation
        /// Jurassic Java requires Add Ice implementation
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                
                if (Ice) special.Add("Add Ice");
                //if RoomForCream is true
                if (RoomForCream) special.Add("Leave Room For Cream");
                return special.ToArray();
            }
        }

    } // End of JurrasicJava class
}
