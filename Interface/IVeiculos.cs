using Gerenciador_de_veículos.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_veículos.Interface
{
    internal interface IVeiculos
    {
        string Id { get; set; }
        double Peso { get; set; }
        int Velocidade { get; set; }
        int CapacidadePagageitos { get; set; }
        Modelo Modelo;
        void Acelera();
        void Desacelera();
    }
}
