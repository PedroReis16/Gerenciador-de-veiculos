using Gerenciador_de_veículos.DAO;
using Gerenciador_de_veículos.Enums;
using Gerenciador_de_veículos.Fonts;
using Gerenciador_de_veículos.Objects;
using Gerenciador_de_veículos.Service;
using Gerenciador_de_veículos.Services;
using Gerenciador_de_veículos.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
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
        VeiculosAcoes acoes;
        bool timer, telas;
        VehiclesOptions vehiclesOptions;
        public List<string> Mensagem { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Mensagem = new List<string>();
            acoes = new VeiculosAcoes(this);

            InitializeTimer();
            actionTimer.Start();
            timer = true;
            telas = false;
        }

        #region Notification Button Events
        private void BtnNotification_MouseEnter(object sender, MouseEventArgs e)
        {
            NotificationView notificationView = new NotificationView(Mensagem);

            NotificationsGrid.Children.Clear();
            NotificationsGrid.Children.Add(notificationView);
            NotificationsGrid.Visibility = Visibility.Visible;
        }

        private void BtnNotification_MouseLeave(object sender, MouseEventArgs e)
        {
            NotificationsGrid.Children.Clear();
            NotificationsGrid.Visibility = Visibility.Collapsed;
        }
        #endregion

        #region Initial Buttons Events
        private void BtnVehicles_Click(object sender, RoutedEventArgs e)
        {
            OpenVehiclesView();
        }
        private void btnToll_Click(object sender, RoutedEventArgs e)
        {//Evento do botão pedágio
            OpenTollView();
        }

        private void btnActions_Click(object sender, RoutedEventArgs e)
        {
            OpenActionsView();
        }
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            if (VehiclesViewGrid.Visibility == Visibility.Visible)
            {
                VehiclesViewGrid.Children.Clear();
                VehiclesViewGrid.Visibility = Visibility.Collapsed;

                OpenVehiclesView();
            }
            else if (VehiclesGrid.Visibility == Visibility.Visible)
            {
                VehiclesGrid.Children.Clear();
                VehiclesGrid.Visibility = Visibility.Collapsed;
                InitialButtons.Visibility = Visibility.Visible;
                BtnBack.Visibility = Visibility.Collapsed;
            }
            if (ActionGrid.Visibility == Visibility.Visible)
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
            actionTimer.Interval = TimeSpan.FromSeconds(4);
        }
        private void ActionTimer(object sender, EventArgs e)
        {
            //Timer que irá gerar uma ação aleatória nos veículos

            int acao = new Random().Next(1, 15);
            acoes.Random(acao);
        }
        public void TimerControl()
        {
            if (timer == true)
            {
                actionTimer.Stop();
                timer = false;
            }
            else
            {
                actionTimer.Start();
                timer = true;
            }
        }

        public void Text(string Id, int acao)
        {
            switch (acao)
            {
                case 1:
                    Mensagem.Add($"O veículo {Id} acabou de acelerar um pouco");
                    break;
                case 2:
                    Mensagem.Add($"Parece que o veículo {Id} surgiu no radar! ");
                    break;
                case 3:
                    Mensagem.Add($"O avião {Id} tentou pousar e não conseguiu!");
                    break;
                case 4:
                    Mensagem.Add($"O veículo de guerra {Id} esta prestes a atacar!");
                    break;
                case 5:
                    Mensagem.Add($"O navio {Id} acabou de atracar em nosso porto!");
                    break;
                case 6:
                    Mensagem.Add($"O caminhão {Id} esta enchendo sua carroceria!");
                    break;
                case 7:
                    Mensagem.Add($"O avião {Id} acabou de partir");
                    break;
                case 8:
                    Mensagem.Add($"O caminhão {Id} esta esvaziando sua carroceria!");
                    break;
                case 9:
                    Mensagem.Add($"A moto {Id} esta se exibindo!");
                    break;
                case 10:
                    Mensagem.Add($"O veículo {Id} esta passando por algo molhado");
                    break;
                case 11:
                    Mensagem.Add($"O veículo {Id} vai ter que parada no pedágio!");
                    break;
                case 12:
                    Mensagem.Add($"O avião {Id} vai pousar em instantes!");
                    break;
                case 13:
                    Mensagem.Add($"O veículo {Id} precisou reduzir a velocidade!");
                    break;
                case 14:
                    Mensagem.Add($"Parece que o veículo {Id} sofreu um acidente");
                    break;
            }
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

        #region Vehicles views
        private void OpenVehiclesView()
        {
            BtnBack.Visibility = Visibility.Visible;
            VehiclesOptions vehiclesOptions = new VehiclesOptions(this);
            VehiclesGrid.Width = 800;

            VehiclesGrid.Children.Clear();
            VehiclesGrid.Children.Add(vehiclesOptions);
            VehiclesGrid.Visibility = Visibility.Visible;
            InitialButtons.Visibility = Visibility.Collapsed;
        }
        private void OpenTollView()
        {

        }
        private void OpenActionsView()
        {
            btnNotification.Visibility = Visibility.Collapsed;
            BtnBack.Visibility = Visibility.Visible;
            ActionsOptions actionsOptions = new ActionsOptions(this);

            ActionGrid.Children.Clear();
            ActionGrid.Children.Add(actionsOptions);
            ActionGrid.Visibility = Visibility.Visible;
            InitialButtons.Visibility = Visibility.Collapsed;
        }
        public void OpenCarView()
        {
            CarView carView = new CarView(this);

            VehiclesViewGrid.Children.Clear();
            VehiclesViewGrid.Children.Add(carView);
            VehiclesViewGrid.Visibility = Visibility.Visible;
            InitialButtons.Visibility = Visibility.Collapsed;
            VehiclesGrid.Visibility = Visibility.Collapsed;
            telas = true;
        }
        public void OpenBikeView()
        {
            BikeView carView = new BikeView(this);

            VehiclesViewGrid.Children.Clear();
            VehiclesViewGrid.Children.Add(carView);
            VehiclesViewGrid.Visibility = Visibility.Visible;
            InitialButtons.Visibility = Visibility.Collapsed;
            VehiclesGrid.Visibility = Visibility.Collapsed;
            telas = true;
        }
        public void OpenBusView()
        {
            BusView carView = new BusView(this);

            VehiclesViewGrid.Children.Clear();
            VehiclesViewGrid.Children.Add(carView);
            VehiclesViewGrid.Visibility = Visibility.Visible;
            InitialButtons.Visibility = Visibility.Collapsed;
            VehiclesGrid.Visibility = Visibility.Collapsed;
            telas = true;
        }
        public void OpenTruckView()
        {
            TruckView carView = new TruckView(this);

            VehiclesViewGrid.Children.Clear();
            VehiclesViewGrid.Children.Add(carView);
            VehiclesViewGrid.Visibility = Visibility.Visible;
            InitialButtons.Visibility = Visibility.Collapsed;
            VehiclesGrid.Visibility = Visibility.Collapsed;
            telas = true;
        }
        public void OpenPlaneView()
        {
            PlaneView carView = new PlaneView(this);

            VehiclesViewGrid.Children.Clear();
            VehiclesViewGrid.Children.Add(carView);
            VehiclesViewGrid.Visibility = Visibility.Visible;
            InitialButtons.Visibility = Visibility.Collapsed;
            VehiclesGrid.Visibility = Visibility.Collapsed;
            telas = true;
        }
        public void OpenWarPlaneView()
        {
            WarPlaneView carView = new WarPlaneView(this);

            VehiclesViewGrid.Children.Clear();
            VehiclesViewGrid.Children.Add(carView);
            VehiclesViewGrid.Visibility = Visibility.Visible;
            InitialButtons.Visibility = Visibility.Collapsed;
            VehiclesGrid.Visibility = Visibility.Collapsed;
            telas = true;
        }
        public void OpenShipView()
        {
            ShipView carView = new ShipView(this);

            VehiclesViewGrid.Children.Clear();
            VehiclesViewGrid.Children.Add(carView);
            VehiclesViewGrid.Visibility = Visibility.Visible;
            InitialButtons.Visibility = Visibility.Collapsed;
            VehiclesGrid.Visibility = Visibility.Collapsed;
            telas = true;
        }
        public void OpenWarShipView()
        {
            WarShipView carView = new WarShipView(this);

            VehiclesViewGrid.Children.Clear();
            VehiclesViewGrid.Children.Add(carView);
            VehiclesViewGrid.Visibility = Visibility.Visible;
            InitialButtons.Visibility = Visibility.Collapsed;
            VehiclesGrid.Visibility = Visibility.Collapsed;
            telas = true;
        }
        public void OpenTrainView()
        {
            TrainView carView = new TrainView(this);

            VehiclesViewGrid.Children.Clear();
            VehiclesViewGrid.Children.Add(carView);
            VehiclesViewGrid.Visibility = Visibility.Visible;
            InitialButtons.Visibility = Visibility.Collapsed;
            VehiclesGrid.Visibility = Visibility.Collapsed;
            telas = true;
        }
        #endregion


    }
}
