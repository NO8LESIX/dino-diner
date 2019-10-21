using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace DinoDiner.Menu
{
    public enum Size
    {
        Small,
        Medium,
        Large
    }
    public abstract class Side : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }
        //public abstract List<string> Ingredients { get; protected set; }
        public abstract Size Size { get; set; }
        public abstract string Description { get; }
        public abstract string[] Special { get; }

        public abstract event PropertyChangedEventHandler PropertyChanged;
    }
}
