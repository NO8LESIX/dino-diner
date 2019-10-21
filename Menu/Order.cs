using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Order
    {
        public Order()
        {
            Items = new ObservableCollection<IOrderItem>();
        }

        private double salesTaxRate = 0.00;
        //ObservableCollection<IOrderItem> items = new ObservableCollection<IOrderItem>();
        public ObservableCollection<IOrderItem> Items { get; set; } 

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
        public double SalesTaxRate { get { return salesTaxRate; } private set { salesTaxRate = value; } }
        public double SalesTaxCost { get { return SubtotalCost * SalesTaxRate; } }
        public double TotalCost { get { return (SubtotalCost + SalesTaxCost); } }
    }
}
