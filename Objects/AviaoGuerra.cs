using Gerenciador_de_veículos.DAO;
using Gerenciador_de_veículos.Fonts;
using Gerenciador_de_veículos.Service;
using Gerenciador_de_veículos.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gerenciador_de_veículos.Objects
{
    public class AviaoGuerra : VeiculoFechado, IAviao
    {
        public AviaoGuerra()
        {
            NewAviao();
        }

        private void NewAviao()
        {
            Random random = new Random();
            List<Modelo> modelo = ModelosDAO.GetAll().Where(x=>x.Tipo == Enums.TipoVeiculo.AviaoGuerra).ToList();

            Id = IdentificadorAviao.GerarMatricula();
            Peso = 14000;
            VelMax = random.Next(950, 1700);
            Velocidade = random.Next(450, 1700);
            Modelo = modelo[random.Next(0, modelo.Count)];
            CapacidadePassageiros = 1;
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
        public void Atacar()
        {
            
        }
    }
}
