using Gerenciador_de_veículos.Interface;
using Gerenciador_de_veículos.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_veículos.Objects
{
    public class Aviao : IVeiculos, IAviao
    {
        public string Id { get; set; }
        public double Peso { get; set; }
        public int Velocidade { get; set; }
        public Modelo Modelo { get; set; }
        public int CapacidadePassageiros { get ; set ; }
        public bool Limpador { get; set; }

        public void Acelera()
        {
            Velocidade++;
        }
        public void Desacelera()
        {
            Velocidade--;
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
