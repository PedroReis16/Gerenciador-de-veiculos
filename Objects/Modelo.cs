using Gerenciador_de_veículos.Enums;
using Gerenciador_de_veículos.Objects;

namespace Gerenciador_de_veículos.Service
{
    public class Modelo
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public Marca Marca { get; set; }
        public TipoVeiculo Tipo { get; set; }
    }
}
