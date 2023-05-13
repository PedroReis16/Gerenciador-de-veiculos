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
            main.OpenCarView();
        }

        private void BtnBike_Click(object sender, RoutedEventArgs e)
        {
            main.OpenBikeView();
        }

        private void BtnBus_Click(object sender, RoutedEventArgs e)
        {
            main.OpenBusView();
        }

        private void BtnTruck_Click(object sender, RoutedEventArgs e)
        {
            main.OpenTruckView();
        }

        private void BtnPlane_Click(object sender, RoutedEventArgs e)
        {
            main.OpenPlaneView();
        }

        private void btnWarPlane_Click(object sender, RoutedEventArgs e)
        {
            main.OpenWarPlaneView();
        }

        private void BtnTrain_Click(object sender, RoutedEventArgs e)
        {
            main.OpenTrainView();
        }

        private void BtnShip_Click(object sender, RoutedEventArgs e)
        {
            main.OpenShipView();
        }

        private void BtnWarShip_Click(object sender, RoutedEventArgs e)
        {
            main.OpenWarShipView();
        }

        #region Buttons BackGround Events
        private void VehicleOption_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            button.Background = new SolidColorBrush(Color.FromRgb(00, 177, 255));
        }

        private void VehicleOptions_MouseLeave(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            button.Background = new SolidColorBrush(Color.FromRgb(00, 146, 255));
        }
        #endregion
    }
}
