/*
 * Author: Jakob Benelli
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    /// <summary>
    /// Test Class for Fried Miraak
    /// </summary>
    public class FriedMiraakTests
    {
        /// <summary>
        /// Checks to see if the size is set to small by default
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            FriedMiraak f = new FriedMiraak();
            Assert.Equal(Size.Small, f.Size);
        }

        /// <summary>
        /// Checks to see if the user is able to set the size to small, medium or large
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            FriedMiraak f = new FriedMiraak();
            f.Size = Size.Large;
            Assert.Equal(Size.Large, f.Size);
            f.Size = Size.Medium;
            Assert.Equal(Size.Medium, f.Size);
            f.Size = Size.Small;
            Assert.Equal(Size.Small, f.Size);
        }

        /// <summary>
        /// Checks to see if the correct user special instructions are returned,
        /// but in this case there are no special instructions for sizes
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            return;
        }

        /// <summary>
        /// Checks to see if the correct price is returned for the correct size
        /// </summary>
        /// <param name="size">The size</param>
        /// <param name="price">The price</param>
        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            FriedMiraak f = new FriedMiraak();
            f.Size = size;
            Assert.Equal(price, f.Price);
        }

        /// <summary>
        /// Checks to see if the correct calories are returned depending on size
        /// </summary>
        /// <param name="size">The size</param>
        /// <param name="calories">The calories</param>
        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            FriedMiraak f = new FriedMiraak();
            f.Size = size;
            Assert.Equal(calories, f.Calories);
        }

        /// <summary>
        /// Checks to see if the correct ToString value is returned
        /// </summary>
        /// <param name="size">The size</param>
        /// <param name="name">The tostring return value</param>
        [Theory]
        [InlineData(Size.Small, "Small Fried Miraak")]
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            FriedMiraak f = new FriedMiraak();
            f.Size = size;
            Assert.Equal(name, f.ToString());
        }
    }
}