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
    public class Trem : VeiculoFechado
    {
        public int QtdVagoes { get; set; }

        public Trem()
        {
            NewTrem();
        }
        private void NewTrem()
        {
            Random random = new Random();
            Modelo modelo = ModelosDAO.GetAll().Where(x => x.Tipo == Enums.TipoVeiculo.Trem).FirstOrDefault();

            Id = IdentificadorTrem.GerarMatricula();
            Peso = 100000000;
            VelMax = random.Next(45, 80);
            Velocidade = random.Next(0, 60);
            CapacidadePassageiros = 1200;
            Modelo = modelo;
            Limpador = false;
            QtdVagoes = random.Next(1, 21);

            TrensDAO.Save(this);
        }
    }
}