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
using DDDrink = DinoDiner.Menu.Drink;

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

        /// <summary>
        /// Constructor to carry in selected drink data
        /// </summary>
        /// <param name="drink"></param>
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            this.drink = drink;
        }

        private CretaceousCombo combo;
        /// <summary>
        /// Constructor to carry in selected Combo Drink data
        /// </summary>
        public DrinkSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }

        /// <summary>
        /// Add a Done button that will return the Frame to the MenuCategorySelection screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectDone(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Allows XAML to click into the Flavors Selection page from the Flavor button
        /// </summary>
        /// <param name="sender">Control button the action is for</param>
        /// <param name="args">Data needed to pass to the event handlers</param>
        private void SelectFlavor(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if (drink is Sodasaurus soda)
                {
                    NavigationService.Navigate(new FlavorSelection(soda));
                }
            }     
        }


        /// <summary>
        /// This method will make lemon true if Yes is selected, and disabled if No is selected
        /// </summary>
        /// <param name="sender">Control button the action is for</param>
        /// <param name="args">Data needed to pass to the event handlers</param>
        private void OnSelectLemon(object sender, RoutedEventArgs args)
        {
            if (drink is Water w)
            {
                w.AddLemon();

            }
            else if (drink is Tyrannotea tea)
            {
                tea.AddLemon();
            }
        }

        /// <summary>
        /// This method will make Ice true if Yes is selected, and disabled if No is selected
        /// </summary>
        /// <param name="sender">Control button the action is for</param>
        /// <param name="args">Data needed to pass to the event handlers</param>
        private void OnSelectIce(object sender, RoutedEventArgs args)
        {
            if (drink is Tyrannotea tea)
            {
               tea.HoldIce();
            }
            else if (drink is Water w)
            {
               w.HoldIce();
            }
            else if (drink is Sodasaurus soda)
            {
                soda.HoldIce();
            }
            else if (drink is JurassicJava java)
            {
               java.AddIce();
            }
        }

        /// <summary>
        /// Adds sweet to Tyrannotea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectSweet(object sender, RoutedEventArgs args)
        {
            if (drink is Tyrannotea tea)
            {
                tea.Sweet = true;
            }
        }

        /// <summary>
        /// Adds decaf to Jurassic java
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectDecaf(object sender, RoutedEventArgs args)
        {
            if (drink is JurassicJava java)
            {
                java.Decaf = true;
            }
        }

        /// <summary>
        /// clicking a drink button adds the drink to the order, and clicking a size button sets its size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectSodasaurus(object sender, RoutedEventArgs args)
        {
            Flavor.IsEnabled = true;
            if (DataContext is Order order)
            {
                if (combo == null)
                {
                    drink = new Sodasaurus();
                    if (SodaSmall.IsChecked ?? false) drink.Size = DDSize.Small;
                    if (SodaMedium.IsChecked ?? false) drink.Size = DDSize.Medium;
                    if (SodaLarge.IsChecked ?? false) drink.Size = DDSize.Large;
                    order.Add(drink);
                }
                else
                {
                    drink = new Sodasaurus();
                    if (SodaSmall.IsChecked ?? false) drink.Size = DDSize.Small;
                    if (SodaMedium.IsChecked ?? false) drink.Size = DDSize.Medium;
                    if (SodaLarge.IsChecked ?? false) drink.Size = DDSize.Large;
                    this.combo.Drink = drink;
                }

            }
        }

        /// <summary>
        /// clicking a drink button adds the drink to the order, and clicking a size button sets its size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectTyrannotea(object sender, RoutedEventArgs args)
        {
            Flavor.IsEnabled = true;
            if (DataContext is Order order)
            {
                if (combo == null)
                {
                    drink = new Tyrannotea();
                    if (TySmall.IsChecked ?? false) drink.Size = DDSize.Small;
                    if (TyMedium.IsChecked ?? false) drink.Size = DDSize.Medium;
                    if (TyLarge.IsChecked ?? false) drink.Size = DDSize.Large;
                    order.Add(drink);
                    NavigationService.Navigate(new MenuCategorySelection());
                }
                else
                {
                    drink = new Tyrannotea();
                    if (TySmall.IsChecked ?? false) drink.Size = DDSize.Small;
                    if (TyMedium.IsChecked ?? false) drink.Size = DDSize.Medium;
                    if (TyLarge.IsChecked ?? false) drink.Size = DDSize.Large;
                    this.combo.Drink = drink;
                    NavigationService.Navigate(new CustomizeCombo());
                }
               
            }
        }

        /// <summary>
        /// clicking a drink button adds the drink to the order, and clicking a size button sets its size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectJurassicJava(object sender, RoutedEventArgs args)
        {
            Flavor.IsEnabled = true;
            if (DataContext is Order order)
            {
                if (combo == null)
                {
                    drink = new JurassicJava();
                    if (JavaSmall.IsChecked ?? false) drink.Size = DDSize.Small;
                    if (JavaMedium.IsChecked ?? false) drink.Size = DDSize.Medium;
                    if (JavaLarge.IsChecked ?? false) drink.Size = DDSize.Large;
                    order.Add(drink);
                    NavigationService.Navigate(new MenuCategorySelection());
                }
                else
                {
                    drink = new JurassicJava();
                    if (JavaSmall.IsChecked ?? false) drink.Size = DDSize.Small;
                    if (JavaMedium.IsChecked ?? false) drink.Size = DDSize.Medium;
                    if (JavaLarge.IsChecked ?? false) drink.Size = DDSize.Large;
                    this.combo.Drink = drink;
                    NavigationService.Navigate(new CustomizeCombo());
                }
            }
        }

        /// <summary>
        /// clicking a drink button adds the drink to the order, and clicking a size button sets its size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectWater(object sender, RoutedEventArgs args)
        {
            Flavor.IsEnabled = true;
            if (DataContext is Order order)
            {
                if (combo == null)
                {
                    drink = new Water();
                    if (WatSmall.IsChecked ?? false) drink.Size = DDSize.Small;
                    if (WatMedium.IsChecked ?? false) drink.Size = DDSize.Medium;
                    if (WatLarge.IsChecked ?? false) drink.Size = DDSize.Large;
                    order.Add(drink);
                    NavigationService.Navigate(new MenuCategorySelection());
                }
                else
                {
                    drink = new Water();
                    if (WatSmall.IsChecked ?? false) drink.Size = DDSize.Small;
                    if (WatMedium.IsChecked ?? false) drink.Size = DDSize.Medium;
                    if (WatLarge.IsChecked ?? false) drink.Size = DDSize.Large;
                    this.combo.Drink = drink;
                    NavigationService.Navigate(new CustomizeCombo());
                }
            }
        }
        /// <summary>
        /// clicking a drink button adds the drink to the order, and clicking a size button sets its size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeSodasaurusSize(object sender, RoutedEventArgs args)
        {
            if (drink is Sodasaurus)
            {
                if (sender is RadioButton element)
                {
                    drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Content.ToString());
                    NavigationService.Navigate(new MenuCategorySelection());
                }
            }
        }
        /// <summary>
        /// clicking a drink button adds the drink to the order, and clicking a size button sets its size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeTyrannoteaSize(object sender, RoutedEventArgs args)
        {
            if (drink is Tyrannotea)
            {
                if (sender is RadioButton element)
                {
                    drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Content.ToString());
                    NavigationService.Navigate(new MenuCategorySelection());
                }
            }
        }

        /// <summary>
        /// clicking a drink button adds the drink to the order, and clicking a size button sets its size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeJurassicJavaSize(object sender, RoutedEventArgs args)
        {
            if (drink is JurassicJava)
            {
                if (sender is RadioButton element)
                {
                    drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Content.ToString());
                    NavigationService.Navigate(new MenuCategorySelection());
                }
            }
        }

        /// <summary>
        /// clicking a drink button adds the drink to the order, and clicking a size button sets its size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeWaterSize(object sender, RoutedEventArgs args)
        {
            if (drink is Water)
            {
                if (sender is RadioButton element)
                {
                    drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Content.ToString());
                    NavigationService.Navigate(new MenuCategorySelection());
                }
            }
        }


    } // end of DrinkSelection class
}
