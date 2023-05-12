using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_veículos.Fonts
{
    public abstract class VeiculoFechado : Veiculo
    {
        public bool Limpador { get; set; }

        public void LigaDesligaLimpador()
        {
            Limpador = !Limpador;
        }
    }
}
