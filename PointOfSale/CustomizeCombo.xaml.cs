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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        public CustomizeCombo()
        {
            InitializeComponent();
        }

        public void BWCombo(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("CustomizeCombo.xaml", UriKind.Relative));
        }
        public void DNCombo(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("CustomizeCombo.xaml", UriKind.Relative));
        }
        public void PPBJCombo(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("CustomizeCombo.xaml", UriKind.Relative));
        }
        public void PWCombo(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("CustomizeCombo.xaml", UriKind.Relative));
        }
        public void SBCombo(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("CustomizeCombo.xaml", UriKind.Relative));
        }
        public void TRKCombo(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("CustomizeCombo.xaml", UriKind.Relative));
        }
        public void VWCombo(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("CustomizeCombo.xaml", UriKind.Relative));
        }
    }
}
