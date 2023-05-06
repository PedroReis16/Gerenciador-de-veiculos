using Gerenciador_de_veículos.Views;
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

namespace Gerenciador_de_veículos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region Notification Button Events
        private void BtnNotification_MouseEnter(object sender, MouseEventArgs e)
        {
            NotificationsGrid.Visibility = Visibility.Visible;
        }

        private void BtnNotification_MouseLeave(object sender, MouseEventArgs e)
        {
            NotificationsGrid.Visibility = Visibility.Collapsed;
        }
        #endregion

        #region Initial Buttons Events
        private void BtnVehicles_Click(object sender, RoutedEventArgs e)
        {
            BtnBack.Visibility = Visibility.Visible;
            VehiclesOptions vehiclesOptions = new VehiclesOptions(this);

            VehiclesOptions.Children.Clear();
            VehiclesOptions.Children.Add(vehiclesOptions);
            VehiclesOptions.Visibility = Visibility.Visible;
            InitialButtons.Visibility = Visibility.Collapsed;
            
        }
        private void btnToll_Click(object sender, RoutedEventArgs e)
        {//Evento do botão pedágio

        }


        private void btnActions_Click(object sender, RoutedEventArgs e)
        {

        }
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            if(VehiclesOptions.Visibility == Visibility.Visible)
            {
                VehiclesOptions.Children.Clear();
                VehiclesOptions.Visibility = Visibility.Collapsed;
                InitialButtons.Visibility = Visibility.Visible;
            }
        }
        #endregion
    }
}
