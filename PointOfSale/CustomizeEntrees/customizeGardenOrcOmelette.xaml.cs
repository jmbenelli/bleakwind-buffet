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
    /// Interaction logic for customizeGardenOrcOmelette.xaml
    /// </summary>
    public partial class customizeGardenOrcOmelette : UserControl
    {
        public MainWindow mw
        {
            get; set;
        }

        public customizeGardenOrcOmelette(MainWindow m)
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
