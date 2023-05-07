using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_veículos.Objects
{
    public class Pagamento
    {
        string IdPedagio { get; set; }
        string placa { get; set; }
        double valor { get; set; }
        DateTime data { get; set; }
    }
}
