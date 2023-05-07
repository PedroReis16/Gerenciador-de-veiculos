using Gerenciador_de_veículos.Interface;
using Gerenciador_de_veículos.Service;
using Gerenciador_de_veículos.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_veículos.Objects
{
    public class Moto : IVeiculos, IVeiculosTerrestres
    {
        public string Id { get; set; }
        public double Peso { get; set; }
        public int Velocidade { get; set; }
        public int CapacidadePassageiros { get; set; }
        public Modelo Modelo { get; set; }
        public bool Empinar { get;set; }

        public Moto()
        {
            Id = GeradorPlacas.GerarPlaca();
        }

        public void Acelera()
        {
        }

        public void Desacelera()
        {
        }

        public void GerarPlaca()
        {
            
        }

        public void PagarPedagio()
        {
        }
    }
}
