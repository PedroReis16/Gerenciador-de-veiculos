using Gerenciador_de_veículos.Interface;
using Gerenciador_de_veículos.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_veículos.DAO
{
    public class VeiculosTerrestresDAO
    {
        public static List<IVeiculos> GetAllVehicles()
        {
            List<IVeiculos> list = new List<IVeiculos>();

            List<Carro> carros = new List<Carro>();
            List<Moto> motos = new List<Moto>();
            List<Onibus> onibus = new List<Onibus>();
            List<Caminhao> caminhaos= new List<Caminhao>();

            list.AddRange(carros);
            list.AddRange(motos);
            list.AddRange(onibus);
            list.AddRange(caminhaos);

            return list;
        }



    }
}
