using Gerenciador_de_veículos.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            try
            {
                string json = File.ReadAllText(DataCarro);
                var JObject = JsonConvert.DeserializeObject<List<Carro>>(json).ToList();

                JObject.Add(carro);

                string novoJsonResult = JsonConvert.SerializeObject(JObject, Formatting.Indented);
                File.WriteAllText(DataCarro, novoJsonResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar carro");
            }
        }
        public void Delete(Carro carro)
        {
            try
            {
                var json = File.ReadAllText(DataCarro);
                List<Carro> jObject = JsonConvert.DeserializeObject<List<Carro>>(json).ToList();

                jObject.Remove(carro);

                var saida = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                File.WriteAllText(DataCarro, saida);
            }
            catch
            {
                Console.WriteLine("Erro ao excluir carro");
            }
        }
        public void Edit(Carro carro)
        {
            try
            {
                string json = File.ReadAllText(DataCarro);
                List<Carro> jObject = JsonConvert.DeserializeObject<List<Carro>>(json).ToList();

                Carro antigo = jObject.Where(id => id.Id == carro.Id).FirstOrDefault();

                antigo = carro;

                string novoJsonResult = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                File.WriteAllText(DataCarro, novoJsonResult);
            }
            catch
            {
                Console.WriteLine("Erro ao editar avião");
            }
        }
        public List<Carro> GetAll()
        {
            try
            {
                string json = File.ReadAllText(DataCarro);
                List<Carro> jObject = JsonConvert.DeserializeObject<List<Carro>>(json).ToList();
                return jObject;
            }
            catch
            {
                return null;
            }
        }
    }
}
