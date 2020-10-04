/*
 * Author: Jakob Benelli
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Test class for the Briarheart Burger
    /// </summary>
    public class BriarheartBurgerTests
    {
        /// <summary>
        /// Checks to see if the IOrderInterface Class is implemented
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractIOrderInterfaceClass()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(b);
        }

        /// <summary>
        /// Checks to see if the it is an Entree
        /// </summary>
        [Fact]
        public void ShouldBeEntree()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(b);
        }

        /// <summary>
        /// Checks to see if the boolean value for bun is set to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Bun);
        }

        /// <summary>
        /// Checks to see if the boolean value for ketchup is true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Ketchup);
        }

        /// <summary>
        /// Checks to see if the boolean value for mustard is set to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Mustard);
        }

        /// <summary>
        /// Checks to see if the boolean value for pickle is set to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Pickle);
        }

        /// <summary>
        /// Checks to see if the boolean value for cheese is set to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Cheese);
        }

        /// <summary>
        /// Checks to see if the user is able to set the boolean value for bun to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Bun = true;
            Assert.True(b.Bun);
            b.Bun = false;
            Assert.False(b.Bun);
        }

        /// <summary>
        /// Checks to see if the user is ale to set the boolean value for ketchup to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Ketchup = true;
            Assert.True(b.Ketchup);
            b.Ketchup = false;
            Assert.False(b.Ketchup);
        }

        /// <summary>
        /// Checks to see if the user is ale to set the boolean value for mustard to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Mustard = true;
            Assert.True(b.Mustard);
            b.Mustard = false;
            Assert.False(b.Mustard);
        }

        /// <summary>
        /// Checks to see if the user is ale to set the boolean value for pickle to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Pickle = true;
            Assert.True(b.Pickle);
            b.Pickle = false;
            Assert.False(b.Pickle);
        }

        /// <summary>
        /// Checks to see if the user is ale to set the boolean value for cheese to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Cheese = true;
            Assert.True(b.Cheese);
            b.Cheese = false;
            Assert.False(b.Cheese);
        }

        /// <summary>
        /// Checks to see if the correct price is returned
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.Equal(6.32, b.Price);
        }

        /// <summary>
        /// Checks to see if the correct calories are returned
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.Equal(743, (int) b.Calories);
        }

        /// <summary>
        /// Checks to see if the correct special instructions are displayed
        /// </summary>
        /// <param name="includeBun">Whether the customer wants a bun or not</param>
        /// <param name="includeKetchup">Whether the customer wants ketchup or not</param>
        /// <param name="includeMustard">Whether the customer wants mustard or not</param>
        /// <param name="includePickle">Whether the customer wants pickles or not</param>
        /// <param name="includeCheese">Whether the customer wants cheese or not</param>
        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Bun = includeBun;
            b.Ketchup = includeKetchup;
            b.Mustard = includeMustard;
            b.Pickle = includePickle;
            b.Cheese = includeCheese;
            if (!includeBun) Assert.Contains("Hold bun", b.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", b.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", b.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", b.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", b.SpecialInstructions);

        }

        /// <summary>
        /// Checks to see if the correct ToString value is returned
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", b.ToString());
        }

        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            var b = new BriarheartBurger();

            Assert.PropertyChanged(b, "Ketchup", () =>
            {
                b.Ketchup = true;
            });

            Assert.PropertyChanged(b, "Ketchup", () =>
            {
                b.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingBunpNotifiesBunProperty()
        {
            var b = new BriarheartBurger();

            Assert.PropertyChanged(b, "Bun", () =>
            {
                b.Bun = true;
            });

            Assert.PropertyChanged(b, "Bun", () =>
            {
                b.Bun = false;
            });
        }

        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            var b = new BriarheartBurger();

            Assert.PropertyChanged(b, "Mustard", () =>
            {
                b.Mustard = true;
            });

            Assert.PropertyChanged(b, "Mustard", () =>
            {
                b.Mustard = false;
            });
        }

        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            var b = new BriarheartBurger();

            Assert.PropertyChanged(b, "Pickle", () =>
            {
                b.Pickle = true;
            });

            Assert.PropertyChanged(b, "Pickle", () =>
            {
                b.Pickle = false;
            });
        }

        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            var b = new BriarheartBurger();

            Assert.PropertyChanged(b, "Cheese", () =>
            {
                b.Cheese = true;
            });

            Assert.PropertyChanged(b, "Cheese", () =>
            {
                b.Cheese = false;
            });
        }




    }
}