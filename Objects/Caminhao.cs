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
    public class Caminhao : VeiculoFechado,IVeiculoTerrestre
    {
        public int Eixos { get; set; }
        public double Capacidade { get; set; } //quantidade máxima de carga
        public double Carga { get; set; } //quantidade de carga atual

        public Caminhao()
        {
            Id = IdentificadorCarro.GerarPlaca();
        }

        public void Pedagio()
        {

        }
    }
}
