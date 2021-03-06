﻿/*
 * Author: Jakob Benelli
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    /// <summary>
    /// Test class for the Mad Otar Grits
    /// </summary>
    public class MadOtarGritsTests
    {
        /// <summary>
        /// Checks to see if the IOrderInterface Class is implemented
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractIOrderInterfaceClass()
        {
            MadOtarGrits m = new MadOtarGrits();
            Assert.IsAssignableFrom<IOrderItem>(m);
        }

        /// <summary>
        /// Checks to see if it is a Side
        /// </summary>
        [Fact]
        public void ShouldBeSide()
        {
            MadOtarGrits m = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(m);
        }

        /// <summary>
        /// Checks to see if the size is set to small by default
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            MadOtarGrits m = new MadOtarGrits();
            Assert.Equal(Size.Small, m.Size);
        }
           
        /// <summary>
        /// Checks to see if the user can set the size to small, medium, or large
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MadOtarGrits m = new MadOtarGrits();
            m.Size = Size.Large;
            Assert.Equal(Size.Large, m.Size);
            m.Size = Size.Medium;
            Assert.Equal(Size.Medium, m.Size);
            m.Size = Size.Small;
            Assert.Equal(Size.Small, m.Size);
        }

        /// <summary>
        /// Checks to see if the correct special instructions are returned,
        /// but in this case there are no special instructions for size
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            return;
        }

        /// <summary>
        /// Checks to see if the correct price is returned depending on size
        /// </summary>
        /// <param name="size">The size of the grits</param>
        /// <param name="price">The price of the grits</param>
        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            MadOtarGrits m = new MadOtarGrits();
            m.Size = size;
            Assert.Equal(price, m.Price);
        }

        /// <summary>
        /// Checks to see if the correct calories are returned depending on size
        /// </summary>
        /// <param name="size">The size of the grits</param>
        /// <param name="calories">The calories of the grits</param>
        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            MadOtarGrits m = new MadOtarGrits();
            m.Size = size;
            Assert.Equal(calories, m.Calories);
        }

        /// <summary>
        /// Checks to see if the correct toString is returned
        /// </summary>
        /// <param name="size">The size of the grits</param>
        /// <param name="name">The to String return value</param>
        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MadOtarGrits m = new MadOtarGrits();
            m.Size = size;
            Assert.Equal(name, m.ToString());
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void SizeChangeNotifiesSizeProperty(Size s)
        {
            MadOtarGrits a = new MadOtarGrits();
            Assert.PropertyChanged(a, "Size", () =>
            {
                a.Size = s;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void SizeChangeNotifiesPriceProperty(Size s)
        {
            MadOtarGrits a = new MadOtarGrits();
            Assert.PropertyChanged(a, "Price", () =>
            {
                a.Size = s;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void SizeChangeNotifiesCaloriesProperty(Size s)
        {
            MadOtarGrits a = new MadOtarGrits();
            Assert.PropertyChanged(a, "Calories", () =>
            {
                a.Size = s;
            });
        }

        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var c = new MadOtarGrits();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(c);
        }

        /// <summary>
        /// Checks to see if the correct Description value is returned
        /// </summary>
        /// <param name="d">The Description return value for the item</param>
        [Theory]
        [InlineData("Cheesey Grits.")]
        public void ShouldReturnCorrectDescription(string d)
        {
            MadOtarGrits aj = new MadOtarGrits();
            Assert.Equal(d, aj.Description);
        }

    }
}