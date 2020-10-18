using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Net.Mail;
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
using BleakwindBuffet.Data;
using RoundRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PaymentOptions.xaml
    /// </summary>
    public partial class PaymentOptions : UserControl
    {
        /// <summary>
        /// Initializes the Payment Options xaml class
        /// </summary>
        public PaymentOptions()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Uses the RoundRegister dll to process a card payment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardPayment_Click(object sender, RoutedEventArgs e)
        {
            var order = (Order)DataContext;
            var c = CardReader.RunCard(order.Total);

            if (c == CardTransactionResult.Approved)
            {
                var v = this.FindAncestor<MainWindow>();
                var receit = new Receit();
                v.ChangeScreen(receit);
            }
            else if (c == CardTransactionResult.Declined)
            {
                MessageBox.Show("Card Declined");    
            }
            else if (c == CardTransactionResult.IncorrectPin)
            {
                MessageBox.Show("Incorrect Pin");
            }
            else if ( c == CardTransactionResult.InsufficientFunds)
            {
                MessageBox.Show("InsufficientFunds");
            }
            else
            {
                MessageBox.Show("Read Error");
            }

            Order o = new Order();
            DataContext = o;
            OrderComponent orderC = new OrderComponent();
            orderC.orderListView.DataContext = o;
        }

        /// <summary>
        /// Swaps to a cash payment screen where cash payment is handled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CashPayment_Click(object sender, RoutedEventArgs e)
        {
            var payment = this.FindAncestor<MainWindow>();
            var paymentScreen = new CashPayment();
            payment.SwapScreen(paymentScreen);
        }

        
    }
}
