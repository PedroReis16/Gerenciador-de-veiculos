﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_veículos.Interface
{
    public interface IVeiculosTerrestres : IVeiculos
    {
        void PagarPedagio();
    }
}