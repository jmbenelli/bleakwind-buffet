/*
 * Author: Jakob Benelli
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Test class for the Double Draugr
    /// </summary>
    public class DoubleDraugrTests
    {
        /// <summary>
        /// Checks to see if the IOrderInterface Class is implemented
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractIOrderInterfaceClass()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.IsAssignableFrom<IOrderItem>(d);
        }

        /// <summary>
        /// Checks to see if the it is an Entree
        /// </summary>
        [Fact]
        public void ShouldBeEntree()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(d);
        }

        /// <summary>
        /// Checks to see if the boolean value for bun is set to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Bun);
        }

        /// <summary>
        /// Checks to see if the boolean value for ketchup is set to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Ketchup);
        }

        /// <summary>
        /// Checks to see if the boolean value for mustard is set to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Mustard);
        }

        /// <summary>
        /// Checks to see if the boolean value for pickle is set to true by defaut
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Pickle);
        }

        /// <summary>
        /// Checks to see if the boolean value for cheese is set to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Cheese);
        }

        /// <summary>
        /// Checks to see if the boolean value for tomato is set to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Tomato);
        }

        /// <summary>
        /// Checks to see if the boolean value for lettuce is set to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Lettuce);
        }

        /// <summary>
        /// Checks to see if the boolean value for mayo is set to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Mayo);
        }

        /// <summary>
        /// Checks to see if the user can set the boolean value for bun to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Bun = true;
            Assert.True(d.Bun);
            d.Bun = false;
            Assert.False(d.Bun);
        }

        /// <summary>
        /// Checks to see if the user can set the boolean value for ketchup to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Ketchup = true;
            Assert.True(d.Ketchup);
            d.Ketchup = false;
            Assert.False(d.Ketchup);
        }

        /// <summary>
        /// Checks to see if the user can set the boolean value for mustard to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Mustard = true;
            Assert.True(d.Mustard);
            d.Mustard = false;
            Assert.False(d.Mustard);
        }

        /// <summary>
        /// Checks to see if the user can set the boolean value for pickle to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Pickle = true;
            Assert.True(d.Pickle);
            d.Pickle = false;
            Assert.False(d.Pickle);
        }

        /// <summary>
        /// Checks to see if the user can set the boolean value for cheese to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Cheese = true;
            Assert.True(d.Cheese);
            d.Cheese = false;
            Assert.False(d.Cheese);
        }

        /// <summary>
        /// Checks to see if the user can set the boolean value for tomato to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Tomato = true;
            Assert.True(d.Tomato);
            d.Tomato = false;
            Assert.False(d.Tomato);
        }

        /// <summary>
        /// Checks to see if the user can set the boolean value for lettuce to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Lettuce = true;
            Assert.True(d.Lettuce);
            d.Lettuce = false;
            Assert.False(d.Lettuce);
        }

        /// <summary>
        /// Checks to see if the user can set the boolean value for mayo to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Mayo = true;
            Assert.True(d.Mayo);
            d.Mayo = false;
            Assert.False(d.Mayo);
        }

        /// <summary>
        /// Checks to see if the correct price is displayed
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.Equal(7.32, d.Price);
        }

        /// <summary>
        /// Checks to see if the correct calories are displayed
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.Equal(843, (int) d.Calories);
        }

        /// <summary>
        /// Checks to see if the correct special instructions are displayed
        /// </summary>
        /// <param name="includeBun">Whether the customer wants a bun or not</param>
        /// <param name="includeKetchup">Whether the customer want ketchup or not</param>
        /// <param name="includeMustard">Whether the customer want mustard or not</param>
        /// <param name="includePickle">Whether the customer want pickle or not</param>
        /// <param name="includeCheese">Whether the customer wants cheese or not</param>
        /// <param name="includeTomato">Whether the customer wants tomato or not</param>
        /// <param name="includeLettuce">Whether the customer wants lettuce or not</param>
        /// <param name="includeMayo">Whether the customer wants mayo or not</param>
        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Bun = includeBun;
            d.Ketchup = includeKetchup;
            d.Mustard = includeMustard;
            d.Pickle = includePickle;
            d.Cheese = includeCheese;
            d.Tomato = includeTomato;
            d.Lettuce = includeLettuce;
            if (!includeBun) Assert.Contains("Hold bun", d.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", d.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", d.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", d.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", d.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", d.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold lettuce", d.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold cheese", d.SpecialInstructions);

        }

        /// <summary>
        /// Checks to see if the correct tostring value is returned
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.Equal("Double Draugr", d.ToString());
        }

        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            var b = new DoubleDraugr();

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
        public void ChangingBunNotifiesBunProperty()
        {
            var b = new DoubleDraugr();

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
            var b = new DoubleDraugr();

            Assert.PropertyChanged(b, "Mustard", () =>
            {
                b.Mustard= true;
            });

            Assert.PropertyChanged(b, "Mustard", () =>
            {
                b.Mustard = false;
            });
        }

        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            var b = new DoubleDraugr();

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
            var b = new DoubleDraugr();

            Assert.PropertyChanged(b, "Cheese", () =>
            {
                b.Cheese = true;
            });

            Assert.PropertyChanged(b, "Cheese", () =>
            {
                b.Cheese = false;
            });
        }

        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var b = new DoubleDraugr();

            Assert.PropertyChanged(b, "Tomato", () =>
            {
                b.Tomato = true;
            });

            Assert.PropertyChanged(b, "Tomato", () =>
            {
                b.Tomato = false;
            });
        }

        [Fact]
        public void ChangingLettuceNotifiesLettuceProperty()
        {
            var b = new DoubleDraugr();

            Assert.PropertyChanged(b, "Lettuce", () =>
            {
                b.Lettuce = true;
            });

            Assert.PropertyChanged(b, "Lettuce", () =>
            {
                b.Lettuce = false;
            });
        }

        [Fact]
        public void ChangingMayopNotifiesMayoProperty()
        {
            var b = new DoubleDraugr();

            Assert.PropertyChanged(b, "Mayo", () =>
            {
                b.Mayo = true;
            });

            Assert.PropertyChanged(b, "Mayo", () =>
            {
                b.Mayo = false;
            });
        }

        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var c = new DoubleDraugr();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(c);
        }

        /// <summary>
        /// Checks to see if the correct Description value is returned
        /// </summary>
        /// <param name="d">The Description return value for the item</param>
        [Theory]
        [InlineData("Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.")]
        public void ShouldReturnCorrectDescription(string d)
        {
            DoubleDraugr aj = new DoubleDraugr();
            Assert.Equal(d, aj.Description);
        }

    }
}