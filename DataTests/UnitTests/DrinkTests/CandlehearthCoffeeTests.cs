/*
 * Author: Jakob Benelli
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// Test Class for the Candlehearth Coffee
    /// </summary>
    public class CandlehearthCoffeeTests
    {
        /// <summary>
        /// Checks to see if the default boolean value for ice is false
        /// </summary>
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            Assert.False(c.Ice);
        }

        /// <summary>
        /// Checks to see if the default boolean value for decaf is false
        /// </summary>
        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            Assert.False(c.Decaf);
        }

        /// <summary>
        /// Checks to see if the default boolean value for cream is false
        /// </summary>
        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            Assert.False(c.RoomForCream);
        }

        /// <summary>
        /// Checks to see if the default size is false
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            Assert.Equal(Size.Small, c.Size);
        }

        /// <summary>
        /// Checks to see if the user is able to set the boolean value of ice to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            c.Ice = true;
            Assert.True(c.Ice);
            c.Ice = false;
            Assert.False(c.Ice);
        }

        /// <summary>
        /// Checks to see if the user is able to set the boolean value of decaf to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            c.Decaf = true;
            Assert.True(c.Decaf);
            c.Decaf = false;
            Assert.False(c.Decaf);
        }

        /// <summary>
        /// Checks to see if the user is able to set the boolean value of cream to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            c.RoomForCream = true;
            Assert.True(c.RoomForCream);
            c.RoomForCream = false;
            Assert.False(c.RoomForCream);
        }

        /// <summary>
        /// Checks to see if the user is able to select a size of small, medium, or large
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            c.Size = Size.Large;
            Assert.Equal(Size.Large, c.Size);
            c.Size = Size.Medium;
            Assert.Equal(Size.Medium, c.Size);
            c.Size = Size.Small;
            Assert.Equal(Size.Small, c.Size);
        }

        /// <summary>
        /// Checks to see if the correct price matches the correct size
        /// </summary>
        /// <param name="size">The size of the coffee</param>
        /// <param name="price">The price of the coffee</param>
        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            c.Size = size;
            Assert.Equal(price, c.Price);
        }

        /// <summary>
        /// Checks to see if the correct calories matches with the correct size
        /// </summary>
        /// <param name="size">The size of the coffee</param>
        /// <param name="cal">The calories of the coffee</param>
        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            c.Size = size;
            Assert.Equal(cal, c.Calories);
        }

        /// <summary>
        /// Checks to see if the customers correct special instructions are displayed
        /// </summary>
        /// <param name="includeIce">Whether the customer wants ice or not</param>
        /// <param name="includeCream">Whether the customer want cream or not</param>
        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            c.Ice = includeIce;
            c.RoomForCream = includeCream;
            if (!includeIce) Assert.Contains("Add ice", c.SpecialInstructions);
            if (!includeCream) Assert.Contains("Add cream", c.SpecialInstructions);
        }

        /// <summary>
        /// Checks to see if the correct ToString value is displayed
        /// </summary>
        /// <param name="decaf">Whether the customer wants decaf or not</param>
        /// <param name="size">The size of the coffee</param>
        /// <param name="name">The tostring return value of the coffee</param>
        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            c.Size = size;
            c.Decaf = decaf;
            if (decaf)
            {
                Assert.Equal(name, c.ToString());
            }
            else Assert.Equal(name, c.ToString());
        }
    }
}
