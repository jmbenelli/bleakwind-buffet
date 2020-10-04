/*
* Author: Jakob Benelli
* Class name: MainWindow.cs
* Purpose: Class used to create the Main Window XAML
*/
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Constructor that initializes the Main Window Compoennt that has a Menu Component
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            MenuComponent b = new MenuComponent(this);
            border.Child = b;
        }
         
        /// <summary>
        /// This method swaps screens between the customization screens and the menu component screens
        /// </summary>
        /// <param name="f"></param>
        public void SwapScreen(FrameworkElement f)
        {
            border.Child = f;
        }

    }
}
