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
        static string DataCaminhao = Environment.CurrentDirectory + @"\DataFiles\DataCaminhoes.json";

        public static void Save(Caminhao veiculo)
        {
            try
            {
                string json = File.ReadAllText(DataCaminhao);
                List<Caminhao> JObject;

                if (json == "")
                {
                    JObject = new List<Caminhao>();
                }
                else
                {
                    JObject = JsonConvert.DeserializeObject<List<Caminhao>>(json).ToList();
                }

                JObject.Add(veiculo);

                string novoJsonResult = JsonConvert.SerializeObject(JObject, Formatting.Indented);
                File.WriteAllText(DataCaminhao, novoJsonResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar carro");
            }
        }
        public static void Delete(Caminhao veiculo)
        {
            try
            {
                string json = File.ReadAllText(DataCaminhao);
                List<Caminhao> JObject;

                if (json == "")
                {
                    JObject = new List<Caminhao>();
                }
                else
                {
                    JObject = JsonConvert.DeserializeObject<List<Caminhao>>(json).ToList();
                }

                JObject.Remove(veiculo);

                string novoJsonResult = JsonConvert.SerializeObject(JObject, Formatting.Indented);
                File.WriteAllText(DataCaminhao, novoJsonResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar carro");
            }
        }
        public static void Edit(Caminhao veiculo)
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
        public static List<Caminhao> GetAll()
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
