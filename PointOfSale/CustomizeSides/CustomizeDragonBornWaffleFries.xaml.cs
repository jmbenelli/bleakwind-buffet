/*
* Author: Jakob Benelli
* Class name: CustomizeDragonBornWaffleFries.cs
* Purpose: Class used to create the Customization for the DragonBorn Waffle Fries XAML
*/
using BleakwindBuffet.Data.Sides;
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

namespace PointOfSale.CustomizeSides
{
    /// <summary>
    /// Interaction logic for CustomizeDragonBornWaffleFries.xaml
    /// </summary>
    public partial class CustomizeDragonBornWaffleFries : UserControl
    {
        /// <summary>
        /// Gets and Sets the MainWindow mw
        /// </summary>
        public MainWindow mw
        {
            get; set;
        }

        /// <summary>
        /// Constructor that initializes teh customization component
        /// </summary>
        /// <param name="m">Main Window m</param>
        public CustomizeDragonBornWaffleFries(MainWindow m)
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
            DragonbornWaffleFries d = new DragonbornWaffleFries();
            this.DataContext = d;
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
