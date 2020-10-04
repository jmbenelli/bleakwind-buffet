/*
* Author: Jakob Benelli
* Class name: CustomizePhillyPoacher.cs
* Purpose: Class used to create the Customization for the Philly Poacher XAML
*/
using BleakwindBuffet.Data.Entrees;
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
    /// Interaction logic for CustomizePhillyPoacher.xaml
    /// </summary>
    public partial class CustomizePhillyPoacher : UserControl
    {
        /// <summary>
        /// Gets and Sets the Main Window mw
        /// </summary>
        public MainWindow mw
        {
            get; set;
        }

        /// <summary>
        /// Constructor that initializes teh customization component
        /// </summary>
        /// <param name="m">Main Window m</param>
        public CustomizePhillyPoacher(MainWindow m)
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
            PhillyPoacher p = new PhillyPoacher();
            this.DataContext = p;
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
