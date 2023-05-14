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
    public class NaviosDAO
    {
        static string DataNavio = Environment.CurrentDirectory + @"\DataFiles\DataNavios.json";

        public static void Save(Navio veiculo)
        {
            try
            {
                string json = File.ReadAllText(DataNavio);
                List<Navio> JObject;

                if (json == "")
                {
                    JObject = new List<Navio>();
                }
                else
                {
                    JObject = JsonConvert.DeserializeObject<List<Navio>>(json).ToList();
                }

                JObject.Add(veiculo);

                string novoJsonResult = JsonConvert.SerializeObject(JObject, Formatting.Indented);
                File.WriteAllText(DataNavio, novoJsonResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar avião");
            }
        }
        public static void Delete(Navio veiculo)
        {
            try
            {
                var json = File.ReadAllText(DataNavio);
                List<Navio> jObject = JsonConvert.DeserializeObject<List<Navio>>(json).ToList();

                jObject.Remove(veiculo);

                var saida = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                File.WriteAllText(DataNavio, saida);
            }
            catch
            {
                Console.WriteLine("Erro ao excluir avião");
            }
        }
        public static void Edit(Navio veiculo)
        {
            try
            {
                string json = File.ReadAllText(DataNavio);
                List<Navio> jObject = JsonConvert.DeserializeObject<List<Navio>>(json).ToList();

                Navio antigo = jObject.Where(id => id.Id == veiculo.Id).FirstOrDefault();

                antigo = veiculo;

                string novoJsonResult = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                File.WriteAllText(DataNavio, novoJsonResult);
            }
            catch
            {
                Console.WriteLine("Erro ao editar avião");
            }
        }
        public static List<Navio> GetAll()
        {
            try
            {
                string json = File.ReadAllText(DataNavio);
                List<Navio> jObject = JsonConvert.DeserializeObject<List<Navio>>(json).ToList();
                return jObject;
            }
            catch
            {
                return null;
            }
        }
    }
}
