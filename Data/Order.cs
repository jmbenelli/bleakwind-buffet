using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Collections;

namespace BleakwindBuffet.Data
{
    public class Order : ICollection<IOrderItem>, INotifyPropertyChanged, INotifyCollectionChanged
    {
        /// <summary>
        /// Creates our list of order items
        /// </summary>
        public List<IOrderItem> list = new List<IOrderItem>();

        public IEnumerable<IOrderItem> i => list.ToArray();

        /// <summary>
        /// Event handler for our collection changing
        /// </summary>
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        /// <summary>
        /// Event handler for our properties changing
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// SalesTaxRate property that is 0.12
        /// </summary>
        private double salesTaxRate = 0.12;
        public double SalesTaxRate
        {
            get
            {
                return salesTaxRate;
            }
            set
            {
                salesTaxRate = value;
            }
        }

        /// <summary>
        /// Subtotal property that keeps track of our total - tax
        /// </summary>
        double subTotal;
        public double SubTotal
        {
            get
            {        
                subTotal = 0;
                foreach (IOrderItem item in i)
                {
                    subTotal += item.Price;
                }
                return subTotal;
            }
            set
            {
                subTotal = value;
            }
        }

        /// <summary>
        /// Tax property that calculates our tax by multiplying our subtotal * our tax rate
        /// </summary>
        private double tax;
        public double Tax
        {
            get
            {
                tax = SubTotal * SalesTaxRate;
                return tax;
            }
            set
            {
                tax = value;
            }
        }

        /// <summary>
        /// Total property that keeps track of our total amount from our order
        /// </summary>
        private double total;
        public double Total
        {
            get
            {
                total = SubTotal + Tax;
                return total;
            }
            set
            {
                total = value;
            }
        }

        /// <summary>
        /// Number property that keeps track of our order number
        /// </summary>
        private static int nextOrderNumber = 1;
        public int Number
        {
            get
            {
                return nextOrderNumber;
            }
            set
            {
                Number = nextOrderNumber;
                nextOrderNumber++;
            }
        }

        /// <summary>
        /// Calories property that keeps track of our total amount of calories
        /// </summary>
        private uint calories = 0;
        public uint Calories
        {
            get
            {
                foreach (IOrderItem item in i)
                {
                    calories += item.Calories;
                }
                return calories;
            }
        }

        /// <summary>
        /// Keeps track of how many ordoer items are in our list
        /// </summary>
        public int Count => ((ICollection<IOrderItem>)list).Count;

        /// <summary>
        /// Makes sure our colelction is read only
        /// </summary>
        public bool IsReadOnly => ((ICollection<IOrderItem>)list).IsReadOnly;

        /// <summary>
        /// If an Item is changed our properties change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemChangedEventListener(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Calories")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            }
        }

        /// <summary>
        /// Adds an item to our collection
        /// </summary>
        /// <param name="item"></param>
        public void Add (IOrderItem item)
        {
            list.Add(item);
            item.PropertyChanged += ItemChangedEventListener;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("list"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("i"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }

        /// <summary>
        /// Removes and item from our collection
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            list.Remove(item);
            item.PropertyChanged -= ItemChangedEventListener;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }

        /// <summary>
        /// Clears the items from our collection
        /// </summary>
        public void Clear()
        {
            ((ICollection<IOrderItem>)list).Clear();
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }

        /// <summary>
        /// Checks to see if our collection contains the item 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(IOrderItem item)
        {
            return ((ICollection<IOrderItem>)list).Contains(item);
        }

        /// <summary>
        /// Copies the collection
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayIndex"></param>
        public void CopyTo(IOrderItem[] array, int arrayIndex)
        {
            ((ICollection<IOrderItem>)list).CopyTo(array, arrayIndex);
        }

        /// <summary>
        /// Removes an item from the collection
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        bool ICollection<IOrderItem>.Remove(IOrderItem item)
        {
            return ((ICollection<IOrderItem>)list).Remove(item);
        }

        /// <summary>
        /// Gets the enumerator
        /// </summary>
        /// <returns></returns>
        public IEnumerator<IOrderItem> GetEnumerator()
        {
            return ((IEnumerable<IOrderItem>)list).GetEnumerator();
        }

        /// <summary>
        /// Calls our get enumerator method
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)list).GetEnumerator();
        }
    }
}

