/*
* Author: Jakob Benelli
* Class name: CustomizeCandleHearthCoffee.cs
* Purpose: Class used to create the Customization for the Candlehearth Coffee XAML
*/
using BleakwindBuffet.Data.Drinks;
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

namespace PointOfSale.CustomizeDrinks
{
    /// <summary>
    /// Interaction logic for CustomizeCandlehearthCoffee.xaml
    /// </summary>
    public partial class CustomizeCandlehearthCoffee : UserControl
    {
        /// <summary>
        /// Gets and sets the Main Window mw
        /// </summary>
        public MainWindow mw
        {
            get; set;
        }

        /// <summary>
        /// Constructor that initializes teh customization component
        /// </summary>
        /// <param name="m">Main Window m</param>
        public CustomizeCandlehearthCoffee(MainWindow m)
        {
            InitializeComponent();
            mw = m;
        }

        /// <summary>
        /// Swaps screen to the main window when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Done_Click(object sender, RoutedEventArgs e)
        {
            mw.SwapScreen(new MenuComponent(mw));
            CandlehearthCoffee c = new CandlehearthCoffee();
            this.DataContext = c;
        }

        /// <summary>
        /// Swaps screen to the main window when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            mw.SwapScreen(new MenuComponent(mw));
        }
    }
}
