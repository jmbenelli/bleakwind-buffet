/*
 * Author: Jakob Benelli
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Test class for the Thalmor Triple
    /// </summary>
    public class ThalmorTripleTests
    {
        /// <summary>
        /// Checks to see if the IOrderInterface Class is implemented
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractIOrderInterfaceClass()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.IsAssignableFrom<IOrderItem>(t);
        }

        /// <summary>
        /// Checks to see if the it is an Entree
        /// </summary>
        [Fact]
        public void ShouldBeEntree()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(t);
        }

        /// <summary>
        /// Checks to see if the boolean value for bun is true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Bun);
        }

        /// <summary>
        /// Checks to see if the boolean value for ketchup is true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Ketchup);
        }

        /// <summary>
        /// Checks to see if the boolean value for mustard is true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Mustard);
        }

        /// <summary>
        /// Checks to see if the boolean value for pickle is true by default
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Pickle);
        }

        /// <summary>
        /// Checks to see if the boolean value for cheese is true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Cheese);
        }

        /// <summary>
        /// Checks to see if the boolean value for tomato is true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Tomato);
        }

        /// <summary>
        /// Checks to see if the boolean value for lettuce is true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Lettuce);
        }

        /// <summary>
        /// Checks to see if the boolean value for mayo is true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Mayo);
        }

        /// <summary>
        /// Checks to see if the boolean value for bacon is true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Bacon);
        }

        /// <summary>
        /// Checks to see if the boolean value for egg is true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Egg);
        }

        /// <summary>
        /// Checks to see if the user is able to set the boolean value for bun to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Bun = true;
            Assert.True(t.Bun);
            t.Bun = false;
            Assert.False(t.Bun);
        }

        /// <summary>
        /// Checks to see if the user is able to set the boolean value for ketchup to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Ketchup = true;
            Assert.True(t.Ketchup);
            t.Ketchup = false;
            Assert.False(t.Ketchup);
        }

        /// <summary>
        /// Checks to see if the user is able to set the boolean value for mustard to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Mustard = true;
            Assert.True(t.Mustard);
            t.Mustard = false;
            Assert.False(t.Mustard);
        }

        /// <summary>
        /// Checks to see if the user is able to set the boolean value for pickle to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Pickle = true;
            Assert.True(t.Pickle);
            t.Pickle = false;
            Assert.False(t.Pickle);
        }

        /// <summary>
        /// Checks to see if the user is able to set the boolean value for cheese to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Cheese = true;
            Assert.True(t.Cheese);
            t.Cheese = false;
            Assert.False(t.Cheese);
        }

        /// <summary>
        /// Checks to see if the user is able to set the boolean value for tomato to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Tomato = true;
            Assert.True(t.Tomato);
            t.Tomato = false;
            Assert.False(t.Tomato);
        }

        /// <summary>
        /// Checks to see if the user is able to set the boolean value for lettuce to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Lettuce = true;
            Assert.True(t.Lettuce);
            t.Lettuce = false;
            Assert.False(t.Lettuce);
        }

        /// <summary>
        /// Checks to see if the user is able to set the boolean value for mayo to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Mayo = true;
            Assert.True(t.Mayo);
            t.Mayo = false;
            Assert.False(t.Mayo);
        }

        /// <summary>
        /// Checks to see if the user is able to set the boolean value for bacon to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Bacon = true;
            Assert.True(t.Bacon);
            t.Bacon = false;
            Assert.False(t.Bacon);
        }

        /// <summary>
        /// Checks to see if the user is able to set the boolean value for egg to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Egg = true;
            Assert.True(t.Egg);
            t.Egg = false;
            Assert.False(t.Egg);
        }

        /// <summary>
        /// Checks to see if the correct price is returned
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.Equal(8.32, t.Price);
        }

        /// <summary>
        /// Checks to see if the correct calories are returned
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.Equal(943, (int) t.Calories);
        }

        /// <summary>
        /// Checks to see if the correct user special instructions are displayed
        /// </summary>
        /// <param name="includeBun">Whether or not the user wants a bun</param>
        /// <param name="includeKetchup">Whether or not the user wants ketchup</param>
        /// <param name="includeMustard">Whether or not the user wants mustard</param>
        /// <param name="includePickle">Whether or not the user wants pickle</param>
        /// <param name="includeCheese">Whether or not the user wants cheese</param>
        /// <param name="includeTomato">Whether or not the user wants tomato</param>
        /// <param name="includeLettuce">Whether or not the user wants lettuce</param>
        /// <param name="includeMayo">Whether or not the user wants mayo</param>
        /// <param name="includeBacon">Whether or not the user wants bacon</param>
        /// <param name="includeEgg">Whether or not the user wants egg</param>
        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Bun = includeBun;
            t.Ketchup = includeKetchup;
            t.Mustard = includeMustard;
            t.Pickle = includePickle;
            t.Cheese = includeCheese;
            t.Tomato = includeTomato;
            t.Lettuce = includeLettuce;
            t.Mayo = includeMayo;
            t.Bacon = includeBacon;
            t.Egg = includeEgg;
            if (!includeBun) Assert.Contains("Hold bun", t.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", t.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", t.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", t.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", t.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", t.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold lettuce", t.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold mayo", t.SpecialInstructions);
            if (!includeBacon) Assert.Contains("Hold bacon", t.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold egg", t.SpecialInstructions);
            //else Assert.Empty(t.SpecialInstructions);
        }

        /// <summary>
        /// Checks to see if the correct ToString value is displayed
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", t.ToString());
        }

        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            var s = new ThalmorTriple();

            Assert.PropertyChanged(s, "Ketchup", () =>
            {
                s.Ketchup = true;
            });

            Assert.PropertyChanged(s, "Ketchup", () =>
            {
                s.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingBunNotifiesKBunProperty()
        {
            var s = new ThalmorTriple();

            Assert.PropertyChanged(s, "Bun", () =>
            {
                s.Bun = true;
            });

            Assert.PropertyChanged(s, "Bun", () =>
            {
                s.Bun = false;
            });
        }

        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            var s = new ThalmorTriple();

            Assert.PropertyChanged(s, "Mustard", () =>
            {
                s.Mustard = true;
            });

            Assert.PropertyChanged(s, "Mustard", () =>
            {
                s.Mustard = false;
            });
        }

        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            var s = new ThalmorTriple();

            Assert.PropertyChanged(s, "Pickle", () =>
            {
                s.Pickle = true;
            });

            Assert.PropertyChanged(s, "Pickle", () =>
            {
                s.Pickle = false;
            });
        }

        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            var s = new ThalmorTriple();

            Assert.PropertyChanged(s, "Cheese", () =>
            {
                s.Cheese = true;
            });

            Assert.PropertyChanged(s, "Cheese", () =>
            {
                s.Cheese = false;
            });
        }

        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var s = new ThalmorTriple();

            Assert.PropertyChanged(s, "Tomato", () =>
            {
                s.Tomato = true;
            });

            Assert.PropertyChanged(s, "Tomato", () =>
            {
                s.Tomato = false;
            });
        }

        [Fact]
        public void ChangingLetttuceNotifiesLettuceProperty()
        {
            var s = new ThalmorTriple();

            Assert.PropertyChanged(s, "Lettuce", () =>
            {
                s.Lettuce = true;
            });

            Assert.PropertyChanged(s, "Lettuce", () =>
            {
                s.Lettuce = false;
            });
        }

        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var c = new ThalmorTriple();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(c);
        }
    }
}