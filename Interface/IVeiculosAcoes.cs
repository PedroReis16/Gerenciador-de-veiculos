using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_veículos.Interface
{
    public interface IVeiculosAcoes
    {
        void Adicionar();
        void Remover();
        void Acelerar();
        void Reduzir();
        void Limpador();
        void Pedagio();
        void Carregar();
        void Descarregar();
        void Empinar();
        void Pousar();
        void Decolar();
        void Arremeter();
        void Atacar();
        void Atracar();
    }
}
