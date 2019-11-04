using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.Specialized;
using System;

namespace DinoDiner.Menu
{
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// Local control for the sales tax rate
        /// </summary>
        private double salesTaxRate = 0.00;
        /// <summary>
        /// The Property Changed event handler; notifies of changes to the Price, Description, and Special Properties.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Method alerts to any changes made to the collection and informs of updates to prices
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }
        /// <summary>
        /// Controls the items in the order
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; }
        /// <summary>
        /// Constuctor for a new Order
        /// </summary>
        public Order()
        {
            Items = new ObservableCollection<IOrderItem>();
            Items.CollectionChanged += OnCollectionChanged;

            Items.Add(new SteakosaurusBurger());


        }
        /// <summary>
        /// Accessor for the 
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
                if (SubtotalCost < 0)
                {
                    return 0.00;
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
                Items.CollectionChanged += OnCollectionChanged;
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
            item.PropertyChanged += OnCollectionChanged;
            Items.Add(item);
        }
        public void Remove(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            Items.Remove(item);
        }

    }
}
