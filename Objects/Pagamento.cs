using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_veículos.Objects
{
    public class Pagamento
    {
        public int Id { get; set; }
        public string IdPedagio { get; set; }
        public string Placa { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }
    }
}
