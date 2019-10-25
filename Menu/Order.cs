using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// represents items added to the order
        /// </summary>
        //private ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();

        /// <summary>
        /// Event handler that calls when a property has changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private List<IOrderItem> items;

        public IOrderItem[] Items
        {
            get
            {
                return items.ToArray();
            }
        }



        /// <summary>
        /// calculates the total price from the prices of all order items
        /// NEVER allowed to be negative
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double subtotalCost = 0;
                foreach(IOrderItem i in Items)
                {
                    subtotalCost += i.Price;
                }
                if (subtotalCost > 0)
                {
                    return subtotalCost;
                }
                else
                {
                    return 0;
                }  
            }
        }

        /// <summary>
        /// with a getter and protected setter
        /// </summary>
        public double SalesTaxRate { get; protected set; }

        private double salesTaxCost;
        /// <summary>
        /// which is the product of the SalesTaxRate and the SubtotalCost
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return salesTaxCost; 
            }
            set
            {
                if (value < 0) return;
                salesTaxCost = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxRate"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            }
        }


        private double totalCost;
        /// <summary>
        /// calculates the total cost as the sum of the SubtotalCost and the SalesTaxCost
        /// </summary>
        public double TotalCost
        {
            get
            {
                return totalCost = (SubtotalCost + SalesTaxCost);
            }
        }

        /// <summary>
        /// constructor
        /// </summary>
        public Order()
        {
            items = new List<IOrderItem>();
        }

        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            items.Add(item);
            OnCollectionChanged(this, new EventArgs());
        }

        public void Remove(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            items.Remove(item);
            OnCollectionChanged(this, new EventArgs());
        }


        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }


    } // End of Order class
}
