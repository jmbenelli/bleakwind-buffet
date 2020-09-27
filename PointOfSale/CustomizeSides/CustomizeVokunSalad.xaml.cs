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
    /// Interaction logic for CustomizeVokunSalad.xaml
    /// </summary>
    public partial class CustomizeVokunSalad : UserControl
    {
        public MainWindow mw
        {
            get; set;
        }
        public CustomizeVokunSalad(MainWindow m)
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
