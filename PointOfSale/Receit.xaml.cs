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
    /// Interaction logic for Receit.xaml
    /// </summary>
    public partial class Receit : UserControl
    {
        /// <summary>
        /// Initalizes the receit
        /// </summary>
        public Receit()
        {
            InitializeComponent();
        }

        /// <summary>
        /// MainWindow Prooperty
        /// </summary>
        public MainWindow mw
        {
            get;
            set;
        }

        /// <summary>
        /// Click event for done button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var receit = this.FindAncestor<MainWindow>();
            var orderScreen = new OrderComponent();
            receit.ChangeScreen(orderScreen);
            Order o = new Order();
            DataContext = o;
            orderScreen.orderListView.DataContext = o;
        }

        
    }
}
