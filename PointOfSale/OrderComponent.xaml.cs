/*
* Author: Jakob Benelli
* Class name: MainWindow.cs
* Purpose: Class used to create the Order Component XAML
*/
using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Text;
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
    /// Interaction logic for OrderComponent.xaml
    /// </summary>
    public partial class OrderComponent : UserControl
    {
        /// <summary>
        /// Constructor that Initializes the Order Component
        /// </summary>
        public OrderComponent()
        {
            InitializeComponent();
        }

        public MainWindow mw
        {
            get; set;
        }

        /// <summary>
        /// Cancels an Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelOrder_Click(object sender, RoutedEventArgs e)
        {
            Order o = new Order();
            DataContext = o;
            orderListView.DataContext = o;
        }

        /// <summary>
        /// click event that switches to the payment options screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Complete_Click(object sender, RoutedEventArgs e)
        {
            var payment = this.FindAncestor<MainWindow>();
            var paymentScreen = new PaymentOptions();
            payment.SwapScreen(paymentScreen);
        }
    }
}
