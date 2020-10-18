using System;
using System.CodeDom;
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
using System.Xml.Schema;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashPaymentxaml.xaml
    /// </summary>
    public partial class CashPayment : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public CashPayment()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Dependency Property NumberProperty
        /// </summary>
        public static DependencyProperty NumberProperty  = DependencyProperty.Register("Number", typeof(int), typeof(CashPaymentxaml));


        /// <summary>
        /// Keep track of how many One Hundreds are stored
        /// </summary>
        public int OneHundredNumber
        {
            get => (int)GetValue(NumberProperty);
            set
            {
                SetValue(NumberProperty, value);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OneHundredNumber"));
            }
        }

        /// <summary>
        /// Property to keep track of how many Fifties are stored
        /// </summary>
        public int FiftyNumber
        {
            get => (int)GetValue(NumberProperty);
            set
            {
                SetValue(NumberProperty, value);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftyNumber"));

            }
        }

        /// <summary>
        /// Property to keep track of how many twenties are stored
        /// </summary>
        public int TwentyNumber
        {
            get => (int)GetValue(NumberProperty);
            set
            {
                SetValue(NumberProperty, value);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentyNumber"));

            }
        }

        /// <summary>
        /// Property to keep track of how many tens are stored
        /// </summary>
        public int TenNumber
        {
            get => (int)GetValue(NumberProperty);
            set
            {
                SetValue(NumberProperty, value);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TenNumber"));

            }
        }

        /// <summary>
        /// Property to keep track of how many fives are stored
        /// </summary>
        public int FiveNumber
        {
            get => (int)GetValue(NumberProperty);
            set
            {
                SetValue(NumberProperty, value);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiveNumber"));

            }
        }

        /// <summary>
        /// Property to keep track of how many twos are stored
        /// </summary>
        public int TwoNumber
        {
            get => (int)GetValue(NumberProperty);
            set
            {
                SetValue(NumberProperty, value);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwoNumber"));

            }
        }

        /// <summary>
        /// Property to keep track of how many ones are stored
        /// </summary>
        public int OneNumber
        {
            get => (int)GetValue(NumberProperty);
            set
            {
                SetValue(NumberProperty, value);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OneNumber"));

            }
        }

        /// <summary>
        /// Property to keep track of how many one dollar bills are stored
        /// </summary>
        public int OneDollarNumber
        {
            get => (int)GetValue(NumberProperty);
            set
            {
                SetValue(NumberProperty, value);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OneDollarNumber"));

            }
        }

        /// <summary>
        /// Keeps track of how many fifty cents are stored
        /// </summary>
        public int FiftyCentsNumber
        {
            get => (int)GetValue(NumberProperty);
            set
            {
                SetValue(NumberProperty, value);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftyCentsNumber"));
            }
        }

        /// <summary>
        /// Keeps track of how many quarters are stored
        /// </summary>
        public int TwentyFiveCentsNumber
        {
            get => (int)GetValue(NumberProperty);
            set
            {
                SetValue(NumberProperty, value);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentyFiveCentsNumber"));

            }
        }

        /// <summary>
        /// Keeps track of how many dies are stored
        /// </summary>
        public int TenCentsNumber
        {
            get => (int)GetValue(NumberProperty);
            set
            {
                SetValue(NumberProperty, value);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TenCentsNumber"));

            }
        }

        /// <summary>
        /// Keeps track of how many nickels are stored
        /// </summary>
        public int FiveCentsNumber
        {
            get => (int)GetValue(NumberProperty);
            set
            {
                SetValue(NumberProperty, value);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiveCentsNumber"));

            }
        }

        /// <summary>
        /// Keeps track of how many pennies are stored
        /// </summary>
        public int OneCentNumber
        {
            get => (int)GetValue(NumberProperty);
            set
            {
                SetValue(NumberProperty, value);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OneCentNumber"));

            }
        }

        /// <summary>
        /// Property to keep track of the amount due
        /// </summary>
        private double amount;
        public double AmountDue
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));

            }
        }

        /// <summary>
        /// Keeps track of how much change is owed
        /// </summary>
        private double change;
        public double ChangeOwed
        {
            get
            {
                return change;
            }
            set
            {
                change = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));

            }
        }

        /// <summary>
        /// Click Event that finalizes the payment and switches to the receit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Finalize_Click(object sender, RoutedEventArgs e)
        {
            var payment = this.FindAncestor<MainWindow>();
            var receit = new Receit();
            payment.ChangeScreen(receit);
        }

        /// <summary>
        /// Main Window Property
        /// </summary>
        public MainWindow mw
        {
            get; set;
        }

        /// <summary>
        /// Click event that returns to the menu component
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Return_Click(object sender, RoutedEventArgs e)
        {
            var order = this.FindAncestor<MainWindow>();
            var menuScreen = new MenuComponent(mw);
            order.SwapScreen(menuScreen);
        }
    }
}
