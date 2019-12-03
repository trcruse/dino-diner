using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface class that that inferace can respond to
    /// </summary>
    public interface IMenuItem 
    {

        //public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// double Price property with a getter
        /// </summary>
        double Price { get; set; }
        /// <summary>
        /// uint Calorie property with a getter
        /// </summary>
        uint Calories { get; set; }
        /// <summary>
        /// Ingreidents of a list string for Ingredients
        /// </summary>
        List<string> Ingredients { get; }
        object Description { get; }

        //string Description => ToString();

        //string[] Special => Special.ToArray();

        //public virtual void NotifyOfPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

    } // End of IMenuItem interface
}
