using Gerenciador_de_veículos.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_veículos.Objects
{
    public class Pedagio
    {
        public string Id { get; set; }
        public string Localização { get; set; }
        public double Ganhos { get; set; }

        public void Receber(double valor)
        {
            Pedagio pedagio = PedagioDAO.GetAll().Where(x=> x.Id == Id).FirstOrDefault();
            pedagio.Ganhos += valor;

            PedagioDAO.Edit(pedagio);
        }
    }
}
