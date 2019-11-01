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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {

        /// <summary>
        /// null by default, if data binding-must have an accessor
        /// </summary>
        private Side side;

        /// <summary>
        /// Default
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();

        }

        public SideSelection(Side side)
        {
            InitializeComponent();
            this.side = side;
        }

        private CretaceousCombo combo;
        public SideSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            //this.combo.Side = this.side;
        }

        /// <summary>
        /// Event handler that adds the side to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectFryceritops(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (combo == null)
                {
                    side = new Fryceritops();
                    if (FrySmall.IsChecked ?? false) side.Size = DDSize.Small;
                    if (FryMed.IsChecked ?? false) side.Size = DDSize.Medium;
                    if (FryLarge.IsChecked ?? false) side.Size = DDSize.Large;
                    order.Add(side);
                    NavigationService.Navigate(new MenuCategorySelection());
                }
                else
                {
                    side = new Fryceritops();
                    if (FrySmall.IsChecked ?? false) side.Size = DDSize.Small;
                    if (FryMed.IsChecked ?? false) side.Size = DDSize.Medium;
                    if (FryLarge.IsChecked ?? false) side.Size = DDSize.Large;
                    this.combo.Side = side;
                    NavigationService.Navigate(new CustomizeCombo());
                }
                
            }
        }

        /// <summary>
        /// Event handler that adds the side to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectMeteorMacCheese(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (combo == null)
                {
                    side = new MeteorMacAndCheese();
                    if (MetSmall.IsChecked ?? false) side.Size = DDSize.Small;
                    if (MetMedium.IsChecked ?? false) side.Size = DDSize.Medium;
                    if (MetLarge.IsChecked ?? false) side.Size = DDSize.Large;
                    order.Add(side);
                }
                else
                {
                    side = new MeteorMacAndCheese();
                    if (MetSmall.IsChecked ?? false) side.Size = DDSize.Small;
                    if (MetMedium.IsChecked ?? false) side.Size = DDSize.Medium;
                    if (MetLarge.IsChecked ?? false) side.Size = DDSize.Large;
                    this.combo.Side = side;
                }
                NavigationService.Navigate(new CustomizeCombo());
            }
        }

        /// <summary>
        /// Event handler that adds the side to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectMezzorella(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (combo == null)
                {
                    side = new MezzorellaSticks();
                    if (MezSmall.IsChecked ?? false) side.Size = DDSize.Small;
                    if (MezMedium.IsChecked ?? false) side.Size = DDSize.Medium;
                    if (MezLarge.IsChecked ?? false) side.Size = DDSize.Large;
                    order.Add(side);
                } 
                else
                {
                    side = new MezzorellaSticks();
                    if (MezSmall.IsChecked ?? false) side.Size = DDSize.Small;
                    if (MezMedium.IsChecked ?? false) side.Size = DDSize.Medium;
                    if (MezLarge.IsChecked ?? false) side.Size = DDSize.Large;
                    this.combo.Side = side;
                }
                NavigationService.Navigate(new CustomizeCombo());
            }
        }

        /// <summary>
        /// Event handler that adds the side to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectTriceritots(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (combo == null)
                {
                    side = new Triceritots();
                    if (TriSmall.IsChecked ?? false) side.Size = DDSize.Small;
                    if (TriMedium.IsChecked ?? false) side.Size = DDSize.Medium;
                    if (TriLarge.IsChecked ?? false) side.Size = DDSize.Large;
                    order.Add(side);
                }
                else
                {
                    side = new Triceritots();
                    if (TriSmall.IsChecked ?? false) side.Size = DDSize.Small;
                    if (TriMedium.IsChecked ?? false) side.Size = DDSize.Medium;
                    if (TriLarge.IsChecked ?? false) side.Size = DDSize.Large;
                    this.combo.Side = side;
                }
                NavigationService.Navigate(new CustomizeCombo());
            }
        }

        /// <summary>
        /// Clicking size button sets size of the side and returns to the MenuCategorySelection screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeFryceritopsSize(object sender, RoutedEventArgs args)
        {
            if (side is Fryceritops)
            {
                if (sender is RadioButton element)
                {
                    side.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Content.ToString());
                    NavigationService.Navigate(new MenuCategorySelection());
                }
            }
        }


        /// <summary>
        /// Clicking size button sets size of the side and returns to the MenuCategorySelection screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeMeteorMacCheeseSize(object sender, RoutedEventArgs args)
        {
            if (side is MeteorMacAndCheese)
            {
                if (sender is RadioButton element)
                {
                    side.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Content.ToString());
                    NavigationService.Navigate(new MenuCategorySelection());
                }
            }
        }

        /// <summary>
        /// Clicking size button sets size of the side and returns to the MenuCategorySelection screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeMezzorellaSticksSize(object sender, RoutedEventArgs args)
        {
            if (side is MezzorellaSticks)
            {
                if (sender is RadioButton element)
                {
                    side.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Content.ToString());
                    NavigationService.Navigate(new MenuCategorySelection());
                }
            }
        }

        /// <summary>
        /// Clicking size button sets size of the side and returns to the MenuCategorySelection screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeTriceritotsSize(object sender, RoutedEventArgs args)
        {
            if (side is Triceritots)
            {
                if (sender is RadioButton element)
                {
                    side.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Content.ToString());
                    NavigationService.Navigate(new MenuCategorySelection());
                }
            }
        }

    }// end of SideSelection xaml.cs
}
