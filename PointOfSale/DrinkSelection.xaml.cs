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
using DDSize = DinoDiner.Menu.Size;
using DDFlavor = DinoDiner.Menu.SodasaurusFlavor;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {


        private Drink drink;

        public DrinkSelection()
        {
            InitializeComponent();
        }
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            this.drink = drink;
        }

        /// <summary>
        /// Allows XAML to click into the Flavors Selection page from the Flavor button
        /// </summary>
        /// <param name="sender">Control button the action is for</param>
        /// <param name="args">Data needed to pass to the event handlers</param>
        private void SelectFlavor(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                SodasaurusFlavor flavor = new SodasaurusFlavor();
                order.Add(flavor);
                NavigationService.Navigate(new FlavorSelection(flavor));
            }
        }

        /// <summary>
        /// Allows XAML to click into the Flavor Selection page from the Soda button, enabling it to be true
        /// </summary>
        /// <param name="sender">Control button the action is for</param>
        /// <param name="args">Data needed to pass to the event handlers</param>
        //void SelectSodasaurus(object sender, RoutedEventArgs args)
        //{
        //    Flavor.IsEnabled = true;
        //}

        /// <summary>
        /// Allows XAML to click into the Flavor Selection page from the Tyrannotea button, 
        /// enabling the selectedflavor to be true
        /// </summary>
        /// <param name="sender">Control button the action is for</param>
        /// <param name="args">Data needed to pass to the event handlers</param>
        //void SelectTryannotea(object sender, RoutedEventArgs args)
        //{
        //    Flavor.IsEnabled = true;
        //}

        /// <summary>
        /// Allows XAML to click into the Flavor Selection page from the Jurassic Java button, 
        /// enabling the selected flavor to be true
        /// </summary>
        /// <param name="sender">Control button the action is for</param>
        /// <param name="args">Data needed to pass to the event handlers</param>
        //void SelectJava(object sender, RoutedEventArgs args)
        //{
        //    Flavor.IsEnabled = true;
        //}

        /// <summary>
        /// Allows XAML to click into the Flavor Selection page from the Water button, 
        /// enabling the selected flavor to be true
        /// </summary>
        /// <param name="sender">Control button the action is for</param>
        /// <param name="args">Data needed to pass to the event handlers</param>
        //void SelectWater(object sender, RoutedEventArgs args)
        //{
        //    Flavor.IsEnabled = true;
        //}

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


        private void OnSelectSodasaurus(object sender, RoutedEventArgs args)
        {
            if (drink is Sodasaurus)
            {
                Flavor.IsEnabled = true;
            }
            if (DataContext is Order order)
            {
                drink = new Sodasaurus();
                if (SodaSmall.IsChecked ?? false) drink.Size = DDSize.Small;
                if (SodaMedium.IsChecked ?? false) drink.Size = DDSize.Medium;
                if (SodaLarge.IsChecked ?? false) drink.Size = DDSize.Large;
                order.Add(drink);
            }
        }

        private void OnSelectTyrannotea(object sender, RoutedEventArgs args)
        {
            Flavor.IsEnabled = true;
            if (DataContext is Order order)
            {
                drink = new Tyrannotea();
                if (TySmall.IsChecked ?? false) drink.Size = DDSize.Small;
                if (TyMedium.IsChecked ?? false) drink.Size = DDSize.Medium;
                if (TyLarge.IsChecked ?? false) drink.Size = DDSize.Large;
                order.Add(drink);
            }
        }

        private void OnSelectJurassicJava(object sender, RoutedEventArgs args)
        {
            Flavor.IsEnabled = true;
            if (DataContext is Order order)
            {
                drink = new JurassicJava();
                if (JavaSmall.IsChecked ?? false) drink.Size = DDSize.Small;
                if (JavaMedium.IsChecked ?? false) drink.Size = DDSize.Medium;
                if (JavaLarge.IsChecked ?? false) drink.Size = DDSize.Large;
                order.Add(drink);
            }
        }

        private void OnSelectWater(object sender, RoutedEventArgs args)
        {
            Flavor.IsEnabled = true;
            if (DataContext is Order order)
            {
                drink = new Water();
                if (WatSmall.IsChecked ?? false) drink.Size = DDSize.Small;
                if (WatMedium.IsChecked ?? false) drink.Size = DDSize.Medium;
                if (WatLarge.IsChecked ?? false) drink.Size = DDSize.Large;
                order.Add(drink);
            }
        }

        private void OnChangeSodasaurusSize(object sender, RoutedEventArgs args)
        {
            if (drink is Sodasaurus)
            {
                if (sender is RadioButton element)
                {
                    drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Content.ToString());
                }
            }
        }

        private void OnChangeTyrannoteaSize(object sender, RoutedEventArgs args)
        {
            if (drink is Tyrannotea)
            {
                if (sender is RadioButton element)
                {
                    drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Content.ToString());
                }
            }
        }

        private void OnChangeJurassicJavaSize(object sender, RoutedEventArgs args)
        {
            if (drink is JurassicJava)
            {
                if (sender is RadioButton element)
                {
                    drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Content.ToString());
                }
            }
        }

        private void OnChangeWaterSize(object sender, RoutedEventArgs args)
        {
            if (drink is Water)
            {
                if (sender is RadioButton element)
                {
                    drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Content.ToString());
                }
            }
        }


    } // end of DrinkSelection class
}
