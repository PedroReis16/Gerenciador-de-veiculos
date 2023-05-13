using Gerenciador_de_veículos.DAO;
using Gerenciador_de_veículos.Fonts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_veículos.Services
{
    public class IdentificadorNavio
    {//Gera o identificar para os navios
        public static string GerarMatricula()
        {
            List<Veiculo> list = VeiculosDAO.GetAllShips().ConvertAll(x => (Veiculo)x);

            while (true)
            {
                string matricula = GerarCombinacao();

                if (list.FindAll(i => i.Id.Equals(matricula)).Count == 0)
                {
                    return matricula;
                }
            }
        }

        private static string GerarCombinacao()
        {
            string matricula = "IMO";
            Random random = new Random();

            for (int i=0; i < 4; i++)
            {
                matricula += random.Next(0, 10).ToString();
            }
            return matricula;
        }
    }
}
