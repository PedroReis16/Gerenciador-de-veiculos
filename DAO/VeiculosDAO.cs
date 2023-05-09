using Gerenciador_de_veículos.Interface;
using System.Collections.Generic;
using System.Security.Policy;

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
        public static List<IVeiculos> GetAll()
        {
            List<IVeiculos> list = new List<IVeiculos>();

            list.AddRange(CarrosDAO.GetAll());
            list.AddRange(MotosDAO.GetAll());
            list.AddRange(OnibusDAO.GetAll());
            list.AddRange(CaminhoesDAO.GetAll());
            list.AddRange(AvioesDAO.GetAll());
            list.AddRange(AviaoGuerraDAO.GetAll());
            list.AddRange(AvioesDAO.GetAll());
            list.AddRange(AviaoGuerraDAO.GetAll());
            list.AddRange(NaviosDAO.GetAll());
            list.AddRange(NavioGuerraDAO.GetAll());
            list.AddRange(TrensDAO.GetAll());

            return list;
        }
        public static List<IVeiculos> GetAllRoadVehicles()
        {
            List<IVeiculos> list = new List<IVeiculos>();

            list.AddRange(CarrosDAO.GetAll());
            list.AddRange(MotosDAO.GetAll());
            list.AddRange(OnibusDAO.GetAll());
            list.AddRange(CaminhoesDAO.GetAll());

            return list;
        }
        public static List<IVeiculos> GetWarVehicles()
        {
            List<IVeiculos> list = new List<IVeiculos>();
            list.AddRange(AviaoGuerraDAO.GetAll());
            list.AddRange(NavioGuerraDAO.GetAll());
            return list;
        }
    }
}
