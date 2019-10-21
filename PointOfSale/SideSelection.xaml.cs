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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        public SideSelection()
        {
            InitializeComponent();
        }

        private void SelectLarge(object sender, RoutedEventArgs e)
        {

        }

        private void SelectMedium(object sender, RoutedEventArgs e)
        {

        }

        private void SelectSmall(object sender, RoutedEventArgs e)
        {

        }

        private void SelectMeteorMacAndCheese(object sender, RoutedEventArgs e)
        {

        }

        private void SelectMezzorellaSticks(object sender, RoutedEventArgs e)
        {

        }

        private void SelectTriceritots(object sender, RoutedEventArgs e)
        {

        }

        private void SelectFryceritops(object sender, RoutedEventArgs e)
        {
            Order order = (Order) DataContext;
            order.Items.Add(new Friceritops());

            LargeButton.IsEnabled = true;
            MediumButton.IsEnabled = true;
            SmallButton.IsEnabled = true;
            Triceritots.IsEnabled = false;
            MezzorellaSticks.IsEnabled = false;
            MeteorMacAndCheese.IsEnabled = false;




        }
    }
}
