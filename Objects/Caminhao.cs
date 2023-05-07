using Gerenciador_de_veículos.Interface;
using Gerenciador_de_veículos.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_veículos.Objects
{
    public class Caminhao : IVeiculos, IVeiculosTerrestres
    {
        public string Id { get; set; }
        public double Peso { get; set; } //veiculo descarregado
        public int Eixos { get; set; }
        public int Velocidade { get; set; }
        public int Passageiros { get; set; }
        public double Carga { get; set; } //quantidade de carga atual
        public double Capacidade { get; set; } //quantidade máxima de carga
        public Modelo Modelo { get; set; }
        public int CapacidadePassageiros { get; set; }
        public bool Limpador { get; set; }
        public void Acelera()
        {

        }

        public void Desacelera()
        {

        }

        public void PagarPedagio()
        {

        }
        public void Carregar()
        {
        }
        public void Descarregar()
        {

        }

        public void GerarPlaca()
        {

        }
    }
}
