using Gerenciador_de_veículos.DAO;
using Gerenciador_de_veículos.Enums;
using Gerenciador_de_veículos.Fonts;
using Gerenciador_de_veículos.Objects;
using Gerenciador_de_veículos.Service;
using MaterialDesignThemes.Wpf;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;

namespace Gerenciador_de_veículos.Services
{
    public class VeiculosAcoes : IVeiculosAcoes
    {
        Random rnd = new Random();
        MainWindow menu;

        public VeiculosAcoes(MainWindow menu)
        {
            this.menu = menu;
        }

        public void Random(int acao)
        {
            switch (acao)
            {
                case 1:
                    Adicionar();
                    break;
                case 2:
                    Remover();
                    break;
                case 3:
                    Arremeter();
                    break;
                case 4:
                    Atacar();
                    break;
                case 5:
                    Atracar();
                    break;
                case 6:
                    Carregar();
                    break;
                case 7:
                    Decolar();
                    break;
                case 8:
                    Descarregar();
                    break;
                case 9:
                    Empinar();
                    break;
                case 10:
                    Limpador();
                    break;
                case 11:
                    Pedagio();
                    break;
                case 12:
                    Pousar();
                    break;
                case 13:
                    Reduzir();
                    break;
                case 14:
                    Remover();
                    break;

            }
        }
        public void Acelerar()
        {
            var veiculos = VeiculosDAO.GetAllVehicles();

            if (veiculos.Count == 0 || veiculos == null)
            {
                Adicionar();
            }

            List<object> list = VeiculosDAO.GetAllVehicles();
            if (list.Count == 0 || list == null)
            {
                return;
            }
            var veiculo = list[rnd.Next(0, list.Count)];

            if (veiculo is Carro)
            {
                ((Carro)veiculo).Desacelera();
            }
            else if (veiculo is Caminhao)
            {
                ((Caminhao)veiculo).Desacelera();
            }
            else if (veiculo is Onibus)
            {
                ((Onibus)veiculo).Desacelera();
            }
            else if (veiculo is Aviao)
            {
                ((Aviao)veiculo).Desacelera();
            }
            else if (veiculo is AviaoGuerra)
            {
                ((AviaoGuerra)veiculo).Desacelera();
            }
            else if (veiculo is Navio)
            {
                ((Navio)veiculo).Desacelera();
            }
            else if (veiculo is Trem)
            {
                ((Trem)veiculo).Desacelera();
            }
            else if (veiculo is NavioGuerra)
            {
                ((NavioGuerra)veiculo).Desacelera();
            }

            Veiculo veiculo1 = (Veiculo)veiculo;
            menu.Text(veiculo1.Id, 1);
        }

        public void Adicionar()
        {
            object novo;

            switch (rnd.Next(0, 9))
            {
                case 0:
                    novo = new Carro();
                    VeiculosDAO.Save(novo);
                    break;
                case 1:
                    novo = new Moto();
                    VeiculosDAO.Save(novo);
                    break;
                case 2:
                    novo = new Aviao();
                    VeiculosDAO.Save(novo);
                    break;
                case 3:
                    novo = new Navio();
                    VeiculosDAO.Save(novo);
                    break;
                case 4:
                    novo = new Caminhao();
                    VeiculosDAO.Save(novo);
                    break;
                case 5:
                    novo = new Onibus();
                    VeiculosDAO.Save(novo);
                    break;
                case 6:
                    novo = new Trem();
                    VeiculosDAO.Save(novo);
                    break;
                case 7:
                    novo = new NavioGuerra();
                    VeiculosDAO.Save(novo);
                    break;
                case 8:
                    novo = new AviaoGuerra();
                    VeiculosDAO.Save(novo);
                    break;
            }

            var veiculo = VeiculosDAO.GetAllVehicles();
            Veiculo ultimo = (Veiculo)veiculo.LastOrDefault();

            menu.Text(ultimo.Id, 2);
        }

        public void Arremeter()
        {
            List<object> list = VeiculosDAO.GetAllPlanes();
            if (list.Count == 0 || list == null)
            {
                return;
            }

            var aviao = list[rnd.Next(0, list.Count)];
            string mensagem;
            Veiculo veiculo;

            if (aviao is Aviao)
            {
                mensagem = ((Aviao)aviao).Arremeter();
                veiculo = (Aviao)aviao;
                menu.Text(veiculo.Id, 3);
            }
            else
            {
                mensagem = ((AviaoGuerra)aviao).Arremeter();
                veiculo = (AviaoGuerra)aviao;
                menu.Text(veiculo.Id, 3);
            }
        }

        public void Atacar()
        {
            List<object> list = VeiculosDAO.GetAllPlanes();
            if (list.Count == 0 || list == null)
            {
                return;
            }

            var veiculo = list[rnd.Next(0, list.Count)];
            Veiculo atacar = (Veiculo)veiculo;

            if (veiculo is AviaoGuerra)
            {
                ((AviaoGuerra)veiculo).Atacar();
                atacar = (AviaoGuerra)veiculo;
                menu.Text(atacar.Id, 4);
            }
            else
            {
                ((NavioGuerra)veiculo).Atacar();
                atacar = (NavioGuerra)veiculo;
                menu.Text(atacar.Id, 4);
            }
        }

        public void Atracar()
        {
            List<object> list = VeiculosDAO.GetAllShips();

            if (list.Count == 0 || list == null)
            {
                return;
            }

            var veiculo = list[rnd.Next(0, list.Count)];

            if (veiculo is Navio)
            {
                ((Navio)veiculo).Atracar();
            }
            else
            {
                ((NavioGuerra)veiculo).Atracar();
            }

            Veiculo barco = (Veiculo)veiculo;
            menu.Text(barco.Id, 5);
        }

        public void Carregar()
        {
            List<object> list = VeiculosDAO.GetAllRoadVehicles().Where(x => x.GetType() == typeof(Caminhao)).ToList();

            if (list.Count == 0 || list == null)
            {
                return;
            }

            var veiculo = list[rnd.Next(0, list.Count)];

            ((Caminhao)veiculo).Carregar();
            Veiculo veiculo1 = (Veiculo)veiculo;
            menu.Text(veiculo1.Id, 6);

        }

        public void Decolar()
        {
            List<object> list = VeiculosDAO.GetAllPlanes();
            if (list.Count == 0 || list == null)
            {
                return;
            }

            var aviao = list[rnd.Next(0, list.Count)];
            Veiculo veiculo;

            if (aviao is Aviao)
            {
                ((Aviao)aviao).Decolar();
                veiculo = (Veiculo)aviao;
                menu.Text(veiculo.Id, 7);
            }
            else
            {
                ((AviaoGuerra)aviao).Decolar();
                veiculo = (Veiculo)aviao;
                menu.Text(veiculo.Id, 7);
            }
        }

        public void Descarregar()
        {
            List<object> list = VeiculosDAO.GetAllRoadVehicles().Where(x=>x.GetType()==typeof(Caminhao)).ToList();

            if (list.Count == 0 || list == null)
            {
                return;
            }

            var veiculo = list[rnd.Next(0, list.Count)];

            ((Caminhao)veiculo).Descarregar();
            Veiculo caminhao = (Veiculo)veiculo;
            menu.Text(caminhao.Id, 8);
        }

        public void Empinar()
        {
            List<object> list = VeiculosDAO.GetAllRoadVehicles().Where(x=>x.GetType()==typeof(Moto)).ToList();

            if (list.Count == 0 || list == null)
            {
                return;
            }

            var veiculo = list[rnd.Next(0, list.Count)];
            ((Moto)veiculo).Grau();
            Veiculo moto = (Veiculo)veiculo;
            menu.Text(moto.Id, 9);
        }

        public void Limpador()
        {
            List<object> list = VeiculosDAO.GetAllVehicles().Where(x => x.GetType() != typeof(Moto)).ToList();

            if (list.Count == 0 || list == null)
            {
                return;
            }

            var veiculo = list[rnd.Next(0, list.Count)];

            if (veiculo is Carro)
            {
                ((Carro)veiculo).LigaDesligaLimpador();
            }
            else if (veiculo is Caminhao)
            {
                ((Caminhao)veiculo).LigaDesligaLimpador();
            }
            else if (veiculo is Onibus)
            {
                ((Onibus)veiculo).LigaDesligaLimpador();
            }
            else if (veiculo is Aviao)
            {
                ((Aviao)veiculo).LigaDesligaLimpador();
            }
            else if (veiculo is AviaoGuerra)
            {
                ((AviaoGuerra)veiculo).LigaDesligaLimpador();
            }
            else if (veiculo is Navio)
            {
                ((Navio)veiculo).LigaDesligaLimpador();
            }
            else if (veiculo is Trem)
            {
                ((Trem)veiculo).LigaDesligaLimpador();
            }
            else if (veiculo is NavioGuerra)
            {
                ((NavioGuerra)veiculo).LigaDesligaLimpador();
            }

            Veiculo veiculo1 = (Veiculo)veiculo;
            menu.Text(veiculo1.Id, 10);
        }

        public void Pedagio()
        {
            List<object> list = VeiculosDAO.GetAllRoadVehicles();

            var veiculo = list[rnd.Next(0, list.Count)];

            if (veiculo is Carro)
            {
                ((Carro)veiculo).Pedagio();
            }
            else if (veiculo is Caminhao)
            {
                ((Caminhao)veiculo).Pedagio();
            }
            else if (veiculo is Onibus)
            {
                ((Onibus)veiculo).Pedagio();
            }
            else if (veiculo is Moto)
            {
                ((Moto)veiculo).Pedagio();
            }

            Veiculo veiculo1 = (Veiculo)veiculo;
            menu.Text(veiculo1.Id, 11);
        }

        public void Pousar()
        {
            List<object> list = VeiculosDAO.GetAllPlanes();
            if (list.Count == 0 || list == null)
            {
                return;
            }

            var aviao = list[rnd.Next(0, list.Count)];
            Veiculo veiculo;
            if (aviao is Aviao)
            {
                ((Aviao)aviao).Pousar();
                veiculo = (Veiculo)aviao;
                menu.Text(veiculo.Id, 12);
            }
            else
            {
                ((AviaoGuerra)aviao).Pousar();
                veiculo = (Veiculo)aviao;
                menu.Text(veiculo.Id, 12);
            }

        }

        public void Reduzir()
        {
            List<object> list = VeiculosDAO.GetAllVehicles();
            if (list.Count == 0 || list == null)
            {
                return;
            }
            var veiculo = list[rnd.Next(0, list.Count)];

            if (veiculo is Carro)
            {
                ((Carro)veiculo).Desacelera();
            }
            else if (veiculo is Caminhao)
            {
                ((Caminhao)veiculo).Desacelera();
            }
            else if (veiculo is Onibus)
            {
                ((Onibus)veiculo).Desacelera();
            }
            else if (veiculo is Aviao)
            {
                ((Aviao)veiculo).Desacelera();
            }
            else if (veiculo is AviaoGuerra)
            {
                ((AviaoGuerra)veiculo).Desacelera();
            }
            else if (veiculo is Navio)
            {
                ((Navio)veiculo).Desacelera();
            }
            else if (veiculo is Trem)
            {
                ((Trem)veiculo).Desacelera();
            }
            else if (veiculo is NavioGuerra)
            {
                ((NavioGuerra)veiculo).Desacelera();
            }
            Veiculo veiculo1 = (Veiculo)veiculo;
            menu.Text(veiculo1.Id, 13);
        }

        public void Remover()
        {
            List<object> list = VeiculosDAO.GetAllVehicles();

            if (list.Count == 0 || list == null)
            {
                Adicionar();
                return;
            }

            var veiculo = list[rnd.Next(0, list.Count)];

            Veiculo veiculo1 = (Veiculo)veiculo;
            menu.Text(veiculo1.Id, 14);

            VeiculosDAO.Delete(veiculo);
        }
    }
}
