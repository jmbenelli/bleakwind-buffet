/*
* Author: Jakob Benelli
* Class name: IOrderItem.cs
* Purpose: Class used to create the IOrderItem interface
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Interface for the IOrderItem 
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
    {
        /// <summary>
        /// The price of the item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The calories of the item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// The customers special instructions
        /// </summary>
        List<string> SpecialInstructions {get;}
    }
}
