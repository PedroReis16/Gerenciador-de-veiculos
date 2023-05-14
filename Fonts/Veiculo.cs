using Gerenciador_de_veículos.Service;
using Newtonsoft.Json;
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

        [JsonProperty(PropertyName = "Modelo")]
        public Modelo Modelo { get; set; }


        public void Acelera()
        {
            Random rnd = new Random();

            int velocidade = rnd.Next(0, VelMax);

            while (Velocidade < VelMax || velocidade > 0)
            {
                Velocidade++;
                velocidade--;
            }
        }
        public void Desacelera()
        {
            Random rnd = new Random();

            int velocidade = rnd.Next(0, VelMax);

            while (Velocidade > 0 || velocidade > 0)
            {
                Velocidade--;
                velocidade--;
            }
        }
    }
}
