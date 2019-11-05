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
    /// Interaction logic for CustomizeDinoNuggets.xaml
    /// </summary>
    public partial class CustomizeDinoNuggets : Page
    {

        private DinoNuggets dn;

        public CustomizeDinoNuggets(DinoNuggets dn)
        {
            InitializeComponent();
            this.dn = dn;
        }

        /// <summary>
        /// Implements selected method from the original class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnAddNuggets(object sender, RoutedEventArgs args)
        {
            this.dn.AddNugget();
        }

        /// <summary>
        /// Goes back to previously selected page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
            //from entree to menu
            //for combo go back to combo
            //for flavor go back to drink
        }
    }
}
