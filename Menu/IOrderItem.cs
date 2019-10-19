﻿using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface for all menu items to implement and inherit
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// Price Property
        /// </summary>
         double Price { get; }

        /// <summary>
        /// Description string property
        /// matches the ToString() implementation from prior milestones
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Special string array property
        /// contains any special instructions for the food preparation
        /// </summary>
        string[] Special { get; }



    } // end of IOrderItem interface
}
