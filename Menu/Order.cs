using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.Specialized;
using System;

namespace DinoDiner.Menu
{
    /// <summary>
    /// 
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// Local control for the sales tax rate
        /// </summary>
        private double salesTaxRate = 0.00;
        private ObservableCollection<IOrderItem> items = new ObservableCollection<IOrderItem>();
        /// <summary>
        /// The Property Changed event handler; notifies of changes to the Price, Description, and Special Properties.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Method alerts to any changes made to the collection and informs of updates to prices
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void AllPropertiesChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }
        /// <summary>
        /// Method alerts to any changes made to the collection and informs of updates to prices
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnPropertyChanged(object sender, PropertyChangedEventArgs property)
        {
            AllPropertiesChanged();
        }
        /// <summary>
        /// Controls the items in the order
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get { return items; } set { items.Add((IOrderItem)value); } }
        /// <summary>
        /// Constuctor for a new Order
        /// </summary>
        public Order()
        {
            Add(new SteakosaurusBurger());
        }
        /// <summary>
        /// Accessor to calculate the Subtotal
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double sc = 0.00;
                foreach (IOrderItem item in Items)
                {
                    sc += item.Price;
                }

                return sc;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public double SalesTaxRate
        {
            get
            {
                return salesTaxRate;
            }
            private set
            {
                if (value < 0)
                    return;

                salesTaxRate = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public double SalesTaxCost { get { return SubtotalCost * SalesTaxRate; } }
        /// <summary>
        /// 
        /// </summary>
        public double TotalCost { get { return (SubtotalCost + SalesTaxCost); } }

        public void Add(IOrderItem item)
        {
            Items.Add(item);
            item.PropertyChanged += OnPropertyChanged;
            AllPropertiesChanged();
        }
        public bool Remove(IOrderItem item)
        {

            bool removed = Items.Remove(item);
            if (removed)
            {
                item.PropertyChanged += OnPropertyChanged;
                AllPropertiesChanged();
            }
            return removed;
        }

    }
}
