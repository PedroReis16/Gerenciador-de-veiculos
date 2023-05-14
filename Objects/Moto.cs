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
    public class Moto : Veiculo, IVeiculoTerrestre
    {
        public bool Empinar { get;set; }

        public Moto()
        {
            NewMoto();
        }

        private void NewMoto()
        {
            Random random = new Random();
            List<Modelo> modelo = ModelosDAO.GetAll().Where(x=>x.Tipo == Enums.TipoVeiculo.Moto).ToList();

            Id = IdentificadorCarro.GerarPlaca();
            Peso = random.Next(90, 161);
            VelMax = random.Next(150, 300);
            Velocidade = random.Next(10, 300);
            CapacidadePassageiros = 2;
            Modelo = modelo[random.Next(0, modelo.Count)];
            Empinar = false;
        }

        public void Pedagio()
        {

        }
    }
}
