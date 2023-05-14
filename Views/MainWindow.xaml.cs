using Gerenciador_de_veículos.DAO;
using Gerenciador_de_veículos.Fonts;
using Gerenciador_de_veículos.Objects;
using Gerenciador_de_veículos.Services;
using Gerenciador_de_veículos.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        VeiculosAcoes acoes;
        bool timer, telas;
        VehiclesOptions vehiclesOptions;

        public MainWindow()
        {
            InitializeComponent();

            //acoes = new VeiculosAcoes(this);

            InitializeTimer();
            actionTimer.Start();
            timer = true;
            telas = false;
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
            actionTimer.Interval = TimeSpan.FromSeconds(1);
        }
        private void ActionTimer(object sender, EventArgs e)
        {
            //Timer que irá gerar uma ação aleatória nos veículos

            int acao = new Random().Next(1, 15);
            //acoes.Random(acao);
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

        private void InicializandosDados()
        {
            List<Marca> marcas = new List<Marca>()
            {
                new Marca(){Id = 1, Descricao = "Fiat"},
                new Marca(){Id = 2, Descricao = "Ford"},
                new Marca(){Id = 3, Descricao = "Chevrolet"},
                new Marca(){Id = 4, Descricao = "Volkswagen"},
                new Marca(){Id = 5, Descricao = "Honda"},
                new Marca(){Id = 6, Descricao = "Toyota"},
                new Marca(){Id = 7, Descricao = "Hyundai"},
                new Marca(){Id = 8, Descricao = "Nissan"},
                new Marca(){Id = 9, Descricao = "Renault"},
                new Marca(){Id = 10, Descricao = "Jeep"},
                new Marca(){Id = 11, Descricao = "Mitsubishi"},
                new Marca(){Id = 12, Descricao = "BMW"},
                new Marca(){Id = 13, Descricao = "Mercedes-Benz"},
                new Marca(){Id = 14, Descricao = "Audi"},
                new Marca(){Id = 15, Descricao = "Kia"},
                new Marca(){Id = 16, Descricao = "Citroën"},
                new Marca(){Id = 17, Descricao = "Volvo"},
                new Marca(){Id = 18, Descricao = "Land Rover"},
                new Marca(){Id = 19, Descricao = "Peugeot"},
                new Marca(){Id = 20, Descricao = "Chery"},
                new Marca(){Id = 21, Descricao = "JAC"},
                new Marca(){Id = 22, Descricao = "Suzuki"},
                new Marca(){Id = 23, Descricao = "Subaru"},
                new Marca(){Id = 24, Descricao = "Troller"},
                new Marca(){Id = 25, Descricao = "Dodge"},
                new Marca(){Id = 26, Descricao = "Chrysler"},
                new Marca(){Id = 27, Descricao = "Jaguar"},
                new Marca(){Id = 28, Descricao = "Lifan"},
                new Marca(){Id = 29, Descricao = "Mini"},
                new Marca(){Id = 30, Descricao = "Maserati"},
                new Marca(){Id = 31, Descricao = "Lexus"},
                new Marca(){Id = 32, Descricao = "Ferrari"},
                new Marca(){Id = 33, Descricao = "Porsche"},
                new Marca(){Id = 34, Descricao = "Bentley"},
                new Marca(){Id = 35, Descricao = "Rolls-Royce"},
                new Marca(){Id = 36, Descricao = "Lamborghini"},
                new Marca(){Id=37, Descricao = "Yamaha"},
                new Marca(){Id = 38, Descricao = "Kawasaki"},
                new Marca(){Id = 39, Descricao = "Harley-Davidson"},
                new Marca(){Id = 40, Descricao = "Ducati"},
                new Marca(){Id = 41, Descricao = "Triumph"},
                new Marca(){Id = 42, Descricao = "Aprilia"},
                new Marca(){Id = 43, Descricao = "Husqvarna"},
                new Marca(){Id = 44, Descricao = "KTM"},
                new Marca(){Id = 45, Descricao = "Indian"},
                new Marca(){Id = 46, Descricao = "MV Agusta"},
                new Marca(){Id = 47, Descricao = "Royal Enfield"},
                new Marca(){Id = 48, Descricao = "Scania"},
                new Marca(){Id = 49, Descricao = "MAN"},
                new Marca(){Id = 50, Descricao = "Iveco"},
                new Marca(){Id = 51, Descricao = "DAF"},
                new Marca(){Id = 52, Descricao = "Kenworth"},
                new Marca(){Id = 53, Descricao = "Volvo Buses"},
                new Marca(){Id = 54, Descricao = "Mercedes-Benz Buses"},
                new Marca(){Id = 55, Descricao = "Scania Buses"},
                new Marca(){Id = 56, Descricao = "MAN Buses"},
                new Marca(){Id = 57, Descricao = "Iveco Buses"},
                new Marca(){Id = 58, Descricao = "Marcopolo"},
                new Marca(){Id = 59, Descricao = "Neobus"},
                new Marca(){Id = 60, Descricao = "Busscar"},
                new Marca(){Id = 61, Descricao = "Comil"},
                new Marca(){Id = 62, Descricao = "Irizar"},
                new Marca(){Id = 63, Descricao = "Caio"},
                new Marca(){Id = 64, Descricao = "Boeing"},
                new Marca(){Id = 65, Descricao = "Airbus"},
                new Marca(){Id = 66, Descricao = "Embraer"},
                new Marca(){Id = 67, Descricao = "Bombardier"},
                new Marca(){Id = 68, Descricao = "Gulfstream"},
                new Marca(){Id = 69, Descricao = "Lockheed Martin"},
                new Marca(){Id = 70, Descricao = "Northrop Grumman"},
                new Marca(){Id = 71, Descricao = "Dassault Aviation"},
                new Marca(){Id = 72, Descricao = "Saab"},
                new Marca(){Id = 73, Descricao = "Sukhoi"},
                new Marca(){Id = 74, Descricao = "MiG"},
                new Marca(){Id = 75, Descricao = "HAL (Hindustan Aeronautics Limited)"},
                new Marca(){Id = 76, Descricao = "Emivest Aerospace"},
                new Marca(){Id = 77, Descricao = "Textron Aviation"},
                new Marca(){Id = 78, Descricao = "Pilatus Aircraft"},
                new Marca(){Id = 79, Descricao = "Cessna"},
                new Marca(){Id = 80, Descricao = "Beechcraft"},
                new Marca(){Id = 81, Descricao = "Diamond Aircraft"},
                new Marca(){Id = 82, Descricao = "KAI (Korea Aerospace Industries)"},
                new Marca(){Id = 83, Descricao = "Embraer Defense & Security"},
                new Marca(){Id = 84, Descricao = "Mitsubishi Heavy Industries"},
                new Marca(){Id = 85, Descricao = "Daewoo Shipbuilding & Marine Engineering"},
                new Marca(){Id = 86, Descricao = "Hyundai Heavy Industries"},
                new Marca(){Id = 87, Descricao = "Samsung Heavy Industries"},
                new Marca(){Id = 88, Descricao = "Navantia"},
                new Marca(){Id = 89, Descricao = "Fincantieri"},
                new Marca(){Id = 90, Descricao = "Babcock International"},
                new Marca(){Id = 91, Descricao = "Meyer Werft"},
                new Marca(){Id = 92, Descricao = "STX Europe"},
                new Marca(){Id = 93, Descricao = "Baltic Shipyard"},
                new Marca(){Id = 94, Descricao = "Huntington Ingalls Industries"},
                new Marca(){Id = 95, Descricao = "General Dynamics"},
                new Marca(){Id = 96, Descricao = "ThyssenKrupp Marine Systems"},
                new Marca(){Id = 97, Descricao = "BAE Systems"},
                new Marca(){Id = 98, Descricao = "Naval Group"},
                new Marca(){Id = 99, Descricao = "Lockheed Martin"},
                new Marca(){Id = 100, Descricao = "DCNS"},
                new Marca(){Id = 101, Descricao = "Rosoboronexport"},
                new Marca(){Id = 102, Descricao = "United Shipbuilding Corporation"},
                new Marca(){Id = 103, Descricao = "China Shipbuilding Industry Corporation"},
                new Marca(){Id = 104, Descricao = "Alstom"},
                new Marca(){Id = 105, Descricao = "Bombardier Transportation"},
                new Marca(){Id = 106, Descricao = "Siemens Mobility"}
            };

            foreach (var marca in marcas)
            {
                MarcasDAO.Save(marca);
            }
        }
    }
}
