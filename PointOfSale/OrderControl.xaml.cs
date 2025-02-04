﻿using System;
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
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public NavigationService NavigationService { get; set; }
        public OrderControl()
        {
            InitializeComponent();
        }
        private void OnSelectionchanged(object sender, SelectionChangedEventArgs e)
        {
            if (OrderItems.SelectedItem is Side)
            {

                NavigationService?.Navigate(new SideSelection());
            }
        }

        private void OrderItems_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            //MountItemListener();
        }
        private void MountItemListener()
        {
            if (DataContext is Order order)
            {
                //order.Items.CollectionChanged += OnCollectionChanged;
            }
        }
        private void OnRemovedItem(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (sender is FrameworkElement element)
                {
                    if (element.DataContext is IOrderItem item)
                        order.Items.Remove(item);
                }
            }
        }
    }
}
