using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface class that that inferace can respond to
    /// </summary>
    public interface IMenuItem : IMenuItem, IOrderItem, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// double Price property with a getter
        /// </summary>
       public virtual double Price { get; set; }
        /// <summary>
        /// uint Calorie property with a getter
        /// </summary>
        public virtual uint Calories { get; set; }
        /// <summary>
        /// Ingreidents of a list string for Ingredients
        /// </summary>
       public abstract List<string> Ingredients { get; }

        public virtual string Description => ToString();

        public virtual string[] Special => Special.ToArray();

        public virtual void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    } // End of IMenuItem interface
}
