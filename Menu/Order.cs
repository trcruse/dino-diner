using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class Order 
    {
        /// <summary>
        /// represents items added to the order
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();

        

        private double subtotalCost;
        /// <summary>
        /// calculates the total price from the prices of all order items
        /// NEVER allowed to be negative
        /// </summary>
        public double SubtotalCost
        {
            get
            {
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
                return salesTaxCost = (SalesTaxRate * SubtotalCost);
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

        }


    } // End of Order class
}
