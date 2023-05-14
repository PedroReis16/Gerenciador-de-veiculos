using Gerenciador_de_veículos.DAO;
using Gerenciador_de_veículos.Fonts;
using Gerenciador_de_veículos.Objects;
using System;
using System.Collections.Generic;

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
            switch (rnd.Next(0, 9))
            {
                case 0:
                    var list = CarrosDAO.GetAll();
                    if (list == null)
                    {
                        return;
                    }

                    Carro car;
                    if (list.Count == 1)
                    {
                        car = list[0];
                    }
                    else if (list.Count > 1)
                    {
                        car = list[rnd.Next(0, list.Count)];
                    }
                    else
                    {
                        return;
                    }
                    car.Acelera();
                    break;
                case 1:
                    var listM = MotosDAO.GetAll();
                    if (listM == null)
                    {
                        return;
                    }

                    Moto bike;
                    if (listM.Count == 1)
                    {
                        bike = listM[0];
                    }
                    else if (listM.Count > 1)
                    {
                        bike = listM[rnd.Next(0, listM.Count)];
                    }
                    else
                    {
                        return;
                    }
                    bike.Acelera();
                    break;
                case 2:
                    var listB = OnibusDAO.GetAll();
                    if (listB == null)
                    {
                        return;
                    }
                    Onibus bus;
                    if (listB.Count == 1)
                    {
                        bus = listB[0];
                    }
                    else if (listB.Count > 1)
                    {
                        bus = listB[rnd.Next(0, listB.Count)];
                    }
                    else
                    {
                        return;
                    }
                    bus.Acelera();
                    break;
                case 3:
                    var listC = CaminhoesDAO.GetAll();
                    if (listC == null)
                    {
                        return;
                    }
                    Caminhao truck;

                    if (listC.Count == 1)
                    {
                        truck = listC[0];
                    }
                    else if (listC.Count > 1)
                    {
                        truck = listC[rnd.Next(0, listC.Count)];
                    }
                    else
                    {
                        return;
                    }
                    truck.Acelera();
                    break;
                case 4:
                    var listA = AvioesDAO.GetAll();
                    if (listA == null)
                    {
                        return;
                    }
                    Aviao plane;
                    if (listA.Count == 1)
                    {
                        plane = listA[0];
                    }
                    else if (listA.Count > 1)
                    {
                        plane = listA[rnd.Next(0, listA.Count)];
                    }
                    else
                    {
                        return;
                    }
                    plane.Acelera();
                    break;
                case 5:
                    var listAG = AviaoGuerraDAO.GetAll();
                    if (listAG == null)
                    {
                        return;
                    }
                    AviaoGuerra planeG;
                    if (listAG.Count == 1)
                    {
                        planeG = listAG[0];
                    }
                    else if (listAG.Count > 1)
                    {
                        planeG = listAG[rnd.Next(0, listAG.Count)];
                    }
                    else
                    {
                        return;
                    }
                    planeG.Acelera();
                    break;
                case 6:
                    var listN = NaviosDAO.GetAll();
                    if (listN == null)
                    {
                        return;
                    }
                    Navio ship;
                    if (listN.Count == 1)
                    {
                        ship = listN[0];
                    }
                    else if (listN.Count > 1)
                    {
                        ship = listN[rnd.Next(0, listN.Count)];
                    }
                    else
                    {
                        return;
                    }
                    ship.Acelera();
                    break;
                case 7:
                    var listNG = NavioGuerraDAO.GetAll();
                    if (listNG == null)
                    {
                        return;
                    }
                    NavioGuerra shipG;
                    if (listNG.Count == 1)
                    {
                        shipG = listNG[0];
                    }
                    else if (listNG.Count > 1)
                    {
                        shipG = listNG[rnd.Next(0, listNG.Count)];
                    }
                    else
                    {
                        return;
                    }
                    shipG.Acelera();
                    break;
                case 8:
                    var listT = TrensDAO.GetAll();
                    if (listT == null)
                    {
                        return;
                    }
                    Trem train;
                    if (listT.Count == 1)
                    {
                        train = listT[0];
                    }
                    else if (listT.Count > 1)
                    {
                        train = listT[rnd.Next(0, listT.Count)];
                    }
                    else
                    {
                        return;
                    }
                    train.Acelera();
                    break;
            }

            //Veiculo veiculo1 = (Veiculo)veiculo;
            //menu.Text(veiculo1.Id, 1);
        }

        public void Adicionar()
        {
            object novo;

            switch (rnd.Next(0, 9))
            {
                case 0:
                    novo = new Carro();
                    break;
                case 1:
                    novo = new Moto();
                    break;
                case 2:
                    novo = new Aviao();
                    break;
                case 3:
                    novo = new Navio();
                    break;
                case 4:
                    novo = new Caminhao();
                    break;
                case 5:
                    novo = new Onibus();
                    break;
                case 6:
                    novo = new Trem();
                    break;
                case 7:
                    novo = new NavioGuerra();
                    break;
                case 8:
                    novo = new AviaoGuerra();
                    break;
            }

            //var veiculo = VeiculosDAO.GetAllVehicles();

            //menu.Text(ultimo.Id, 2);
        }

        public void Arremeter()
        {
            switch (rnd.Next(0, 2))
            {
                case 0:
                    var list = AvioesDAO.GetAll();

                    if (list == null)
                    {
                        return;
                    }

                    Aviao aviao;
                    if (list.Count == 1)
                    {
                        aviao = list[0];
                    }
                    else if (list.Count > 1)
                    {
                        aviao = list[rnd.Next(0, list.Count)];
                    }
                    else
                    {
                        return;
                    }

                    aviao.Arremeter();
                    break;

                case 1:
                    var lista = AviaoGuerraDAO.GetAll();

                    if (lista == null)
                    {
                        return;
                    }

                    AviaoGuerra plane;

                    if (lista.Count == 1)
                    {
                        plane = lista[0];
                    }
                    else if (lista.Count > 1)
                    {
                        plane = lista[rnd.Next(0, lista.Count)];
                    }
                    else
                    {
                        return;
                    }
                    plane.Arremeter();

                    break;
            }

        }

        public void Atacar()
        {
            switch (rnd.Next(1, 3))
            {
                case 1:
                    var list = AviaoGuerraDAO.GetAll();

                    if (list == null)
                    {
                        return;
                    }

                    AviaoGuerra plane;

                    if (list.Count == 1)
                    {
                        plane = list[0];
                    }
                    else if (list.Count > 1)
                    {
                        plane = list[rnd.Next(0, list.Count)];
                    }
                    else
                    {
                        return;
                    }
                    plane.Atacar();

                    break;
                case 2:
                    var lista = NavioGuerraDAO.GetAll();

                    if (lista == null)
                    {
                        return;
                    }

                    NavioGuerra navio;

                    if (lista.Count == 1)
                    {
                        navio = lista[0];
                    }
                    else if (lista.Count > 1)
                    {
                        navio = lista[rnd.Next(0, lista.Count)];
                    }
                    else
                    {
                        return;
                    }

                    navio.Atacar();
                    break;
            }

        }

        public void Atracar()
        {
            switch (rnd.Next(0, 2))
            {
                case 0:
                    var list = NaviosDAO.GetAll();

                    if (list == null)
                    {
                        return;
                    }

                    Navio ship;

                    if (list.Count == 1)
                    {
                        ship = list[0];
                    }
                    else if (list.Count > 1)
                    {
                        ship = list[rnd.Next(0, list.Count)];
                    }
                    else
                    {
                        return;
                    }
                    ship.Atracar();

                    break;
                case 1:
                    var lista = NavioGuerraDAO.GetAll();

                    if (lista == null)
                    {
                        return;
                    }

                    NavioGuerra navio;

                    if (lista.Count == 1)
                    {
                        navio = lista[0];
                    }
                    else if (lista.Count > 1)
                    {
                        navio = lista[rnd.Next(0, lista.Count)];
                    }
                    else
                    {
                        return;
                    }

                    navio.Atracar();
                    break;
            }
        }

        public void Carregar()
        {
            List<Caminhao> list = CaminhoesDAO.GetAll();

            if (list == null)
            {
                return;
            }

            Caminhao truck;
            if (list.Count == 1)
            {
                truck = list[0];
            }
            else if (list.Count > 1)
            {
                truck = list[rnd.Next(0, list.Count)];
            }
            else
            {
                return;
            }

            truck.Carregar();

        }

        public void Decolar()
        {
            switch (rnd.Next(0, 2))
            {
                case 0:
                    var list = AvioesDAO.GetAll();

                    if (list == null)
                    {
                        return;
                    }

                    Aviao aviao;
                    if (list.Count == 1)
                    {
                        aviao = list[0];
                    }
                    else if (list.Count > 1)
                    {
                        aviao = list[rnd.Next(0, list.Count)];
                    }
                    else
                    {
                        return;
                    }

                    aviao.Decolar();
                    break;

                case 1:
                    var lista = AviaoGuerraDAO.GetAll();

                    if (lista == null)
                    {
                        return;
                    }

                    AviaoGuerra plane;

                    if (lista.Count == 1)
                    {
                        plane = lista[0];
                    }
                    else if (lista.Count > 1)
                    {
                        plane = lista[rnd.Next(0, lista.Count)];
                    }
                    else
                    {
                        return;
                    }
                    plane.Decolar();

                    break;
            }
        }

        public void Descarregar()
        {
            List<Caminhao> list = CaminhoesDAO.GetAll();

            if (list == null)
            {
                return;
            }

            Caminhao truck;
            if (list.Count == 1)
            {
                truck = list[0];
            }
            else if (list.Count > 1)
            {
                truck = list[rnd.Next(0, list.Count)];
            }
            else
            {
                return;
            }

            truck.Carregar();
            //Veiculo caminhao = (Veiculo)veiculo;
            //menu.Text(caminhao.Id, 8);
        }

        public void Empinar()
        {
            List<Moto> list = MotosDAO.GetAll();

            if (list == null)
            {
                return;
            }

            Moto veiculo;
            if (list.Count == 1)
            {
                veiculo = list[0];
            }
            else if (list.Count > 1)
            {
                veiculo = list[rnd.Next(0, list.Count)];
            }
            else
            {
                return;
            }
            veiculo.Grau();

            //Veiculo moto = (Veiculo)veiculo;
            //menu.Text(moto.Id, 9);
        }

        public void Limpador()
        {
            switch (rnd.Next(0, 9))
            {
                case 0:
                    var list = CarrosDAO.GetAll();
                    if (list == null)
                    {
                        return;
                    }

                    Carro car;
                    if (list.Count == 1)
                    {
                        car = list[0];
                    }
                    else if (list.Count > 1)
                    {
                        car = list[rnd.Next(0, list.Count)];
                    }
                    else
                    {
                        return;
                    }
                    car.LigaDesligaLimpador();
                    break;
                case 1:
                    var listB = OnibusDAO.GetAll();
                    if (listB == null)
                    {
                        return;
                    }
                    Onibus bus;
                    if (listB.Count == 1)
                    {
                        bus = listB[0];
                    }
                    else if (listB.Count > 1)
                    {
                        bus = listB[rnd.Next(0, listB.Count)];
                    }
                    else
                    {
                        return;
                    }
                    bus.LigaDesligaLimpador();
                    break;
                case 2:
                    var listC = CaminhoesDAO.GetAll();
                    if (listC == null)
                    {
                        return;
                    }
                    Caminhao truck;

                    if (listC.Count == 1)
                    {
                        truck = listC[0];
                    }
                    else if (listC.Count > 1)
                    {
                        truck = listC[rnd.Next(0, listC.Count)];
                    }
                    else
                    {
                        return;
                    }
                    truck.LigaDesligaLimpador();
                    break;
                case 3:
                    var listA = AvioesDAO.GetAll();
                    if (listA == null)
                    {
                        return;
                    }
                    Aviao plane;
                    if (listA.Count == 1)
                    {
                        plane = listA[0];
                    }
                    else if (listA.Count > 1)
                    {
                        plane = listA[rnd.Next(0, listA.Count)];
                    }
                    else
                    {
                        return;
                    }
                    plane.LigaDesligaLimpador();
                    break;
                case 4:
                    var listAG = AviaoGuerraDAO.GetAll();
                    if (listAG == null)
                    {
                        return;
                    }
                    AviaoGuerra planeG;
                    if (listAG.Count == 1)
                    {
                        planeG = listAG[0];
                    }
                    else if (listAG.Count > 1)
                    {
                        planeG = listAG[rnd.Next(0, listAG.Count)];
                    }
                    else
                    {
                        return;
                    }
                    planeG.LigaDesligaLimpador();
                    break;
                case 5:
                    var listN = NaviosDAO.GetAll();
                    if (listN == null)
                    {
                        return;
                    }
                    Navio ship;
                    if (listN.Count == 1)
                    {
                        ship = listN[0];
                    }
                    else if (listN.Count > 1)
                    {
                        ship = listN[rnd.Next(0, listN.Count)];
                    }
                    else
                    {
                        return;
                    }
                    ship.LigaDesligaLimpador();
                    break;
                case 6:
                    var listNG = NavioGuerraDAO.GetAll();
                    if (listNG == null)
                    {
                        return;
                    }
                    NavioGuerra shipG;
                    if (listNG.Count == 1)
                    {
                        shipG = listNG[0];
                    }
                    else if (listNG.Count > 1)
                    {
                        shipG = listNG[rnd.Next(0, listNG.Count)];
                    }
                    else
                    {
                        return;
                    }
                    shipG.LigaDesligaLimpador();
                    break;
                case 7:
                    var listT = TrensDAO.GetAll();
                    if (listT == null)
                    {
                        return;
                    }
                    Trem train;
                    if (listT.Count == 1)
                    {
                        train = listT[0];
                    }
                    else if (listT.Count > 1)
                    {
                        train = listT[rnd.Next(0, listT.Count)];
                    }
                    else
                    {
                        return;
                    }
                    train.LigaDesligaLimpador();
                    break;
            }

            //Veiculo veiculo1 = (Veiculo)veiculo;
            //menu.Text(veiculo1.Id, 10);
        }

        public void Pedagio()
        {
            switch (rnd.Next(1, 5))
            {
                case 1:
                    var list = CarrosDAO.GetAll();

                    if (list == null)
                    {
                        return;
                    }

                    Carro car;
                    if (list.Count == 1)
                    {
                        car = list[0];
                    }
                    else if (list.Count > 1)
                    {
                        car = list[rnd.Next(0, list.Count)];
                    }
                    else
                    {
                        return;
                    }
                    car.Pedagio();

                    break;
                case 2:
                    var lista = CaminhoesDAO.GetAll();

                    if (lista == null)
                    {
                        return;
                    }
                    Caminhao truck;
                    if (lista.Count == 1)
                    {
                        truck = lista[0];
                    }
                    else if (lista.Count > 1)
                    {
                        truck = lista[rnd.Next(0, lista.Count)];
                    }
                    else
                    {
                        return;
                    }
                    truck.Pedagio();

                    break;
                case 3:
                    var listB = OnibusDAO.GetAll();

                    if (listB == null)
                    {
                        return;
                    }

                    Onibus bus;
                    if (listB.Count == 1)
                    {
                        bus = listB[0];
                    }
                    else if (listB.Count > 1)
                    {
                        bus = listB[rnd.Next(0, listB.Count)];
                    }
                    else
                    {
                        return;
                    }
                    bus.Pedagio();

                    break;
                case 4:
                    var listM = MotosDAO.GetAll();

                    if (listM == null)
                    {
                        return;
                    }

                    Moto moto;

                    if (listM.Count == 1)
                    {
                        moto = listM[0];
                    }
                    else if (listM.Count > 1)
                    {
                        moto = listM[rnd.Next(0, listM.Count)];
                    }
                    else
                    {
                        return;
                    }
                    moto.Pedagio();

                    break;
            }
        }

        public void Pousar()
        {
            switch (rnd.Next(0, 2))
            {
                case 0:
                    var list = AvioesDAO.GetAll();

                    if (list == null)
                    {
                        return;
                    }

                    Aviao aviao;
                    if (list.Count == 1)
                    {
                        aviao = list[0];
                    }
                    else if (list.Count > 1)
                    {
                        aviao = list[rnd.Next(0, list.Count)];
                    }
                    else
                    {
                        return;
                    }

                    aviao.Pousar();
                    break;

                case 1:
                    var lista = AviaoGuerraDAO.GetAll();

                    if (lista == null)
                    {
                        return;
                    }

                    AviaoGuerra plane;

                    if (lista.Count == 1)
                    {
                        plane = lista[0];
                    }
                    else if (lista.Count > 1)
                    {
                        plane = lista[rnd.Next(0, lista.Count)];
                    }
                    else
                    {
                        return;
                    }
                    plane.Pousar();

                    break;
            }

        }

        public void Reduzir()
        {
            switch (rnd.Next(0, 9))
            {
                case 0:
                    var list = CarrosDAO.GetAll();
                    if (list == null)
                    {
                        return;
                    }

                    Carro car;
                    if (list.Count == 1)
                    {
                        car = list[0];
                    }
                    else if (list.Count > 1)
                    {
                        car = list[rnd.Next(0, list.Count)];
                    }
                    else
                    {
                        return;
                    }
                    car.Desacelera();
                    break;
                case 1:
                    var listM = MotosDAO.GetAll();
                    if (listM == null)
                    {
                        return;
                    }

                    Moto bike;
                    if (listM.Count == 1)
                    {
                        bike = listM[0];
                    }
                    else if (listM.Count > 1)
                    {
                        bike = listM[rnd.Next(0, listM.Count)];
                    }
                    else
                    {
                        return;
                    }
                    bike.Desacelera();
                    break;
                case 2:
                    var listB = OnibusDAO.GetAll();
                    if (listB == null)
                    {
                        return;
                    }
                    Onibus bus;
                    if (listB.Count == 1)
                    {
                        bus = listB[0];
                    }
                    else if (listB.Count > 1)
                    {
                        bus = listB[rnd.Next(0, listB.Count)];
                    }
                    else
                    {
                        return;
                    }
                    bus.Desacelera();
                    break;
                case 3:
                    var listC = CaminhoesDAO.GetAll();
                    if (listC == null)
                    {
                        return;
                    }
                    Caminhao truck;

                    if (listC.Count == 1)
                    {
                        truck = listC[0];
                    }
                    else if (listC.Count > 1)
                    {
                        truck = listC[rnd.Next(0, listC.Count)];
                    }
                    else
                    {
                        return;
                    }
                    truck.Desacelera();
                    break;
                case 4:
                    var listA = AvioesDAO.GetAll();
                    if (listA == null)
                    {
                        return;
                    }
                    Aviao plane;
                    if (listA.Count == 1)
                    {
                        plane = listA[0];
                    }
                    else if (listA.Count > 1)
                    {
                        plane = listA[rnd.Next(0, listA.Count)];
                    }
                    else
                    {
                        return;
                    }
                    plane.Desacelera();
                    break;
                case 5:
                    var listAG = AviaoGuerraDAO.GetAll();
                    if (listAG == null)
                    {
                        return;
                    }
                    AviaoGuerra planeG;
                    if (listAG.Count == 1)
                    {
                        planeG = listAG[0];
                    }
                    else if (listAG.Count > 1)
                    {
                        planeG = listAG[rnd.Next(0, listAG.Count)];
                    }
                    else
                    {
                        return;
                    }
                    planeG.Desacelera();
                    break;
                case 6:
                    var listN = NaviosDAO.GetAll();
                    if (listN == null)
                    {
                        return;
                    }
                    Navio ship;
                    if (listN.Count == 1)
                    {
                        ship = listN[0];
                    }
                    else if (listN.Count > 1)
                    {
                        ship = listN[rnd.Next(0, listN.Count)];
                    }
                    else
                    {
                        return;
                    }
                    ship.Desacelera();
                    break;
                case 7:
                    var listNG = NavioGuerraDAO.GetAll();
                    if (listNG == null)
                    {
                        return;
                    }
                    NavioGuerra shipG;
                    if (listNG.Count == 1)
                    {
                        shipG = listNG[0];
                    }
                    else if (listNG.Count > 1)
                    {
                        shipG = listNG[rnd.Next(0, listNG.Count)];
                    }
                    else
                    {
                        return;
                    }
                    shipG.Desacelera();
                    break;
                case 8:
                    var listT = TrensDAO.GetAll();
                    if (listT == null)
                    {
                        return;
                    }
                    Trem train;
                    if (listT.Count == 1)
                    {
                        train = listT[0];
                    }
                    else if (listT.Count > 1)
                    {
                        train = listT[rnd.Next(0, listT.Count)];
                    }
                    else
                    {
                        return;
                    }
                    train.Desacelera();
                    break;
            }


            //Veiculo veiculo1 = (Veiculo)veiculo;
            //menu.Text(veiculo1.Id, 13);
        }

        public void Remover()
        {
            switch (rnd.Next(0, 9))
            {
                case 0:
                    var list = CarrosDAO.GetAll();
                    if (list == null)
                    {
                        return;
                    }

                    Carro car;
                    if (list.Count == 1)
                    {
                        car = list[0];
                    }
                    else if (list.Count > 1)
                    {
                        car = list[rnd.Next(0, list.Count)];
                    }
                    else
                    {
                        return;
                    }
                    CarrosDAO.Delete(car);
                    break;
                case 1:
                    var listM = MotosDAO.GetAll();
                    if (listM == null)
                    {
                        return;
                    }

                    Moto bike;
                    if (listM.Count == 1)
                    {
                        bike = listM[0];
                    }
                    else if (listM.Count > 1)
                    {
                        bike = listM[rnd.Next(0, listM.Count)];
                    }
                    else
                    {
                        return;
                    }
                    MotosDAO.Delete(bike);
                    break;
                case 2:
                    var listB = OnibusDAO.GetAll();
                    if (listB == null)
                    {
                        return;
                    }
                    Onibus bus;
                    if (listB.Count == 1)
                    {
                        bus = listB[0];
                    }
                    else if (listB.Count > 1)
                    {
                        bus = listB[rnd.Next(0, listB.Count)];
                    }
                    else
                    {
                        return;
                    }
                    OnibusDAO.Delete(bus);
                    break;
                case 3:
                    var listC = CaminhoesDAO.GetAll();
                    if (listC == null)
                    {
                        return;
                    }
                    Caminhao truck;

                    if (listC.Count == 1)
                    {
                        truck = listC[0];
                    }
                    else if (listC.Count > 1)
                    {
                        truck = listC[rnd.Next(0, listC.Count)];
                    }
                    else
                    {
                        return;
                    }
                    CaminhoesDAO.Delete(truck);
                    break;
                case 4:
                    var listA = AvioesDAO.GetAll();
                    if (listA == null)
                    {
                        return;
                    }
                    Aviao plane;
                    if (listA.Count == 1)
                    {
                        plane = listA[0];
                    }
                    else if (listA.Count > 1)
                    {
                        plane = listA[rnd.Next(0, listA.Count)];
                    }
                    else
                    {
                        return;
                    }
                    AvioesDAO.Delete(plane);
                    break;
                case 5:
                    var listAG = AviaoGuerraDAO.GetAll();
                    if (listAG == null)
                    {
                        return;
                    }
                    AviaoGuerra planeG;
                    if (listAG.Count == 1)
                    {
                        planeG = listAG[0];
                    }
                    else if (listAG.Count > 1)
                    {
                        planeG = listAG[rnd.Next(0, listAG.Count)];
                    }
                    else
                    {
                        return;
                    }
                    AviaoGuerraDAO.Delete(planeG);
                    break;
                case 6:
                    var listN = NaviosDAO.GetAll();
                    if (listN == null)
                    {
                        return;
                    }
                    Navio ship;
                    if (listN.Count == 1)
                    {
                        ship = listN[0];
                    }
                    else if (listN.Count > 1)
                    {
                        ship = listN[rnd.Next(0, listN.Count)];
                    }
                    else
                    {
                        return;
                    }
                    NaviosDAO.Delete(ship);
                    break;
                case 7:
                    var listNG = NavioGuerraDAO.GetAll();
                    if (listNG == null)
                    {
                        return;
                    }
                    NavioGuerra shipG;
                    if (listNG.Count == 1)
                    {
                        shipG = listNG[0];
                    }
                    else if (listNG.Count > 1)
                    {
                        shipG = listNG[rnd.Next(0, listNG.Count)];
                    }
                    else
                    {
                        return;
                    }
                    NavioGuerraDAO.Delete(shipG);
                    break;
                case 8:
                    var listT = TrensDAO.GetAll();
                    if (listT == null)
                    {
                        return;
                    }
                    Trem train;
                    if (listT.Count == 1)
                    {
                        train = listT[0];
                    }
                    else if (listT.Count > 1)
                    {
                        train = listT[rnd.Next(0, listT.Count)];
                    }
                    else
                    {
                        return;
                    }
                    TrensDAO.Delete(train);
                    break;
            }
        }
    }
}
