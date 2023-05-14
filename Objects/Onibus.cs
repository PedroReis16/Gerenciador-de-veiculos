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
    public class Onibus : VeiculoFechado,IVeiculoTerrestre
    {
        public int Eixos { get; set; }
        public bool Leito { get; set; }

        public Onibus()
        {
            NewOnibus();
        }

        private void NewOnibus()
        {
            Random random = new Random();
            List<Modelo> modelo = ModelosDAO.GetAll().Where(x => x.Tipo == Enums.TipoVeiculo.Onibus).ToList();

            Id = IdentificadorCarro.GerarPlaca();
            Peso = random.Next(5000, 14500);
            VelMax = random.Next(70, 120);
            Velocidade = random.Next(0, 91);
            Modelo = modelo[random.Next(0, modelo.Count)];
            CapacidadePassageiros = random.Next(20, 61);
            Limpador = false;
            Eixos = random.Next(2, 5);

            if (random.Next(0, 1) == 0)
            {
                Leito = true;
            }
            else
            {
                Leito = false;
            }
        }

        public void Pedagio()
        {

        }
    }
}
