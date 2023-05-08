using Gerenciador_de_veículos.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace Gerenciador_de_veículos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer actionTimer;

        public MainWindow()
        {
            InitializeComponent();

            InitializeTimer();
            actionTimer.Start();
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

            VehiclesGrid.Children.Clear();
            VehiclesGrid.Children.Add(vehiclesOptions);
            VehiclesGrid.Visibility = Visibility.Visible;
            InitialButtons.Visibility = Visibility.Collapsed;

        }
        private void btnToll_Click(object sender, RoutedEventArgs e)
        {//Evento do botão pedágio

        }

        private void btnActions_Click(object sender, RoutedEventArgs e)
        {
            btnNotification.Visibility = Visibility.Collapsed;
            BtnBack.Visibility = Visibility.Visible;
            ActionsOptions actionsOptions = new ActionsOptions(this);

            ActionGrid.Children.Clear();
            ActionGrid.Children.Add(actionsOptions);
            ActionGrid.Visibility = Visibility.Visible;
            InitialButtons.Visibility = Visibility.Collapsed;
        }
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            if (VehiclesGrid.Visibility == Visibility.Visible)
            {
                VehiclesGrid.Children.Clear();
                VehiclesGrid.Visibility = Visibility.Collapsed;
                InitialButtons.Visibility = Visibility.Visible;
                BtnBack.Visibility = Visibility.Collapsed;
            }
            if(ActionGrid.Visibility == Visibility.Visible)
            {
                ActionGrid.Children.Clear();
                ActionGrid.Visibility = Visibility.Collapsed;
                InitialButtons.Visibility = Visibility.Visible;
                BtnBack.Visibility = Visibility.Collapsed;
                btnNotification.Visibility = Visibility.Visible;
            }
        }
        #endregion
        private void InitializeTimer()
        {
            actionTimer = new DispatcherTimer();
            actionTimer.Tick += new EventHandler(ActionTimer);
            actionTimer.Interval = TimeSpan.FromSeconds(1);
        }
        private void ActionTimer(object sender, EventArgs e)
        {
            //Timer que irá gerar uma ação aleatória nos veículos

            int acao = new Random().Next(1, 15);

        }

        #region Buttons Background Events
        private void MainWindow_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            button.Background = new SolidColorBrush(Color.FromRgb(00, 177, 255));

        }

        private void MainWindow_MouseLeave(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            button.Background = new SolidColorBrush(Color.FromRgb(00, 146, 255));
        }
        #endregion
    }
}
