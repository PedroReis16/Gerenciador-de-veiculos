using Gerenciador_de_veículos.Interface;
using Gerenciador_de_veículos.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_veículos.DAO
{
    public class VeiculosDAO
    {
        public static List<IVeiculos> GetAllVehicles()
        {
            List<IVeiculos> list = new List<IVeiculos>();

            list.AddRange(CarrosDAO.GetAll());
            list.AddRange(MotosDAO.GetAll());
            list.AddRange(OnibusDAO.GetAll());
            list.AddRange(CaminhoesDAO.GetAll());

            return list;
        }
        public static List<IVeiculos> GetAllPlanes()
        {
            List<IVeiculos> list = new List<IVeiculos>();

            list.AddRange(AvioesDAO.GetAll());
            list.AddRange(AviaoGuerraDAO.GetAll());

            return list;
        }

        public static List<IVeiculos> GetAllShips()
        {
            List<IVeiculos> list = new List<IVeiculos>();

            list.AddRange(NaviosDAO.GetAll());
            list.AddRange(NavioGuerraDAO.GetAll());

            return list;
        }
        public static List<IVeiculos> GetAllTrains()
        {
            List<IVeiculos> list = new List<IVeiculos>();

            list.AddRange(TrensDAO.GetAll());

            return list;
        }
    }
}
