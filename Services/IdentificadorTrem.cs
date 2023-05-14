using Gerenciador_de_veículos.DAO;
using Gerenciador_de_veículos.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_veículos.Services
{
    public class IdentificadorTrem
    {
        private static Random random = new Random();
        private static string[] letras = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        public static string GerarMatricula()
        {
            if (VeiculosDAO.GetAllTrains() == null)
            {
                return GerarCombinação();
            }
            List<Trem> list = VeiculosDAO.GetAllTrains().ConvertAll(x => (Trem)x);

            while (true)
            {
                string matricula = GerarCombinação();

                if (list.FindAll(i => i.Id.Equals(matricula)).Count() == 0)
                {
                    return matricula;
                }
            }
        }

        private static string GerarCombinação()
        {
            return CombinacaoLetras() + CombinacaoNumeros();
        }
        private static string CombinacaoLetras()
        {
            string combinacao = "";

            for (int i = 0; i < 3; i++)
            {
                int j = random.Next(0, 26);
                combinacao += letras[j];
            }

            return combinacao;
        }
        private static string CombinacaoNumeros()
        {
            string combinacao = "";
            for (int i = 0; i < 4; i++)
            {
                int j = random.Next(0, 10);
                combinacao += j.ToString();
            }
            return combinacao;
        }
    }
}
