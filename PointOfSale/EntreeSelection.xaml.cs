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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        private Entree entree;
        
        public EntreeSelection(Entree entree)
        {
            InitializeComponent();
            this.entree = entree;
        }

        public EntreeSelection()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Adds the entree to the order, selects the just added entree in the OrderControl, and returns to the MenuCategorySelection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectBrontowurst(object sender, RoutedEventArgs args)
        {
           if (DataContext is Order order)
            {
                Brontowurst bronto = new Brontowurst();
                order.Add(bronto);
                NavigationService.Navigate(new BrontowurstCustomize());
            }
        }

        /// <summary>
        /// Adds the entree to the order, selects the just added entree in the OrderControl, and returns to the MenuCategorySelection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectDinoNuggets(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                DinoNuggets nug = new DinoNuggets();
                order.Add(nug);
                NavigationService.Navigate(new DinoNuggetsCustomize());
            }
        }

        /// <summary>
        /// Adds the entree to the order, selects the just added entree in the OrderControl, and returns to the MenuCategorySelection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                order.Add(pbj);
                NavigationService.Navigate(new PrehistoricCustomize());
            }
        }

        /// <summary>
        /// Adds the entree to the order, selects the just added entree in the OrderControl, and returns to the MenuCategorySelection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectPterodactylWings(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PterodactylWings pw = new PterodactylWings();
                order.Add(pw);
                NavigationService.Navigate(new PterodactylCustomize());
            }
        }

        /// <summary>
        /// Adds the entree to the order, selects the just added entree in the OrderControl, and returns to the MenuCategorySelection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                SteakosaurusBurger sb = new SteakosaurusBurger();
                order.Add(sb);
                NavigationService.Navigate(new SteakosaurusBurgerCustomize());
            }
        }

        /// <summary>
        /// Adds the entree to the order, selects the just added entree in the OrderControl, and returns to the MenuCategorySelection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectTRexKing(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                TRexKingBurger tr = new TRexKingBurger();
                order.Add(tr);
                NavigationService.Navigate(new TRexKingCustomize());
            }
        }

        /// <summary>
        /// Adds the entree to the order, selects the just added entree in the OrderControl, and returns to the MenuCategorySelection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectVelociWrap(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                VelociWrap vw = new VelociWrap();
                order.Add(vw);
                NavigationService.Navigate(new VelociWrapCustomize());
            }
        }

    } // end of Entree selection xaml.cs
}
