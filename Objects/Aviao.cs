using Gerenciador_de_veículos.DAO;
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
            NewAviao();
        }
        private void NewAviao()
        {
            Random random = new Random();
            List<Modelo> modelo = ModelosDAO.GetAll().Where(x => x.Tipo == Enums.TipoVeiculo.Aviao).ToList();

            Id = IdentificadorAviao.GerarMatricula();
            Peso = 280000;
            VelMax = random.Next(650, 850);
            Velocidade = random.Next(250, 850);
            Modelo = modelo[random.Next(0, modelo.Count)];
            CapacidadePassageiros = random.Next(0, 850);
            Limpador = false;

            AvioesDAO.Save(this);
        }
        public string Arremeter()
        {
            return $"O avião {Id} tentou pousar, mas não conseguiu!";
        }

        public string Decolar()
        {
            return $"O avião acabou de {Id} decolou!";
        }

        public string Pousar()
        {
            return $"O avião {Id} acaba de pousar com tranquilidade!"; 
        }
    }
}
