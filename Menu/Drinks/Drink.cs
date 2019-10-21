using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{

    public abstract class Drink : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Removes or adds ice
        /// </summary>
        public bool Ice { get; set; } = true;
        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// Returns the ingredients that comprise the beverage
        /// </summary>
        public abstract List<string> Ingredients { get; }

        public abstract event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Removes Ice from the drink
        /// </summary>
        public void HoldIce() { Ice = false; }
        /// <summary>
        /// 
        /// </summary>
        public abstract Size Size { get; set; }
        public abstract string Description { get; }
        public abstract string[] Special { get; }
    }
}
