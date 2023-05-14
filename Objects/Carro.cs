using Gerenciador_de_veículos.DAO;
using Gerenciador_de_veículos.Fonts;
using Gerenciador_de_veículos.Service;
using Gerenciador_de_veículos.Services;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_veículos.Objects
{
    public class Carro : VeiculoFechado,IVeiculoTerrestre
    {
        public int Portas { get; set; }
        public bool Oficial { get; set; }

        public Carro()
        {
            NewCar();
        }
        private void NewCar()
        {
            Random rnd = new Random();
            int[] lugares = new int[] { 2, 4, 5, 7 };
            List<Modelo> modelo = ModelosDAO.GetAll().Where(x=> x.Tipo == Enums.TipoVeiculo.Carro).ToList();

            Id = IdentificadorCarro.GerarPlaca();
            Peso = rnd.Next(900, 2001);
            VelMax = rnd.Next(150, 300);
            Velocidade = rnd.Next(10, 161);
            CapacidadePassageiros = lugares[rnd.Next(0, 4)];
            Modelo = modelo[rnd.Next(0, modelo.Count)];
            if (rnd.Next(0, 1) == 0)
            {
                Portas = 4;
            }
            else
            {
                Portas = 2;
            }
            if (rnd.Next(0, 2) == 1)
            {
                Oficial = true;
            }
            else
            {
                Oficial = false;
            }
            Limpador = false;
        }
        public void Pedagio()
        {

        }
    }
}
