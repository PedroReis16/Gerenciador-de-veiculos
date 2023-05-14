using Gerenciador_de_veículos.DAO;
using Gerenciador_de_veículos.Fonts;
using Gerenciador_de_veículos.Service;
using Gerenciador_de_veículos.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_veículos.Objects
{
    public class Caminhao : VeiculoFechado,IVeiculoTerrestre
    {
        public int Eixos { get; set; }
        public double Capacidade { get; set; } //quantidade máxima de carga
        public double Carga { get; set; } //quantidade de carga atual

        public Caminhao()
        {
            NewCaminhao();
        }

        private void NewCaminhao()
        {
            Random random = new Random();
            List<Modelo> modelo = ModelosDAO.GetAll().Where(x => x.Tipo == Enums.TipoVeiculo.Caminhao).ToList();

            Id = IdentificadorCarro.GerarPlaca();
            Peso = random.Next(3500, 8000);
            Eixos = random.Next(2, 10);
            VelMax = random.Next(70, 120);
            Velocidade = random.Next(0, 91);
            if (Eixos == 2)
            {
                Capacidade = 4000;
            }
            else if (Eixos == 3)
            {
                Capacidade = 6000;
            }
            else if (Eixos == 4)
            {
                Capacidade = 11000;
            }
            else if (Eixos == 5)
            {
                Capacidade = 13500;
            }
            else if (Eixos == 6)
            {
               Capacidade = 25000;
            }
            else
            {
                Capacidade = 65000;
            }
            Carga = random.Next(0, Convert.ToInt32(Capacidade));
            Modelo = modelo[random.Next(0, modelo.Count)];
            CapacidadePassageiros = 2;
            Limpador = false;
        }

        public void Pedagio()
        {

        }
        public void Carregar()
        {
            
        }
        public void Descarregar()
        {
            
        }   
    }
}
