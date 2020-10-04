/*
* Author: Jakob Benelli
* Class name: CustomizeSmokehouseSkeleton.cs
* Purpose: Class used to create the Customization for the Smokehouse Skeleton XAML
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
    /// Interaction logic for customizeSmokehouseSkeleton.xaml
    /// </summary>
    public partial class customizeSmokehouseSkeleton : UserControl
    {
        /// <summary>
        /// Gets and sets the Main Window mw
        /// </summary>
        public MainWindow mw
        {
            get; set;
        }

        /// <summary>
        /// Constructor that initializes the customization component
        /// </summary>
        /// <param name="m">Main Window m</param>
        public customizeSmokehouseSkeleton(MainWindow m)
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
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            this.DataContext = s;

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
