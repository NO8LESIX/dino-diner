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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
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
            FrameworkElement content = OrderUI.Content as FrameworkElement;
            if (content == null)
            {
                return;
            }
            content.DataContext = OrderUI.DataContext;
        }

        private void BindDataContextToPage()
        {
            if (OrderUI.Content is FrameworkElement element)
            {
                element.DataContext = OrderUI.DataContext;
            }
        }

        private void OnLoadCompleted(object sender, NavigationEventArgs e)
        {
            BindDataContextToPage();
        }
    }
}
