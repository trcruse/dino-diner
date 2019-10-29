using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;
using DDFlavor = DinoDiner.Menu.SodasaurusFlavor;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {

        private Sodasaurus soda;

        public FlavorSelection(Sodasaurus soda)
        {
            InitializeComponent();
            this.soda = soda;
        }

        /// <summary>
        /// Clicking on of the flavor buttons applies the flavor to the current drink 
        /// and returns to the drink selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectCherryFlavor(object sender, RoutedEventArgs args)
        {
            soda.Flavor = SodasaurusFlavor.Cherry;
            NavigationService.Navigate(new DrinkSelection());
        }

        /// <summary>
        /// Clicking on of the flavor buttons applies the flavor to the current drink 
        /// and returns to the drink selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectLimeFlavor(object sender, RoutedEventArgs args)
        {
            soda.Flavor = SodasaurusFlavor.Cherry;
            NavigationService.Navigate(new DrinkSelection());
        }

        /// <summary>
        /// Clicking on of the flavor buttons applies the flavor to the current drink 
        /// and returns to the drink selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectChocolateFlavor(object sender, RoutedEventArgs args)
        {
            soda.Flavor = SodasaurusFlavor.Chocolate;
            NavigationService.Navigate(new DrinkSelection());
        }

        /// <summary>
        /// Clicking on of the flavor buttons applies the flavor to the current drink 
        /// and returns to the drink selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectColaFlavor(object sender, RoutedEventArgs args)
        {
            soda.Flavor = SodasaurusFlavor.Cola;
            NavigationService.Navigate(new DrinkSelection());
        }

        /// <summary>
        /// Clicking on of the flavor buttons applies the flavor to the current drink 
        /// and returns to the drink selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectOrangeFlavor(object sender, RoutedEventArgs args)
        {
            soda.Flavor = SodasaurusFlavor.Orange;
            NavigationService.Navigate(new DrinkSelection());
        }

        /// <summary>
        /// Clicking on of the flavor buttons applies the flavor to the current drink 
        /// and returns to the drink selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectVanillaFlavor(object sender, RoutedEventArgs args)
        {
            soda.Flavor = SodasaurusFlavor.Vanilla;
            NavigationService.Navigate(new DrinkSelection());
        }

        /// <summary>
        /// Clicking on of the flavor buttons applies the flavor to the current drink 
        /// and returns to the drink selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectRootBeerFlavor(object sender, RoutedEventArgs args)
        {
            soda.Flavor = SodasaurusFlavor.RootBeer;
            NavigationService.Navigate(new DrinkSelection());
        }


    } //  end of flavorselection xaml.cs
}
