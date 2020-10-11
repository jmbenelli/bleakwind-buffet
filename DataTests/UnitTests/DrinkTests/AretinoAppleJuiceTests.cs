/*
 * Author: Jakob Benelli
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// Test Class for AretinoAppleJuice.cs
    /// </summary>
    public class AretinoAppleJuiceTests
    {
        /// <summary>
        /// Checks to see if the IOrderInterface Class is implemented
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractIOrderInterfaceClass()
        {
            AretinoAppleJuice a = new AretinoAppleJuice();
            Assert.IsAssignableFrom<IOrderItem>(a);
        }

        /// <summary>
        /// Checks to see if it is a drink
        /// </summary>
        [Fact]
        public void ShouldBeDrink()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.IsAssignableFrom<Drink>(aj);
        }

        /// <summary>
        /// This checks if the the ice is set to false by default
        /// </summary>
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.False(aj.Ice);
        }

        /// <summary>
        /// This checks if the size is set to small by default
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.Equal(Size.Small, aj.Size);
        }

        /// <summary>
        /// This checks to see if you are able to set the boolean value of ice to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Ice = true;
            Assert.True(aj.Ice);
            aj.Ice = false;
            Assert.False(aj.Ice);
        }

        /// <summary>
        /// This checks to see if you are able to set the size value to small, medium, or large
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = Size.Large;
            Assert.Equal(Size.Large, aj.Size);
            aj.Size = Size.Medium;
            Assert.Equal(Size.Medium, aj.Size);
            aj.Size = Size.Small;
            Assert.Equal(Size.Small, aj.Size);
        }

        /// <summary>
        /// This checks if the correct price matches with the correct size
        /// </summary>
        /// <param name="size">The size of the juice</param>
        /// <param name="price">The price of the juice</param>
        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = size;
            Assert.Equal(price, aj.Price);

        }

        /// <summary>
        /// This checks if the correct calories match with the correct size
        /// </summary>
        /// <param name="size">The size of the juice</param>
        /// <param name="cal">The number of calories in the juice</param>
        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = size;
            Assert.Equal(cal, aj.Calories);
        }

        /// <summary>
        /// This checks to see if the correct special instructions are displayed
        /// </summary>
        /// <param name="includeIce">Whether or not the customer wants ice</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Ice = includeIce;
            if (includeIce) Assert.Contains("Add ice", aj.SpecialInstructions);
            else Assert.Empty(aj.SpecialInstructions);
        }

        /// <summary>
        /// Checks to see if the correct ToString value is returned
        /// </summary>
        /// <param name="size">The size of the juice</param>
        /// <param name="name">The ToString return value for the juice</param>
        [Theory]
        [InlineData(Size.Small, "Small Aretino Apple Juice")]
        [InlineData(Size.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Size.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = size;
            Assert.Equal(name, aj.ToString());
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var s = new AretinoAppleJuice();

            Assert.PropertyChanged(s, "Ice", () =>
            {
                s.Ice = true;
            });

            Assert.PropertyChanged(s, "Ice", () =>
            {
                s.Ice = false;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void SizeChangeNotifiesSizeProperty(Size s)
        {
            AretinoAppleJuice a = new AretinoAppleJuice();
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
            AretinoAppleJuice a = new AretinoAppleJuice();
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
            AretinoAppleJuice a = new AretinoAppleJuice();
            Assert.PropertyChanged(a, "Calories", () =>
            {
                a.Size = s;
            });
        }

        /// <summary>
        /// Checks to see if the class implements INotifyPropertyChanged
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var a = new AretinoAppleJuice();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(a);
        }






    }
}