using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for MoneyBox.xaml
    /// </summary>
    public partial class MoneyBox : UserControl
    {
        public MoneyBox()
        {
            InitializeComponent();
        }

        public static DependencyProperty NumberProperty = DependencyProperty.Register("Number", typeof(int), typeof(MoneyBox));

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Creates a Number property that uses a dependency to keep track of how much of each currency is stored
        /// </summary>
        public int Number
        {
            get => (int)GetValue(NumberProperty);
            set
            {
                SetValue(NumberProperty, value);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Number"));
            }
        }

        /// <summary>b
        /// Click event to increment the number property
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IncrementButton_Click(object sender, RoutedEventArgs e)
        {
            Number++;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Number"));

        }

        /// <summary>
        /// Click event to decrement the number property
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DecrementButton_Click(object sender, RoutedEventArgs e)
        {
            Number--;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Number"));
        }
    }
}
