using Gerenciador_de_veículos.DAO;
using Gerenciador_de_veículos.Fonts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_veículos.Services
{
    public class IdentificadorAviao
    { // Classe responsável por gerar o ID dos aviões - prefixo + 5 letras - BRABCDE
        public static string GerarMatricula()
        {
            List<Veiculo> list = VeiculosDAO.GetAllPlanes().ConvertAll(x => (Veiculo)x);

            while (true)
            {
                string matricula = GerarCombinacao();

                if (list.FindAll(i => i.Id.Equals(matricula)).Count == 0)
                {
                    return matricula;
                }
            }
        }

        private  static string GerarCombinacao()
        {
            Random random = new Random();
            string[] letras = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string[] prefixos = new string[] { "BR", "PT", "US", "CA", "MX", "FR", "DE", "IT", "ES", "GB", "JP", "CN", "RU" };

            string matricula;
            string prefixo = prefixos[random.Next(0, prefixos.Length)];

            matricula = prefixo;

            for (int i = 0; i < 5; i++)
            {
                int k = random.Next(0, letras.Length);
                matricula += letras[k];
            }
            return matricula;
        }
    }
}
