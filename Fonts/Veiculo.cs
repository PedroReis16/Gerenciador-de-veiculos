using Gerenciador_de_veículos.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_veículos.Fonts
{
    public abstract class Veiculo
    {
        public string Id { get; set; }
        public double Peso { get; set; }
        public int Velocidade { get; set; }
        public int CapacidadePassageiros { get; set; }
        public int VelMax { get; set; }
        public Modelo Modelo { get; set; }


        public void Acelera()
        {
            Velocidade++;
        }
        public void Desacelera()
        {
            Velocidade--;
        }
    }
}
