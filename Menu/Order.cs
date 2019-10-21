using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    public class Order
    {
        private double salesTaxRate = 0.00;
        private ObservableCollection<IOrderItem> order = new ObservableCollection<IOrderItem>();
        ObservableCollection<IOrderItem> Orders
        {
            get { return order; }
            set { order = value; }
        }
        public double SubtotalCost
        {
            get
            {
                double sc = 0.00;
                foreach (IOrderItem item in Orders)
                {
                    sc += item.Price;
                }
                if (SubtotalCost < 0)
                    return 0.00;
                return sc;
            }
        }
        public double SalesTaxRate { get { return salesTaxRate; } private set { salesTaxRate = value; } }
        public double SalesTaxCost { get { return SubtotalCost * SalesTaxRate; } }
        public double TotalCost { get { return (SubtotalCost + SalesTaxRate); } }

    }
}
