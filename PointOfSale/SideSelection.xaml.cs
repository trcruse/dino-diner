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


        public SideSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler that Adds new items to Fryceritops
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectFryceritops(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new Fryceritops();
                if (FrySmall.IsChecked ?? false) side.Size = DinoDiner.Menu.Size.Small;
                if (FryMed.IsChecked ?? false) side.Size = DinoDiner.Menu.Size.Medium;
                if (FryLarge.IsChecked ?? false) side.Size = DinoDiner.Menu.Size.Large;
                order.Items.Add(side);
            }
        }

        private void OnSelectMeteorMacCheese(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new MeteorMacAndCheese();
                order.Items.Add(side);
            }
        }

        private void OnSelectMezzorella(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new MezzorellaSticks();
                order.Items.Add(side);
            }
        }

        private void OnSelectTriceritots(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new Triceritots();
                order.Items.Add(side);
            }
        }

        /// <summary>
        /// Event handler for all buttons 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {

            //using radio button
            if (sender is FrameworkElement element)
            {
               side.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
                //side.Size = Size.Small;
            }

        }

        private void OnChangeFryceritopsSize(object sender, RoutedEventArgs args)
        {

            //using radio button
            if (sender is FrameworkElement element)
            {
                if (side is Fryceritops)
                {
                    side.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());

                }
                //side.Size = Size.Small;
            }

        }







    }
}
