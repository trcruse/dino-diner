using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;


namespace DinoDiner.Menu
{

    /// <summary>
    /// abstract method is intended to be a base class for Sides
    /// </summary>
    public abstract class Side : IMenuItem, IOrderItem, INotifyPropertyChanged
    {


        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        /// <summary>
        /// inherited classes have their own access to the variable Price
        /// </summary>
        protected double price;
        public double Price { get; set;}

        /// <summary>
        ///  inherited classes have their own access to the variable Calories
        /// </summary>
        private uint calories;
        public uint Calories { get;set; }

        /// <summary>
        ///  inherited classes have their own access to the variable Ingredients
        /// </summary>
        protected List<string> ingredients = new List<string>();
        public virtual List<string> Ingredients
        {
            get
            {
                return new List<string> (ingredients);
            }
        }

        /// <summary>
        ///  inherited classes have their own access to the variable Size
        /// </summary>
        protected Size size;
        /// <summary>
        /// virtual allows multiple implementations in different classes
        /// </summary>
        public virtual Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }


        /// <summary>
        /// Gets a description of the order item
        /// Sweet and Decaf, and Size are integrated
        /// </summary>
        public virtual string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual string[] Special
        {
            get
            {
               
                return new string[0];
            }
        }

    } // End of SideBase class
}
