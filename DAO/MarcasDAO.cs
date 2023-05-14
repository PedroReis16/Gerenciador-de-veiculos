using Gerenciador_de_veículos.Objects;
using Gerenciador_de_veículos.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Gerenciador_de_veículos.DAO
{
    public class MarcasDAO
    {
        static string DataMarcas = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\DataFiles\DataMarcas.JSON";

        public static void Save(Marca marca)
        {
            try
            {
                string json = File.ReadAllText(DataMarcas);
                var JObject = JsonConvert.DeserializeObject<List<Marca>>(json).ToList();

                JObject.Add(marca);

                string novoJsonResult = JsonConvert.SerializeObject(JObject, Formatting.Indented);
                File.WriteAllText(DataMarcas, novoJsonResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar avião");
            }
        }
        public static void Delete(Marca marca)
        {
            try
            {
                var json = File.ReadAllText(DataMarcas);
                List<Marca> jObject = JsonConvert.DeserializeObject<List<Marca>>(json).ToList();

                jObject.Remove(marca);

                var saida = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                File.WriteAllText(DataMarcas, saida);
            }
            catch
            {
                Console.WriteLine("Erro ao excluir avião");
            }
        }
        public static void Edit(Marca marca)
        {
            try
            {
                string json = File.ReadAllText(DataMarcas);
                List<Marca> jObject = JsonConvert.DeserializeObject<List<Marca>>(json).ToList();

                Marca antigo = jObject.Where(id => id.Id == marca.Id).FirstOrDefault();

                antigo = marca;

                string novoJsonResult = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                File.WriteAllText(DataMarcas, novoJsonResult);
            }
            catch
            {
                Console.WriteLine("Erro ao editar avião");
            }
        }
        public static List<Marca> GetAll()
        {
            try
            {
                string json = File.ReadAllText(DataMarcas);
                List<Marca> jObject = JsonConvert.DeserializeObject<List<Marca>>(json).ToList();
                return jObject;
            }
            catch
            {
                return null;
            }
        }
    }
}
