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
    public class Trem : VeiculoFechado
    {

        public Trem()
        {
            Id = IdentificadorTrem.GerarMatricula();
        }
    }
}
