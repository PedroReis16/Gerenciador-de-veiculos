using Gerenciador_de_veículos.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Windows;

namespace Gerenciador_de_veículos.DAO
{
    public class CarrosDAO
    {
        string DataCarro = Environment.CurrentDirectory.Replace(@"\bin\Debug", "") + @"DataFiles\DataCarros.JSON";

        public void Save(Carro carro)
        {
            string NovoCarro = "{ " + 
                "Id: " + carro.Id +
                "Peso: " + carro.Peso +
                "Velocidade: " + carro.Velocidade +
                "CapacidadePassageiros: " + carro.CapacidadePassageiros +
                "Modelo: " + carro.Modelo +
                "Portas: " + carro.Portas +
                "Oficial: " + carro.Oficial +
                "Limpador: " + carro.Limpador + "}";
            try
            {
                var json = File.ReadAllText(DataCarro);
                var jsonObj = JObject.Parse(json);
                var novoCarro = JObject.Parse(NovoCarro);

                string novoJsonResult = JsonConvert.SerializeObject(jsonObj,Formatting.Indented);
                File.WriteAllText(DataCarro, novoJsonResult);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar carro");
            }
        }

    }
}
