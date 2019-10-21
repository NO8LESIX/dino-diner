using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    public class Order
    {
        public Order()
        {
            order = new ObservableCollection<IOrderItem>();
        }

        private double salesTaxRate = 0.00;
        private ObservableCollection<IOrderItem> order = new ObservableCollection<IOrderItem>();
 /*       public ObservableCollection<IOrderItem> Order
        {
            get
            {
                return new ObservableCollection<IOrderItem>();
            }
            set
            {
                // IOrderItem order = value;
                // order = new ObservableCollection<IOrderItem>();
                order = new ObservableCollection<IOrderItem>(value);
            }
        }*/
        public double SubtotalCost
        {
            get
            {
                double sc = 0.00;
                foreach (IOrderItem item in order)
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
