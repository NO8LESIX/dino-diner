using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OrderList.NavigationService = OrderInterface.NavigationService;
            //order.Items.Add(new Friceritops);
            //order.Items.Add(new Tyrannotea);

            //OrderList list = new OrderList(order);

            //OrderInterface interface = new OrderInterface(order);
            // DockPanel dock = new DockPanel();

            // OrderList.DataContext = order;
            //OrderInterface.DataContext = order;
        }

        private void OrderList_Loaded(object sender, RoutedEventArgs e)
        {

        }
        public void OnLoadCompleted(object sender, RoutedEventArgs e)
        {
            SetFrameDataContext();
        }
        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            SetFrameDataContext();
        }
        public void SetFrameDataContext()
        {
            FrameworkElement content = OrderInterface.Content as FrameworkElement;
            if (content == null)
            {
                return;
            }
            content.DataContext = OrderInterface.DataContext;
        }

        private void BindDataContextToPage()
        {
            if (OrderInterface.Content is FrameworkElement element)
            {
                element.DataContext = OrderInterface.DataContext;
            }
        }

        private void OnLoadCompleted(object sender, NavigationEventArgs e)
        {
            BindDataContextToPage();
        }
    }
}
