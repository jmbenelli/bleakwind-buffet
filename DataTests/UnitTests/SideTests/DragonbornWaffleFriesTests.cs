/*
 * Author: Jakob Benelli
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    /// <summary>
    /// Test class for the Dragonborn Waffle Fries
    /// </summary>
    public class DragonbornWaffleFriesTests
    {
        /// <summary>
        /// Checks to see if the IOrderInterface Class is implemented
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractIOrderInterfaceClass()
        {
            DragonbornWaffleFries d = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<IOrderItem>(d);
        }

        /// <summary>
        /// Checks to see if it is a Side
        /// </summary>
        [Fact]
        public void ShouldBeSide()
        {
            DragonbornWaffleFries d = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(d);
        }

        /// <summary>
        /// Checks to see if the size is set to small by default
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWaffleFries d = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, d.Size);
        }

        /// <summary>
        /// Checks to see if the user is able to set the size to small, medium, or large
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWaffleFries d = new DragonbornWaffleFries();
            d.Size = Size.Large;
            Assert.Equal(Size.Large, d.Size);
            d.Size = Size.Medium;
            Assert.Equal(Size.Medium, d.Size);
            d.Size = Size.Small;
            Assert.Equal(Size.Small, d.Size);
        }

        /// <summary>
        /// Checks to see if the users special instructions are displayed, but in this case
        /// the sides do not have any special instructions
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            return;
        }

        /// <summary>
        /// Checks to see if the correct price matches with the correct size
        /// </summary>
        /// <param name="size">The size of the fries</param>
        /// <param name="price">The price of the fries</param>
        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonbornWaffleFries d = new DragonbornWaffleFries();
            d.Size = size;
            Assert.Equal(price, d.Price);
        }

        /// <summary>
        /// Checks to see if the correct calories match with the correct size
        /// </summary>
        /// <param name="size">The size of the fries</param>
        /// <param name="calories">The calories of the fries</param>
        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFries d = new DragonbornWaffleFries();
            d.Size = size;
            Assert.Equal(calories, d.Calories);
        }

        /// <summary>
        /// Checks to see if the correct ToString value is returned
        /// </summary>
        /// <param name="size">The size of the fries</param>
        /// <param name="name">The toString return value</param>
        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWaffleFries d = new DragonbornWaffleFries();
            d.Size = size;
            Assert.Equal(name, d.ToString());
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void SizeChangeNotifiesSizeProperty(Size s)
        {
            DragonbornWaffleFries a = new DragonbornWaffleFries();
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
            DragonbornWaffleFries a = new DragonbornWaffleFries();
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
            DragonbornWaffleFries a = new DragonbornWaffleFries();
            Assert.PropertyChanged(a, "Calories", () =>
            {
                a.Size = s;
            });
        }
    }
}