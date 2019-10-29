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
        public abstract class Drink : IMenuItem, IOrderItem, INotifyPropertyChanged
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
            /// A virtual function for property Ice to be inherited and redefined in subclasses 
            /// </summary>
             public virtual bool Ice { get; set; } = true;

            /// <summary>
            /// inherited classes have their own access to the variable Price
            /// - available only to the class that defines it and subclasses of the Drink base class
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
            ///  inherited classes have their own access to the variable Calories
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
            ///  inherited classes have their own access to the variable Ingredients
            /// </summary>
             protected List<string> ingredients = new List<string>();
            /// <summary>
            /// virtual allows multiple implementations in different classes
            /// </summary>
            public virtual List<string> Ingredients
            {
                get
                {
                 return new List<string>(ingredients);
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
        /// Implements method HoldIce setting Ice property to false
        /// Notifys property change in Ingredients and Special per each food implementation in
        /// each class requirements
        /// </summary>
            public void HoldIce()
            {
                this.Ice = false;
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
            }

            /// <summary>
            /// Gets a description of the order item
            /// </summary>
            public virtual string Description
            {
                get
                {
                    return this.ToString();
                }
            }
            
            /// <summary>
            /// Special instructions for food requirements
            /// All Drinks inherit Hold Ice method except for JurrasicJava
            /// </summary>
            public virtual string[] Special
            {
                get
                {
                    List<string> special = new List<string>();
                    //If Ice is false
                    if (!Ice) special.Add("Hold Ice");
                    return special.ToArray();
                }
            }


    } //end of abstract Drink base class
}
