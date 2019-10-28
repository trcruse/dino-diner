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
    /// Interaction logic for CustomizePrehistoricPBJ.xaml
    /// </summary>
    public partial class CustomizePrehistoricPBJ : Page
    {

        private PrehistoricPBJ pbj;


        public CustomizePrehistoricPBJ(PrehistoricPBJ pbj)
        {
            InitializeComponent();
            this.pbj = pbj;
        }


        private void OnHoldPeanutButter(object sender, RoutedEventArgs args)
        {
            this.pbj.HoldPeanutButter();

        }

        private void OnHoldJelly(object sender, RoutedEventArgs args)
        {
            this.pbj.HoldJelly();
        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
            //from entree to menu
            //for combo go back to combo
            //for flavor go back to drink
        }
    }
}
