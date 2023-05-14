using Gerenciador_de_veículos.Objects;
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
    /// Interaction logic for CarView.xaml
    /// </summary>
    public partial class CarView : UserControl
    {
        public CarView(MainWindow menu)
        {
            InitializeComponent();
            LoadView();
        }
        private void LoadView()
        {
            //Carro teste = new Carro
            //{
            //    Id = "1234567",
            //    Peso = 1000,
            //    Velocidade = 54,
            //    CapacidadePassageiros = 4,
            //    VelMax = 150,
            //    Oficial = true,
            //    Limpador = false,
            //};

            //Carrolv.Items.Add(teste);
            //Carrolv.Items.Add(teste);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
