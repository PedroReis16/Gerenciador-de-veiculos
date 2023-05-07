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

namespace Gerenciador_de_veículos.Views
{
    /// <summary>
    /// Interaction logic for VehiclesOptions.xaml
    /// </summary>
    public partial class VehiclesOptions : UserControl
    {
        MainWindow main;
        public VehiclesOptions(MainWindow main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void BtnCar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnBike_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnBus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnTruck_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnPlane_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnWarPlane_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnTrain_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnShip_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnWarShip_Click(object sender, RoutedEventArgs e)
        {

        }

        private void VehicleOption_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            button.Background = new SolidColorBrush(Color.FromRgb(00, 146, 255));
        }

        private void VehicleOptions_MouseLeave(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            button.Background = new SolidColorBrush(Color.FromRgb(00, 177, 255));
        }

        //Mouse Enter
        //Button button = sender as Button;
        //button.Background = new SolidColorBrush(Color.FromRgb(00, 146, 255));

        //Mouse Leave
        //Button button = sender as Button;
        //button.Background = new SolidColorBrush(Color.FromRgb(00, 177, 255));
    }
}
