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
    public class AviaoGuerra : VeiculoFechado, IAviao
    {
        public AviaoGuerra()
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
        public void Atacar()
        {

        }
    }
}
