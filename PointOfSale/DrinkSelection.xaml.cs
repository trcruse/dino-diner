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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public DrinkSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Allows XAML to click into the Flavors Selection page from the Flavor button
        /// </summary>
        /// <param name="sender">Control button the action is for</param>
        /// <param name="args">Data needed to pass to the event handlers</param>
        void SelectFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }

        /// <summary>
        /// Allows XAML to click into the Flavor Selection page from the Soda button, enabling it to be true
        /// </summary>
        /// <param name="sender">Control button the action is for</param>
        /// <param name="args">Data needed to pass to the event handlers</param>
        void SelectSodasaurus(object sender, RoutedEventArgs args)
        {
            Flavor.IsEnabled = true;
        }

        /// <summary>
        /// Allows XAML to click into the Flavor Selection page from the Tyrannotea button, 
        /// enabling the selectedflavor to be true
        /// </summary>
        /// <param name="sender">Control button the action is for</param>
        /// <param name="args">Data needed to pass to the event handlers</param>
        void SelectTryannotea(object sender, RoutedEventArgs args)
        {
            Flavor.IsEnabled = true;
        }

        /// <summary>
        /// Allows XAML to click into the Flavor Selection page from the Jurassic Java button, 
        /// enabling the selected flavor to be true
        /// </summary>
        /// <param name="sender">Control button the action is for</param>
        /// <param name="args">Data needed to pass to the event handlers</param>
        void SelectJava(object sender, RoutedEventArgs args)
        {
            Flavor.IsEnabled = true;
        }

        /// <summary>
        /// Allows XAML to click into the Flavor Selection page from the Water button, 
        /// enabling the selected flavor to be true
        /// </summary>
        /// <param name="sender">Control button the action is for</param>
        /// <param name="args">Data needed to pass to the event handlers</param>
        void SelectWater(object sender, RoutedEventArgs args)
        {
            Flavor.IsEnabled = true;
        }

        /// <summary>
        /// This method will make lemon true if Yes is selected, and disabled if No is selected
        /// </summary>
        /// <param name="sender">Control button the action is for</param>
        /// <param name="args">Data needed to pass to the event handlers</param>
        void SelectLemon(object sender, RoutedEventArgs args)
        {
            
        }

        /// <summary>
        /// This method will make lemon true if Yes is selected, and disabled if No is selected
        /// </summary>
        /// <param name="sender">Control button the action is for</param>
        /// <param name="args">Data needed to pass to the event handlers</param>
        void SelectIce(object sender, RoutedEventArgs args)
        {
            
        }
    }
}
