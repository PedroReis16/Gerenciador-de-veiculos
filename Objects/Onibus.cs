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
    public class Onibus : VeiculoFechado,IVeiculoTerrestre
    {
        public int Eixos { get; set; }
        public bool Leito { get; set; }

        public Onibus()
        {
            Id = IdentificadorCarro.GerarPlaca();
        }

        public void Pedagio()
        {

        }
    }
}
