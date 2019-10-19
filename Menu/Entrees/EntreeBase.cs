using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Hides background details and implementation, only providing essential information
    /// calls IOrderItem interface, IMenuItem, and INotifyPropertyChanged
    /// </summary>
    public abstract class Entree : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for property change notifications
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// inherited classes have their own access to the variable Price
        /// </summary>
        protected double price;
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;

            }
        }

        /// <summary>
        /// inherited classes have their own access to the variable Calories
        /// </summary>
        protected uint calories;
        public uint Calories
        {
            get
            {
                return calories;
            }
            set
            {
                calories = value;
            }
        }


        /// <summary>
        /// inherited classes have their own access to the variable Ingredients
        /// </summary>
        protected List<string> ingredients;
        public virtual List<string> Ingredients
        {
            get
            {
                return new List<string>(ingredients);
            }
        }

        /// <summary>
        /// Gets description of the order item
        /// </summary>
        public virtual string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// No needed special in Entree Base class, returns empty array string of zero
        /// </summary>
        public virtual string[] Special
        {
            get
            {
                return new string[0];
            }
        }

    } // End of EntreeBase class
}
