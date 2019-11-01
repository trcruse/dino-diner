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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        public ComboSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Allows XAML to click into the Customize Combo Selection page from the buttons of selectable Entrees
        /// </summary>
        /// <param name="sender">Control button the action is for</param>
        /// <param name="args">Data needed to pass to the event handlers</param>
        void SelectCustomizeCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Button b = (Button)sender;
                if (b.Name.Equals("Brontowurst"))
                {
                    CretaceousCombo cc = new CretaceousCombo(new Brontowurst());
                    order.Add(cc);
                    NavigationService.Navigate(new CustomizeCombo(cc));
                }
                else if (b.Name.Equals("DinoNuggets"))
                {
                    order.Add(new CretaceousCombo(new DinoNuggets()));
                }
                else if (b.Name.Equals("Steakosaurus"))
                {
                    order.Add(new CretaceousCombo(new SteakosaurusBurger()));
                }
                else if (b.Name.Equals("TRexKingBurger"))
                {
                    order.Add(new CretaceousCombo(new TRexKingBurger()));
                }
                else if (b.Name.Equals("pbj"))
                {
                    order.Add(new CretaceousCombo(new PrehistoricPBJ()));
                }
                else if (b.Name.Equals("PterodactylWings"))
                {
                    order.Add(new CretaceousCombo(new PterodactylWings()));
                }
                else if (b.Name.Equals("VelociWrap"))
                {
                    order.Add(new CretaceousCombo(new VelociWrap()));
                }
            }
            
        }







        
    }
}
