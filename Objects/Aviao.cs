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
    public class Aviao : VeiculoFechado, IAviao
    {
        public Aviao()
        {
            Id = IdentificadorAviao.GerarMatricula();
        }

        public void Arremetar()
        {

        }

        public void Decolar()
        {

        }

        public void Pousar()
        {

        }
    }
}
