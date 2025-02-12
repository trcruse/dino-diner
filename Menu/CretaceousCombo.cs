﻿using System.Collections.Generic;
using DinoDiner.Menu;
using System.ComponentModel;

namespace DinoDiner.Menu 
{
    /// <summary>
    /// A class representing a combo meal
    /// </summary>
    public class CretaceousCombo : IMenuItem, INotifyPropertyChanged, IOrderItem
    {
        // Backing Variables
        private Size size;



        private Entree entree;
        /// <summary>
        /// Gets and sets the entree
        /// </summary>
        public Entree Entree
        {
            get
            {
                return entree;
            }
            protected set
            {
                entree = value;
            }
        }

        /// <summary>
        /// Event handler to notify property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        /// <summary>
        /// Gets and sets the side
        /// </summary>
        private Side side;
        public Side Side
        {
            get
            {
                return side;
            }
            set
            {
                if (side != null)
                {
                    side.PropertyChanged -= ComboItemPropertyChanged;
                }
                value.PropertyChanged += ComboItemPropertyChanged;
                side = value;
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
            }
        }

        /// <summary>
        /// Notifies when combo property changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Description")
            {
                NotifyOfPropertyChanged("Special");
            }
            else
            {
                NotifyOfPropertyChanged(e.PropertyName);
            }
        }

        /// <summary>
        /// Assigns drink class to sodasaurus
        /// </summary>
        private Drink drink = new Sodasaurus();
        /// <summary>
        /// Gets and sets the drink
        /// Notifys property change in Ingredients, Price, Calories, and Special per each food implementation in
        /// each class requirements
        /// </summary>
        public Drink Drink
        {
            get
            {
                return drink;
            }
            set
            {
                if (drink != null)
                {
                    drink.PropertyChanged -= ComboItemPropertyChanged;
                }
                value.PropertyChanged += ComboItemPropertyChanged;
                drink = value;
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
            }
        }

        /// <summary>
        /// Gets the price of the combo
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }

        /// <summary>
        /// Gets the calories of the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        /// <summary>
        /// Gets or sets the size of the combo
        /// Notifys property change in Ingredients, price, calories, and Special per each food implementation in
        /// each class requirements
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
                //NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Size");
                //NotifyOfPropertyChanged("Price");
                //NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Gets the list of ingredients for the combo
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }

        /// <summary>
        /// Gets description of food through tostring method
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Inlude special instructions for the Entree, desrpction of the side, 
        /// special instructions for the side, description of the drink
        /// special instructions for the drink
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                special.AddRange(Entree.Special);
                special.Add(Side.Description);
                special.AddRange(Side.Special);

                special.Add(Drink.Description);
                special.AddRange(Drink.Special);

                return special.ToArray();
            }
        }
       

        /// <summary>
        /// ToString Implementation to refactor all Menu items
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Entree} Combo";
        }

        private void ComboPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Description")
            {
                NotifyOfPropertyChanged("Special");
            }
            else
            {
                NotifyOfPropertyChanged(e.PropertyName);
            }
        }

        public string Toy { get; private set; }

        /// <summary>
        /// Constructor
        /// Constructs a new combo with the specified entree
        /// </summary>
        /// <param name="entree">The entree to use</param>
        public CretaceousCombo(Entree entree)
        {
            entree.PropertyChanged += ComboItemPropertyChanged;
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
            Toy = "Dinosaur toy";
        }


    } // End of Cretaceous combo class
}
