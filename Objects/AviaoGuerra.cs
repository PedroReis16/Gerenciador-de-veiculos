using Gerenciador_de_veículos.Fonts;
using Gerenciador_de_veículos.Services;

namespace Gerenciador_de_veículos.Objects
{
    public class AviaoGuerra : VeiculoFechado, IAviao
    {
        public AviaoGuerra()
        {
            Id = IdentificadorAviao.GerarMatricula();
        }

        public void Arremetar()
        {
           
        }

        public void Decolar()
        {
           
        }

        public void Pousar()
        {
            
        }
        public void Atacar()
        {

        }
    }
}
