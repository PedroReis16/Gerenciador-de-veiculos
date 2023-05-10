using Gerenciador_de_veículos.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Gerenciador_de_veículos.DAO
{
    public class TrensDAO
    {
        public static string DataNavio = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\DataFiles\DataTrens.JSON";

        public static void Save(Trem veiculo)
        {
            try
            {
                string json = File.ReadAllText(DataNavio);
                var JObject = JsonConvert.DeserializeObject<List<Trem>>(json).ToList();

                JObject.Add(veiculo);

                string novoJsonResult = JsonConvert.SerializeObject(JObject, Formatting.Indented);
                File.WriteAllText(DataNavio, novoJsonResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar avião");
            }
        }
        public static void Delete(Trem veiculo)
        {
            try
            {
                var json = File.ReadAllText(DataNavio);
                List<Trem> jObject = JsonConvert.DeserializeObject<List<Trem>>(json).ToList();

                jObject.Remove(veiculo);

                var saida = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                File.WriteAllText(DataNavio, saida);
            }
            catch
            {
                Console.WriteLine("Erro ao excluir avião");
            }
        }
        public static void Edit(Trem veiculo)
        {
            try
            {
                string json = File.ReadAllText(DataNavio);
                List<Trem> jObject = JsonConvert.DeserializeObject<List<Trem>>(json).ToList();

                Trem antigo = jObject.Where(id => id.Id == veiculo.Id).FirstOrDefault();

                antigo = veiculo;

                string novoJsonResult = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                File.WriteAllText(DataNavio, novoJsonResult);
            }
            catch
            {
                Console.WriteLine("Erro ao editar avião");
            }
        }
        public static List<Trem> GetAll()
        {
            try
            {
                string json = File.ReadAllText(DataNavio);
                List<Trem> jObject = JsonConvert.DeserializeObject<List<Trem>>(json).ToList();
                return jObject;
            }
            catch
            {
                return null;
            }
        }
    }
}
