using Gerenciador_de_veículos.DAO;
using Gerenciador_de_veículos.Enums;
using Gerenciador_de_veículos.Interface;
using Gerenciador_de_veículos.Objects;
using Gerenciador_de_veículos.Service;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Gerenciador_de_veículos.Services
{
    public class VeiculosAcoes : IVeiculosAcoes
    {
        Random random = new Random();
        List<IVeiculos> veiculos;
        MainWindow main;
        double valor;
        string placa;

        public VeiculosAcoes()
        {
            veiculos = VeiculosDAO.GetAll();
        }
        public VeiculosAcoes(MainWindow main)
        {
            veiculos = VeiculosDAO.GetAll();
            this.main = main;
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
            int tipo = random.Next(1, 10);
            int[] lugares = new int[] { 2, 4, 5, 7 };
            List<Modelo> modelo;

            switch (tipo)
            {
                case 1:
                    modelo = ModelosDAO.GetAll().Where(i => i.Tipo == TipoVeiculo.Carro).ToList();

                    Carro carro = new Carro();
                    carro.Peso = random.Next(900, 2001);
                    carro.VelMax = random.Next(150, 300);
                    carro.Velocidade = random.Next(10, 161);
                    carro.CapacidadePassageiros = lugares[random.Next(0, 4)];
                    carro.Modelo = modelo[random.Next(0, modelo.Count)];
                    if (random.Next(0, 1) == 0)
                    {
                        carro.Portas = 4;
                    }
                    else
                    {
                        carro.Portas = 2;
                    }
                    if (random.Next(0, 1) == 1)
                    {
                        carro.Oficial = true;
                    }
                    else
                    {
                        carro.Oficial = false;
                    }
                    carro.Limpador = false;

                    CarrosDAO.Save(carro);
                    break;
                case 2:
                    modelo = ModelosDAO.GetAll().Where(i => i.Tipo == TipoVeiculo.Moto).ToList();
                    Moto moto = new Moto();

                    moto.Peso = random.Next(90, 161);
                    moto.VelMax = random.Next(150, 300);
                    moto.Velocidade = random.Next(10, 300);
                    moto.CapacidadePassageiros = 2;
                    moto.Modelo = modelo[random.Next(0, modelo.Count)];
                    moto.Empinar = false;

                    MotosDAO.Save(moto);
                    break;
                case 3:
                    modelo = ModelosDAO.GetAll().Where(i => i.Tipo == TipoVeiculo.Ônibus).ToList();
                    Onibus onibus = new Onibus();

                    onibus.Peso = random.Next(5000, 14500);
                    onibus.VelMax = random.Next(70, 120);
                    onibus.Velocidade = random.Next(0, 91);
                    onibus.Modelo = modelo[random.Next(0, modelo.Count)];
                    onibus.CapacidadePassageiros = random.Next(20, 61);
                    onibus.Limpador = false;
                    onibus.Eixos = random.Next(2, 5);

                    if (random.Next(0, 1) == 0)
                    {
                        onibus.Leito = true;
                    }
                    else
                    {
                        onibus.Leito = false;
                    }

                    OnibusDAO.Save(onibus);
                    break;
                case 4:
                    modelo = ModelosDAO.GetAll().Where(i => i.Tipo == TipoVeiculo.Caminhao).ToList();
                    Caminhao caminhao = new Caminhao();

                    caminhao.Peso = random.Next(3500, 8000);
                    caminhao.Eixos = random.Next(2, 10);
                    caminhao.VelMax = random.Next(70, 120);
                    caminhao.Velocidade = random.Next(0, 91);
                    if (caminhao.Eixos == 2)
                    {
                        caminhao.Capacidade = 4000;
                    }
                    else if (caminhao.Eixos == 3)
                    {
                        caminhao.Capacidade = 6000;
                    }
                    else if (caminhao.Eixos == 4)
                    {
                        caminhao.Capacidade = 11000;
                    }
                    else if (caminhao.Eixos == 5)
                    {
                        caminhao.Capacidade = 13500;
                    }
                    else if (caminhao.Eixos == 6)
                    {
                        caminhao.Capacidade = 25000;
                    }
                    else
                    {
                        caminhao.Capacidade = 65000;
                    }
                    caminhao.Carga = random.Next(0, Convert.ToInt32(caminhao.Capacidade));
                    caminhao.Modelo = modelo[random.Next(0, modelo.Count)];
                    caminhao.CapacidadePassageiros = 2;
                    caminhao.Limpador = false;

                    CaminhoesDAO.Save(caminhao);

                    break;
                case 5:
                    modelo = ModelosDAO.GetAll().Where(i => i.Tipo == TipoVeiculo.Aviao).ToList();
                    Aviao aviao = new Aviao();

                    aviao.Peso = 280000;
                    aviao.VelMax = random.Next(650, 850);
                    aviao.Velocidade = random.Next(250, 850);
                    aviao.Modelo = modelo[random.Next(0, modelo.Count)];
                    aviao.CapacidadePassageiros = random.Next(0, 850);
                    aviao.Limpador = false;

                    AvioesDAO.Save(aviao);
                    break;
                case 6:
                    modelo = ModelosDAO.GetAll().Where(i => i.Tipo == TipoVeiculo.AviaoGuerra).ToList();
                    AviaoGuerra aviaoGuerra = new AviaoGuerra();

                    aviaoGuerra.Peso = 14000;
                    aviaoGuerra.VelMax = random.Next(950, 1700);
                    aviaoGuerra.Velocidade = random.Next(450, 1700);
                    aviaoGuerra.Modelo = modelo[random.Next(0, modelo.Count)];
                    aviaoGuerra.CapacidadePassageiros = 1;

                    AviaoGuerraDAO.Save(aviaoGuerra);
                    break;
                case 7:
                    modelo = ModelosDAO.GetAll().Where(i => i.Tipo == TipoVeiculo.Navio).ToList();
                    Navio navio = new Navio();

                    navio.Peso = 230000000;
                    navio.VelMax = random.Next(45, 60);
                    navio.Velocidade = random.Next(0, 60);
                    navio.CapacidadePassageiros = 5000;
                    navio.Modelo = modelo[random.Next(0, modelo.Count)];

                    NaviosDAO.Save(navio);
                    break;
                case 8:
                    modelo = ModelosDAO.GetAll().Where(i => i.Tipo == TipoVeiculo.NavioGuerra).ToList();
                    NavioGuerra navioGuerra = new NavioGuerra();

                    navioGuerra.Peso = 14000000;
                    navioGuerra.VelMax = random.Next(45, 60);
                    navioGuerra.Velocidade = random.Next(0, 60);
                    navioGuerra.CapacidadePassageiros = 200;
                    navioGuerra.Modelo = modelo[random.Next(0, modelo.Count)];

                    NavioGuerraDAO.Save(navioGuerra);
                    break;
                case 9:
                    modelo = ModelosDAO.GetAll().Where(i => i.Tipo == TipoVeiculo.Trem).ToList();
                    Trem trem = new Trem();

                    trem.Peso = 100000000;
                    trem.VelMax = random.Next(45, 80);
                    trem.Velocidade = random.Next(0, 60);
                    trem.CapacidadePassageiros = 1200;
                    trem.Modelo = modelo[random.Next(0, modelo.Count)];
                    trem.Limpador = false;
                    trem.QtdVagoes = random.Next(1, 21);

                    TrensDAO.Save(trem);
                    break;
            }


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
            int index = random.Next(0, veiculos.Count);
            var veiculo = veiculos[index];
            int velocidade = random.Next(0, 100); //Velocidade que deseja aumentar

            while (velocidade > 0 || veiculo.Velocidade < veiculo.VelMax)
            {
                veiculo.Velocidade++;

                velocidade--;
            }

            if (veiculo.GetType() == typeof(Carro))
            {
                CarrosDAO.Edit((Carro)veiculo);
            }
            else if (veiculo.GetType() == typeof(Moto))
            {
                MotosDAO.Edit((Moto)veiculo);
            }
            else if (veiculo.GetType() == typeof(Onibus))
            {
                OnibusDAO.Edit((Onibus)veiculo);
            }
            else if (veiculo.GetType() == typeof(Caminhao))
            {
                CaminhoesDAO.Edit((Caminhao)veiculo);
            }
            else if (veiculo.GetType() == typeof(Aviao))
            {
                AvioesDAO.Edit((Aviao)veiculo);
            }
            else if (veiculo.GetType() == typeof(AviaoGuerra))
            {
                AviaoGuerraDAO.Edit((AviaoGuerra)veiculo);
            }
            else if (veiculo.GetType() == typeof(Navio))
            {
                NaviosDAO.Edit((Navio)veiculo);
            }
            else if (veiculo.GetType() == typeof(NavioGuerra))
            {
                NavioGuerraDAO.Edit((NavioGuerra)veiculo);
            }
            else
            {
                TrensDAO.Edit((Trem)veiculo);
            }
        }
        public void Reduzir()
        {
            int index = random.Next(0, veiculos.Count);
            var veiculo = veiculos[index];
            int velocidade = random.Next(0, 100); //Velocidade que deseja diminuir
            while (velocidade > 0 || veiculo.Velocidade > 0)
            {
                veiculo.Velocidade--;
                velocidade--;
            }
            if (veiculo.GetType() == typeof(Carro))
            {
                CarrosDAO.Edit((Carro)veiculo);
            }
            else if (veiculo.GetType() == typeof(Moto))
            {
                MotosDAO.Edit((Moto)veiculo);
            }
            else if (veiculo.GetType() == typeof(Onibus))
            {
                OnibusDAO.Edit((Onibus)veiculo);
            }
            else if (veiculo.GetType() == typeof(Caminhao))
            {
                CaminhoesDAO.Edit((Caminhao)veiculo);
            }
            else if (veiculo.GetType() == typeof(Aviao))
            {
                AvioesDAO.Edit((Aviao)veiculo);
            }
            else if (veiculo.GetType() == typeof(AviaoGuerra))
            {
                AviaoGuerraDAO.Edit((AviaoGuerra)veiculo);
            }
            else if (veiculo.GetType() == typeof(Navio))
            {
                NaviosDAO.Edit((Navio)veiculo);
            }
            else if (veiculo.GetType() == typeof(NavioGuerra))
            {
                NavioGuerraDAO.Edit((NavioGuerra)veiculo);
            }
            else
            {
                TrensDAO.Edit((Trem)veiculo);
            }
        }
        public void Limpador()
        {
            List<IVeiculos> veiculos = this.veiculos.Where(x => x.GetType() != typeof(Moto)).ToList();
            int index = random.Next(0, veiculos.Count);

            var veiculo = veiculos[index];

            if (veiculo != null)
            {
                main.TimerControl();
                //Manda a mensagem que o limpador deste carro esta ligado
                Thread.Sleep(3000);
                //Manda mensagem que o limpador foi desligado
                main.TimerControl();
            }
        }
        public void Pedagio()
        {
            Pagamento pag = new Pagamento();
            List<IVeiculos> veiculos = VeiculosDAO.GetAllRoadVehicles();
            List<Pedagio> pedagios = PedagioDAO.GetAll();
            int index = random.Next(0, veiculos.Count);
            var veiculo = veiculos[index];
            Pedagio pedagio = pedagios[random.Next(0, pedagios.Count)];


            if (veiculo.GetType() != typeof(Carro))
            {
                Carro carro = (Carro)veiculo;
                if (carro.Oficial)
                {
                    valor = 0;
                }
                else
                {
                    valor = 7.00;
                }
                placa = carro.Id;
            }
            else if (veiculo.GetType() != typeof(Moto))
            {
                Moto moto = (Moto)veiculo;
                valor = 3.00;
                placa = moto.Id;
            }
            else if (veiculo.GetType() != typeof(Onibus))
            {
                Onibus onibus = (Onibus)veiculo;
                valor = onibus.Eixos * 8.50;
                placa = onibus.Id;
            }
            else if (veiculo.GetType() != typeof(Caminhao))
            {
                Caminhao caminhao = (Caminhao)veiculo;
                valor = caminhao.Eixos * 8.50;
                placa = caminhao.Id;
            }

            pag.Id = PagamentoDAO.GetAll().LastOrDefault().Id + 1;
            pag.IdPedagio = pedagio.Id;
            pag.Placa = placa;
            pag.Valor = valor;
            pag.Data = DateTime.Now;
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
