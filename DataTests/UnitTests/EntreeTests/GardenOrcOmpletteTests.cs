/*
 * Author: Jakob Benelli
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Test class for Garden Orc Omelette
    /// </summary>
    public class GardenOrcOmeletteTests
    {
        /// <summary>
        /// Checks to see if the IOrderInterface Class is implemented
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractIOrderInterfaceClass()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(g);
        }

        /// <summary>
        /// Checks to see if the it is an Entree
        /// </summary>
        [Fact]
        public void ShouldBeEntree()
        {
            GardenOrcOmelette c = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(c);
        }

        /// <summary>
        /// Checks to see if the boolean value for broccoli is set to true by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.True(g.Broccoli);
        }

        /// <summary>
        /// Checks to see if the boolean value for mushrooms is set to true by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.True(g.Mushrooms);
        }

        /// <summary>
        /// Checks to see if the boolean value for tomato is set to true by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.True(g.Tomato);
        }

        /// <summary>
        /// Checks to see if the boolean value for cheddar is set to true by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.True(g.Cheddar);
        }

        /// <summary>
        /// Checks to see if the user is able to set the boolean value for broccoli to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            g.Broccoli = true;
            Assert.True(g.Broccoli);
            g.Broccoli = false;
            Assert.False(g.Broccoli);
        }

        /// <summary>
        /// Checks to see if the user is able to set the boolean value for mushrooms to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            g.Mushrooms = true;
            Assert.True(g.Mushrooms);
            g.Mushrooms = false;
            Assert.False(g.Mushrooms);
        }

        /// <summary>
        /// Checks to see if the user is able to set the boolean value for tomato to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            g.Tomato = true;
            Assert.True(g.Tomato);
            g.Tomato = false;
            Assert.False(g.Tomato);
        }

        /// <summary>
        /// Checks to see if the user is able to set the boolean value for cheddar to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            g.Cheddar = true;
            Assert.True(g.Cheddar);
            g.Cheddar = false;
            Assert.False(g.Cheddar);
        }

        /// <summary>
        /// Checks to see if the correct price is returned
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.Equal(4.57, g.Price);
        }

        /// <summary>
        /// Checks to see if the correct calories are returned
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.Equal(404, (int) g.Calories);
        }

        /// <summary>
        /// Checks to see if the correct special instructions are displayed
        /// </summary>
        /// <param name="includeBroccoli">Whether the customer wants broccoli or not</param>
        /// <param name="includeMushrooms">Whether the user want mushrooms or not</param>
        /// <param name="includeTomato">Whether the user wants tomato or not</param>
        /// <param name="includeCheddar">Whether the user wants cheddar or not</param>
        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            g.Broccoli = includeBroccoli;
            g.Mushrooms = includeMushrooms;
            g.Tomato = includeMushrooms;
            g.Cheddar = includeCheddar;
            if (!includeBroccoli) Assert.Contains("Hold broccoli", g.SpecialInstructions);
            if (!includeMushrooms) Assert.Contains("Hold mushrooms", g.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", g.SpecialInstructions);
            if (!includeCheddar) Assert.Contains("Hold cheddar", g.SpecialInstructions);
        }

        /// <summary>
        /// Checks to see if the correct ToString value is returned
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", g.ToString());
        }

        [Fact]
        public void ChangingBroccoliNotifiesBroccoliProperty()
        {
            var g = new GardenOrcOmelette();

            Assert.PropertyChanged(g, "Broccoli", () =>
            {
                g.Broccoli = true;
            });

            Assert.PropertyChanged(g, "Broccoli", () =>
            {
                g.Broccoli = false;
            });
        }

        [Fact]
        public void ChangingMusrhoomsNotifiesMushroomsProperty()
        {
            var g = new GardenOrcOmelette();

            Assert.PropertyChanged(g, "Mushrooms", () =>
            {
                g.Mushrooms = true;
            });

            Assert.PropertyChanged(g, "Mushrooms", () =>
            {
                g.Mushrooms = false;
            });
        }

        [Fact]
        public void ChangingCheddarNotifiesCheddarProperty()
        {
            var g = new GardenOrcOmelette();

            Assert.PropertyChanged(g, "Cheddar", () =>
            {
                g.Cheddar = true;
            });

            Assert.PropertyChanged(g, "Cheddar", () =>
            {
                g.Cheddar = false;
            });
        }

        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var g = new GardenOrcOmelette();

            Assert.PropertyChanged(g, "Tomato", () =>
            {
                g.Tomato = true;
            });

            Assert.PropertyChanged(g, "Tomato", () =>
            {
                g.Tomato = false;
            });
        }
    }
}