using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface class that that inferace can respond to
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// double Price property with a getter
        /// </summary>
       double Price { get; }
        /// <summary>
        /// uint Calorie property with a getter
        /// </summary>
        uint Calories { get; }
        /// <summary>
        /// Ingreidents of a list string for Ingredients
        /// </summary>
       List<string> Ingredients { get; }

       

    } // End of IMenuItem interface
}
