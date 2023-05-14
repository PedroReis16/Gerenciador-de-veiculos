using Gerenciador_de_veículos.DAO;
using Gerenciador_de_veículos.Fonts;
using Gerenciador_de_veículos.Service;
using Gerenciador_de_veículos.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gerenciador_de_veículos.Objects
{
    public class NavioGuerra : VeiculoFechado
    {
        public NavioGuerra()
        {
            NewNavio();
        }

        private void NewNavio()
        {
            Random random = new Random();  
            List<Modelo> modelo = ModelosDAO.GetAll().Where(x => x.Tipo == Enums.TipoVeiculo.NavioGuerra).ToList();

            Id = IdentificadorNavio.GerarMatricula();
            Peso = 14000000;
            VelMax = random.Next(45, 60);
            Velocidade = random.Next(0, 60);
            CapacidadePassageiros = 200;
            Modelo = modelo[random.Next(0, modelo.Count)];
        }

        public void Atracar()
        {

        }
        public void Atacar()
        {

        }
    }
}
