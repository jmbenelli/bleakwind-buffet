/*
* Author: Jakob Benelli
* Class name: CustomizeMadOtarGrits.cs
* Purpose: Class used to create the Customization for the Mad Otar Grits XAML
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
    /// Interaction logic for CustomizeMadOtarGrits.xaml
    /// </summary>
    public partial class CustomizeMadOtarGrits : UserControl
    {
        /// <summary>
        /// Gets and sets Main Window mw
        /// </summary>
        public MainWindow mw
        {
            get; set;
        }

        /// <summary>
        /// Constructor that initializes the customization component
        /// </summary>
        /// <param name="m">Main Window m</param>
        public CustomizeMadOtarGrits(MainWindow m)
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
            MadOtarGrits m = new MadOtarGrits();
            this.DataContext = m;
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
