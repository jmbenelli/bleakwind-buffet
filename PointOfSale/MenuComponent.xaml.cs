/*
* Author: Jakob Benelli
* Class name: MenuComponent.cs
* Purpose: Class used to create the Menu Componenet XAML
*/
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
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

        /// <summary>
        /// Click event for briarheart burger that adds it to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void briarhearthBurger_Click(object sender, RoutedEventArgs e)
        {
            BriarheartBurger b = new BriarheartBurger();
            customizeBriarheartBurger c = new customizeBriarheartBurger(mw);
            c.DataContext = b;
            var order = DataContext as Order;
            order.Add(b);
            mw.SwapScreen(c);
        }

        /// <summary>
        /// Click event for double draugr that adds it to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doubleDraugr_Click(object sender, RoutedEventArgs e)
        {
            DoubleDraugr d = new DoubleDraugr();
            customizeDoubleDraugr dd = new customizeDoubleDraugr(mw);
            dd.DataContext = d;
            var order = DataContext as Order;
            order.Add(d);
            mw.SwapScreen(new customizeDoubleDraugr(mw));
        }

        /// <summary>
        /// Click event for garden orc omelette that adds it to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gardenOrcOmelette_Click(object sender, RoutedEventArgs e)
        {
            GardenOrcOmelette d = new GardenOrcOmelette();
            customizeGardenOrcOmelette dd = new customizeGardenOrcOmelette(mw);
            dd.DataContext = d;
            var order = DataContext as Order;
            order.Add(d);
            mw.SwapScreen(new customizeGardenOrcOmelette(mw));
        }

        /// <summary>
        /// Click event for thalmor triple that adds it to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void thalmorTriple_Click(object sender, RoutedEventArgs e)
        { 
            ThalmorTriple d = new ThalmorTriple();
            customizeThalmorTriple dd = new customizeThalmorTriple(mw);
            dd.DataContext = d;
            var order = DataContext as Order;
            order.Add(d);
            mw.SwapScreen(new customizeThalmorTriple(mw));
        }

        /// <summary>
        /// Click event for philly poacher that adds it to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void phillyPoacher_Click(object sender, RoutedEventArgs e)
        {
            PhillyPoacher d = new PhillyPoacher();
            CustomizePhillyPoacher dd = new CustomizePhillyPoacher(mw);
            dd.DataContext = d;
            var order = DataContext as Order;
            order.Add(d);
            mw.SwapScreen(new CustomizePhillyPoacher(mw));
        }

        /// <summary>
        /// Click event for vokun salad that adds it to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void vokunSalad_Click(object sender, RoutedEventArgs e)
        {
            VokunSalad d = new VokunSalad();
            CustomizeVokunSalad dd = new CustomizeVokunSalad(mw);
            dd.DataContext = d;
            var order = DataContext as Order;
            order.Add(d);
            mw.SwapScreen(new CustomizeVokunSalad(mw));
        }

        /// <summary>
        /// Click event for fried miraak that adds it to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void friedMiraak_Click(object sender, RoutedEventArgs e)
        {
            FriedMiraak d = new FriedMiraak();
            CustomizeFriedMiraak dd = new CustomizeFriedMiraak(mw);
            dd.DataContext = d;
            var order = DataContext as Order;
            order.Add(d);
            mw.SwapScreen(new CustomizeFriedMiraak(mw));
        }

        /// <summary>
        /// Click event for mad otar grits that adds it to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void madOtarGrits_Click(object sender, RoutedEventArgs e)
        {
            MadOtarGrits d = new MadOtarGrits();
            CustomizeMadOtarGrits dd = new CustomizeMadOtarGrits(mw);
            dd.DataContext = d;
            var order = DataContext as Order;
            order.Add(d);
            mw.SwapScreen(new CustomizeMadOtarGrits(mw));
        }

        /// <summary>
        /// Click event for dragonborn waffle fries that adds it to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dragonBornWaffleFries_Click(object sender, RoutedEventArgs e)
        {
            DragonbornWaffleFries d = new DragonbornWaffleFries();
            CustomizeDragonBornWaffleFries dd = new CustomizeDragonBornWaffleFries(mw);
            dd.DataContext = d;
            var order = DataContext as Order;
            order.Add(d);
            mw.SwapScreen(new CustomizeDragonBornWaffleFries(mw));
        }

        /// <summary>
        /// Click event for sailor soda that adds it to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sailorSoda_Click(object sender, RoutedEventArgs e)
        {
            SailorSoda d = new SailorSoda();
            CustomizeSailorSoda dd = new CustomizeSailorSoda(mw);
            dd.DataContext = d;
            var order = DataContext as Order;
            order.Add(d);
            mw.SwapScreen(new CustomizeSailorSoda(mw));
        }

        /// <summary>
        /// Click event for markarth milk that adds it to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void markarthMilk_Click(object sender, RoutedEventArgs e)
        {
            MarkarthMilk d = new MarkarthMilk();
            CustomizeMarkarthMilk dd = new CustomizeMarkarthMilk(mw);
            dd.DataContext = d;
            var order = DataContext as Order;
            order.Add(d);
            mw.SwapScreen(new CustomizeMarkarthMilk(mw));
        }

        /// <summary>
        /// Click event for aretino apple juice that adds it to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aretinoAppleJuice_Click(object sender, RoutedEventArgs e)
        {
            AretinoAppleJuice d = new AretinoAppleJuice();
            CustomizeAretinoAppleJuice dd = new CustomizeAretinoAppleJuice(mw);
            dd.DataContext = d;
            var order = DataContext as Order;
            order.Add(d);
            mw.SwapScreen(new CustomizeAretinoAppleJuice(mw));
        }

        /// <summary>
        /// Click event for candlehearth coffee that adds it to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void candleHearthCoffee_Click(object sender, RoutedEventArgs e)
        {
            CandlehearthCoffee d = new CandlehearthCoffee();
            CustomizeCandlehearthCoffee dd = new CustomizeCandlehearthCoffee(mw);
            dd.DataContext = d;
            var order = DataContext as Order;
            order.Add(d);
            mw.SwapScreen(new CustomizeCandlehearthCoffee(mw));
        }

        /// <summary>
        /// Click event for warrior water that adds it to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void warriorWater_Click(object sender, RoutedEventArgs e)
        {
            WarriorWater d = new WarriorWater();
            CustomizeWarriorWater dd = new CustomizeWarriorWater(mw);
            dd.DataContext = d;
            var order = DataContext as Order;
            order.Add(d);
            mw.SwapScreen(new CustomizeWarriorWater(mw));
        }

        /// <summary>
        /// Click event for smokehouse skeleton that adds it to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void smokehouseSkeleton_Click(object sender, RoutedEventArgs e)
        {
            SmokehouseSkeleton d = new SmokehouseSkeleton();
            customizeSmokehouseSkeleton dd = new customizeSmokehouseSkeleton(mw);
            dd.DataContext = d;
            var order = DataContext as Order;
            order.Add(d);
            mw.SwapScreen(new customizeSmokehouseSkeleton(mw));
        }

        /// <summary>
        /// Click event for thugs t bone that adds it to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void thugsTBone_Click(object sender, RoutedEventArgs e)
        {
            ThugsT_Bone d = new ThugsT_Bone();
            CustomizeThugsTBone dd = new CustomizeThugsTBone(mw);
            dd.DataContext = d;
            var order = DataContext as Order;
            order.Add(d);
            mw.SwapScreen(new CustomizeThugsTBone(mw));
        }

    }
}
