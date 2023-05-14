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
    public class AvioesDAO
    {
        static string DataAviao = Environment.CurrentDirectory+ @"\DataFiles\DataAvioes.json";

        public static void Save(Aviao veiculo)
        {
            try
            {
                string json = File.ReadAllText(DataAviao);
                List<Aviao> JObject;

                if (json == "")
                {
                    JObject = new List<Aviao>();
                }
                else
                {
                    JObject = JsonConvert.DeserializeObject<List<Aviao>>(json).ToList();
                }

                JObject.Add(veiculo);

                string novoJsonResult = JsonConvert.SerializeObject(JObject, Formatting.Indented);
                File.WriteAllText(DataAviao, novoJsonResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar avião");
            }
        }
        public static void Delete(Aviao veiculo)
        {
            try
            {
                var json = File.ReadAllText(DataAviao);
                List<Aviao> jObject = JsonConvert.DeserializeObject<List<Aviao>>(json).ToList();

                jObject.Remove(veiculo);

                var saida = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                File.WriteAllText(DataAviao, saida);
            }
            catch
            {
                Console.WriteLine("Erro ao excluir avião");
            }
        }
        public static void Edit(Aviao veiculo)
        {
            try
            {
                string json = File.ReadAllText(DataAviao);
                List<Aviao> jObject = JsonConvert.DeserializeObject<List<Aviao>>(json).ToList();

                Aviao antigo = jObject.Where(id => id.Id == veiculo.Id).FirstOrDefault();

                antigo = veiculo;

                string novoJsonResult = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                File.WriteAllText(DataAviao, novoJsonResult);
            }
            catch
            {
                Console.WriteLine("Erro ao editar avião");
            }
        }
        public static List<Aviao> GetAll()
        {
            try
            {
                string json = File.ReadAllText(DataAviao);
                List<Aviao> jObject = JsonConvert.DeserializeObject<List<Aviao>>(json).ToList();
                return jObject;
            }
            catch
            {
                return null;
            }
        }
    }
}
