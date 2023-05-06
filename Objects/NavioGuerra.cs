using Gerenciador_de_veículos.Interface;
using Gerenciador_de_veículos.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_veículos.Objects
{
    public class NavioGuerra : IVeiculos
    {
        public string Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Peso { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Velocidade { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CapacidadePagageitos { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Modelo Modelo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Acelera()
        {
            throw new NotImplementedException();
        }

        public void Desacelera()
        {
            throw new NotImplementedException();
        }
    }
}
