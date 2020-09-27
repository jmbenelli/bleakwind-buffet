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
        public MainWindow mw
        {
            get; set;
        }

        public CustomizeCandlehearthCoffee(MainWindow m)
        {
            InitializeComponent();
            mw = m;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mw.SwapScreen(new MenuComponent(mw));
        }
    }
}
