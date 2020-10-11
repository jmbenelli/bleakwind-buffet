/*
* Author: Jakob Benelli
* Class name: MenuComponent.cs
* Purpose: Class used to create the Menu Componenet XAML
*/
using BleakwindBuffet.Data.Entrees;
using PointOfSale.CustoizeDrinks;
using PointOfSale.CustomizeDrinks;
using PointOfSale.CustomizeEntrees;
using PointOfSale.CustomizeSides;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuComponent.xaml
    /// </summary>
    public partial class MenuComponent : UserControl
    {
        /// <summary>
        /// Gets and Sets a new MainWindown mw
        /// </summary>
        public MainWindow mw
        {
            get; set;
        }

        /// <summary>
        /// Constructor that initializes the Menu component
        /// </summary>
        /// <param name="m">Main Window m</param>
        public MenuComponent(MainWindow m)
        {
            InitializeComponent();
            mw = m;
        }

        private void briarhearthBurger_Click(object sender, RoutedEventArgs e)
        {
            mw.SwapScreen(new customizeBriarheartBurger(mw));
        }

        private void doubleDraugr_Click(object sender, RoutedEventArgs e)
        {
            mw.SwapScreen(new customizeDoubleDraugr(mw));
        }

        private void gardenOrcOmelette_Click(object sender, RoutedEventArgs e)
        {
            mw.SwapScreen(new customizeGardenOrcOmelette(mw));
        }

        private void thalmorTriple_Click(object sender, RoutedEventArgs e)
        {
            mw.SwapScreen(new customizeThalmorTriple(mw));
        }

        private void phillyPoacher_Click(object sender, RoutedEventArgs e)
        {
            mw.SwapScreen(new CustomizePhillyPoacher(mw));
        }

        private void vokunSalad_Click(object sender, RoutedEventArgs e)
        {
            mw.SwapScreen(new CustomizeVokunSalad(mw));
        }

        private void friedMiraak_Click(object sender, RoutedEventArgs e)
        {
            mw.SwapScreen(new CustomizeFriedMiraak(mw));
        }

        private void madOtarGrits_Click(object sender, RoutedEventArgs e)
        {
            mw.SwapScreen(new CustomizeMadOtarGrits(mw));
        }

        private void dragonBornWaffleFries_Click(object sender, RoutedEventArgs e)
        {
            mw.SwapScreen(new CustomizeDragonBornWaffleFries(mw));
        }

        private void sailorSoda_Click(object sender, RoutedEventArgs e)
        {
            mw.SwapScreen(new CustomizeSailorSoda(mw));
        }

        private void markarthMilk_Click(object sender, RoutedEventArgs e)
        {
            mw.SwapScreen(new CustomizeMarkarthMilk(mw));
        }

        private void aretinoAppleJuice_Click(object sender, RoutedEventArgs e)
        {
            mw.SwapScreen(new CustomizeAretinoAppleJuice(mw));
        }

        private void candleHearthCoffee_Click(object sender, RoutedEventArgs e)
        {
            mw.SwapScreen(new CustomizeCandlehearthCoffee(mw));
        }

        private void warriorWater_Click(object sender, RoutedEventArgs e)
        {
            mw.SwapScreen(new CustomizeWarriorWater(mw));
        }

        private void smokehouseSkeleton_Click(object sender, RoutedEventArgs e)
        {
            mw.SwapScreen(new customizeSmokehouseSkeleton(mw));

        }

        private void thugsTBone_Click(object sender, RoutedEventArgs e)
        {
            mw.SwapScreen(new CustomizeThugsTBone(mw));
        }
    }
}
