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
        public Side Side { get; set; }
        private void SelectSide(Side side)
        {
            if(side is )
            if (DataContext is Order order)
            {
                order.Items.Add(side);
                this.Side = side;
            }
        }
        /// <summary>
        /// Controls the size of the Side being added to the Order
        /// </summary>
        /// <param name="size"></param>
        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Side != null)
            {
                this.Side.Size = size;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
            LargeButton.Visibility = Visibility.Hidden;
            MediumButton.Visibility = Visibility.Hidden;
            SmallButton.Visibility = Visibility.Hidden;
        }

        public SideSelection(Side side)
        {
            InitializeComponent();
            Side = side;
            LargeButton.Visibility = Visibility.Visible;
            MediumButton.Visibility = Visibility.Visible;
            SmallButton.Visibility = Visibility.Visible;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectLarge(object sender, RoutedEventArgs e)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
            //enable selection of new item after confirmation
            Triceritots.IsEnabled = true;
            MezzorellaSticks.IsEnabled = true;
            MeteorMacAndCheese.IsEnabled = true;
            Friceritops.IsEnabled = true;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectMedium(object sender, RoutedEventArgs e)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
            //enable selection of new item after confirmation
            Triceritots.IsEnabled = true;
            MezzorellaSticks.IsEnabled = true;
            MeteorMacAndCheese.IsEnabled = true;
            Friceritops.IsEnabled = true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectSmall(object sender, RoutedEventArgs e)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
            //enable selection of new item after confirmation
            Triceritots.IsEnabled = true;
            MezzorellaSticks.IsEnabled = true;
            MeteorMacAndCheese.IsEnabled = true;
            Friceritops.IsEnabled = true;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectMeteorMacAndCheese(object sender, RoutedEventArgs e)
        {
            SelectSide(new MeteorMacAndCheese());
            LargeButton.Visibility = Visibility.Visible;
            MediumButton.Visibility = Visibility.Visible;
            SmallButton.Visibility = Visibility.Visible;

            //Disable Buttons that are not necessary
            Triceritots.IsEnabled = false;
            MezzorellaSticks.IsEnabled = false;
            Friceritops.IsEnabled = false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectMezzorellaSticks(object sender, RoutedEventArgs e)
        {
            SelectSide(new MezzorellaSticks());
            LargeButton.Visibility = Visibility.Visible;
            MediumButton.Visibility = Visibility.Visible;
            SmallButton.Visibility = Visibility.Visible;

            //Disable Buttons that are not necessary
            Triceritots.IsEnabled = false;
            Friceritops.IsEnabled = false;
            MeteorMacAndCheese.IsEnabled = false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectTriceritots(object sender, RoutedEventArgs e)
        {
            SelectSide(new Triceritots());
            LargeButton.Visibility = Visibility.Visible;
            MediumButton.Visibility = Visibility.Visible;
            SmallButton.Visibility = Visibility.Visible;

            //Disable Buttons that are not necessary
            Friceritops.IsEnabled = false;
            MezzorellaSticks.IsEnabled = false;
            MeteorMacAndCheese.IsEnabled = false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFryceritops(object sender, RoutedEventArgs e)
        {
            SelectSide(new Friceritops());
            LargeButton.Visibility = Visibility.Visible;
            MediumButton.Visibility = Visibility.Visible;
            SmallButton.Visibility = Visibility.Visible;

            //Disable Buttons that are not necessary
            Triceritots.IsEnabled = false;
            MezzorellaSticks.IsEnabled = false;
            MeteorMacAndCheese.IsEnabled = false;
        }


    }
}
