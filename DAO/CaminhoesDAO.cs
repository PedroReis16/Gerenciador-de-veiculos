using Gerenciador_de_veículos.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_veículos.DAO
{
    public class CaminhoesDAO
    {
        string DataCaminhao = Environment.CurrentDirectory.Replace(@"\bin\Debug", "") + @"DataFiles\DataCaminhoes.JSON";

        public void Save(Caminhao veiculo)
        {
            try
            {
                string json = File.ReadAllText(DataCaminhao);
                var JObject = JsonConvert.DeserializeObject<List<Caminhao>>(json).ToList();

                JObject.Add(veiculo);

                string novoJsonResult = JsonConvert.SerializeObject(JObject, Formatting.Indented);
                File.WriteAllText(DataCaminhao, novoJsonResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar carro");
            }
        }
        public void Delete(Caminhao veiculo)
        {
            try
            {
                var json = File.ReadAllText(DataCaminhao);
                List<Caminhao> jObject = JsonConvert.DeserializeObject<List<Caminhao>>(json).ToList();

                jObject.Remove(veiculo);

                var saida = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                File.WriteAllText(DataCaminhao, saida);
            }
            catch
            {
                Console.WriteLine("Erro ao excluir carro");
            }
        }
        public void Edit(Caminhao veiculo)
        {
            try
            {
                string json = File.ReadAllText(DataCaminhao);
                List<Caminhao> jObject = JsonConvert.DeserializeObject<List<Caminhao>>(json).ToList();

                Caminhao antigo = jObject.Where(id => id.Id == veiculo.Id).FirstOrDefault();

                antigo = veiculo;

                string novoJsonResult = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                File.WriteAllText(DataCaminhao, novoJsonResult);
            }
            catch
            {
                Console.WriteLine("Erro ao editar caminhão");
            }
        }
        public List<Caminhao> GetAll()
        {
            try
            {
                string json = File.ReadAllText(DataCaminhao);
                List<Caminhao> jObject = JsonConvert.DeserializeObject<List<Caminhao>>(json).ToList();
                return jObject;
            }
            catch
            {
                return null;
            }
        }
    }
}
