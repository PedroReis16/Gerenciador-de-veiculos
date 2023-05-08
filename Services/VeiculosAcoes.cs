using Gerenciador_de_veículos.DAO;
using Gerenciador_de_veículos.Interface;
using Gerenciador_de_veículos.Objects;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_veículos.Services
{
    public class VeiculosAcoes : IVeiculosAcoes
    {
        Random random = new Random();
        List<IVeiculos> veiculos;
        public VeiculosAcoes()
        {
            veiculos = VeiculosDAO.GetAll();
        }

        public void Random(int acao)
        {
            switch (acao)
            {
                case 1:
                    Acelerar();
                    break;
                case 2:
                    Reduzir();
                    break;
                case 3:
                    Limpador();
                    break;
                case 4:
                    Pedagio();
                    break;
                case 5:
                    Carregar();
                    break;
                case 6:
                    Descarregar();
                    break;
                case 7:
                    Empinar();
                    break;
                case 8:
                    Pousar();
                    break;
                case 9:
                    Arremeter();
                    break;
                case 10:
                    Atacar();
                    break;
                case 11:
                    Atracar();
                    break;
                case 12:
                    Adicionar();
                    break;
                case 13:
                    Remover();
                    break;
            }
        } //Método responsável por gerar uma ação aleatória
        public void Adicionar()
        {

        } //Método responsável pela criação de novos veículos
        public void Remover()
        {
            int index = random.Next(0, veiculos.Count);
            var veiculo = veiculos[index];

            if (veiculo.GetType() == typeof(Carro))
            {
                CarrosDAO.Delete((Carro)veiculo);
            }
            else if (veiculo.GetType() == typeof(Moto))
            {
                MotosDAO.Delete((Moto)veiculo);
            }
            else if (veiculo.GetType() == typeof(Onibus))
            {
                OnibusDAO.Delete((Onibus)veiculo);
            }
            else if (veiculo.GetType() == typeof(Caminhao))
            {
                CaminhoesDAO.Delete((Caminhao)veiculo);
            }
            else if (veiculo.GetType() == typeof(Aviao))
            {
                AvioesDAO.Delete((Aviao)veiculo);
            }
            else if (veiculo.GetType() == typeof(AviaoGuerra))
            {
                AviaoGuerraDAO.Delete((AviaoGuerra)veiculo);
            }
            else if (veiculo.GetType() == typeof(Navio))
            {
                NaviosDAO.Delete((Navio)veiculo);
            }
            else if (veiculo.GetType() == typeof(NavioGuerra))
            {
                NavioGuerraDAO.Delete((NavioGuerra)veiculo);
            }
            else
            {
                TrensDAO.Delete((Trem)veiculo);
            }
        } //Métodos responsável pela remoção de veículos
        public void Acelerar()
        {

        }
        public void Reduzir()
        {
        }
        public void Limpador()
        {

        }
        public void Pedagio()
        {

        }
        public void Carregar()
        {
        }
        public void Descarregar()
        {
        }
        public void Empinar()
        {

        }
        public void Pousar()
        {

        }
        public void Arremeter()
        {

        }
        public void Atacar()
        {

        }
        public void Atracar()
        {

        }
    }
}
