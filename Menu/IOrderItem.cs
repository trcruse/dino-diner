using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu
{
    public interface IOrderItem
    {
        /// <summary>
        /// Price Property
        /// </summary>
         double Price { get; }

        /// <summary>
        /// Description string property
        /// </summary>
         string Description { get; }

        /// <summary>
        /// Special string array property
        /// </summary>
         string[] Special { get; }





    } // end of IOrderItem interface
}
