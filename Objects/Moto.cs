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
    public class Moto : Veiculo, IVeiculoTerrestre
    {
        public bool Empinar { get;set; }

        public Moto()
        {
            Id = IdentificadorCarro.GerarPlaca();
        }

        public void Pedagio()
        {

        }
    }
}
