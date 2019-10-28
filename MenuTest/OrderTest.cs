using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;
using System.ComponentModel;

namespace MenuTest
{

    public class OrderTest 
    {
        public class MockedItem : IOrderItem
        {


            public string[] Special { get; set; }

            public string Description {get;set;}

            private double price;

            public event PropertyChangedEventHandler PropertyChanged;

            public double Price
            {
                get
                {
                    return price = 1.58;
                }
            }
        } // End of MockedItem class

        public class MockedItem2 : IOrderItem
        {

            public string[] Special { get; set; }

            public string Description { get; set; }
            private double price;

            public event PropertyChangedEventHandler PropertyChanged;

            public double Price
            {
                get
                {
                    return price = -10.58;
                }
            }
        } // End of MockedItem2 class

        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Order or = new Order();
            or.Add(new MockedItem());
         
            Assert.Equal<double>(1.58, or.SubtotalCost);
        }

        [Fact]
        public void SubtotalCostCannotBeMadeNegative()
        {
            Order or = new Order();

            or.Add(new MockedItem());
            or.Add(new MockedItem2());
            Assert.Equal<double>(0, or.SubtotalCost);
        }

        
    }
}
