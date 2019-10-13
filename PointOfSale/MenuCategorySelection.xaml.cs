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
    /// Interaction logic for MenuCategorySelection.xaml
    /// </summary>
    public partial class MenuCategorySelection : Page
    {
        public MenuCategorySelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Allows XAML to click into the Combo Selection page from the Combo button
        /// </summary>
        /// <param name="sender">Control button the action is for</param>
        /// <param name="args">Data needed to pass to the event handlers</param>
        void SelectCombo(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new ComboSelection());
        }

        /// <summary>
        /// Allows XAML to click into the Entree Selection page from the Entrees button
        /// </summary>
        /// <param name="sender">Control button the action is for</param>
        /// <param name="args">Data needed to pass to the event handlers</param>
        void SelectEntree(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new EntreeSelection());
        }

        /// <summary>
        /// Allows XAML to click into the Drink Selection page from the Drinks button
        /// </summary>
        /// <param name="sender">Control button the action is for</param>
        /// <param name="args">Data needed to pass to the event handlers</param>
        void SelectDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection());
        }

        /// <summary>
        /// Allows XAML to click into the Side Selection page from the Sides button
        /// </summary>
        /// <param name="sender">Control button the action is for</param>
        /// <param name="args">Data needed to pass to the event handlers</param>
        void SelectSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection());
        }
    }
}
