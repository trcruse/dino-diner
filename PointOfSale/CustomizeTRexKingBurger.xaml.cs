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
    /// Interaction logic for CustomizeTRexKingBurger.xaml
    /// </summary>
    public partial class CustomizeTRexKingBurger : Page
    {
        private TRexKingBurger tb;

        public CustomizeTRexKingBurger(TRexKingBurger tb)
        {
            InitializeComponent();
            this.tb = tb;
        }

        /// <summary>
        /// Implements selected method from the original class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            this.tb.HoldBun();

        }

        /// <summary>
        /// Implements selected method from the original class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            this.tb.HoldLettuce();
        }

        /// <summary>
        /// Implements selected method from the original class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldTomato(object sender, RoutedEventArgs args)
        {
            this.tb.HoldTomato();
        }

        /// <summary>
        /// Implements selected method from the original class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            this.tb.HoldOnion();
        }

        /// <summary>
        /// Implements selected method from the original class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            this.tb.HoldPickle();
        }

        /// <summary>
        /// Implements selected method from the original class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            this.tb.HoldKetchup();
        }

        /// <summary>
        /// Implements selected method from the original class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            this.tb.HoldMustard();
        }

        /// <summary>
        /// Implements selected method from the original class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldMayo(object sender, RoutedEventArgs args)
        {
            this.tb.HoldMayo();
        }

        /// <summary>
        /// Goes back to previous selected page
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
