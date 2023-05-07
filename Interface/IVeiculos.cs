using Gerenciador_de_veículos.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_veículos.Interface
{
    public interface IVeiculos
    {
        string Id { get; set; }
        double Peso { get; set; }
        int Velocidade { get; set; }
        int CapacidadePassageiros { get; set; }
        Modelo Modelo { get; set; }
        void Acelera();
        void Desacelera();
    }
}
