using Gerenciador_de_veículos.Objects;
using Gerenciador_de_veículos.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_veículos.DAO
{
    public class ModelosDAO
    {
        static string DataModelo = Environment.CurrentDirectory+ @"\DataFiles\DataModelos.json";

        public static void Save(List<Modelo> modelo)
        {
            try
            {
                //string json = File.ReadAllText(DataMarcas);
                //var JObject = JsonConvert.DeserializeObject<List<Marca>>(json).ToList();

                //JObject.Add(marca);
                JsonSerializerSettings cfg = new JsonSerializerSettings();
                cfg.TypeNameHandling = TypeNameHandling.All;

                string dado = JsonConvert.SerializeObject(modelo, cfg);

                //string novoJsonResult = JsonConvert.SerializeObject(JObject, Formatting.Indented);
                //string novoJsonResult = JsonConvert.SerializeObject(dado, Formatting.Indented);
                File.WriteAllText(DataModelo, dado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar avião");
            }
        }
        public static void Delete(Modelo modelo)
        {
            try
            {
                var json = File.ReadAllText(DataModelo);
                List<Modelo> jObject = JsonConvert.DeserializeObject<List<Modelo>>(json).ToList();

                jObject.Remove(modelo);

                var saida = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                File.WriteAllText(DataModelo, saida);
            }
            catch
            {
                Console.WriteLine("Erro ao excluir avião");
            }
        }
        public static void Edit(Modelo modelo)
        {
            try
            {
                string json = File.ReadAllText(DataModelo);
                List<Modelo> jObject = JsonConvert.DeserializeObject<List<Modelo>>(json).ToList();

                Modelo antigo = jObject.Where(id => id.Codigo == modelo.Codigo).FirstOrDefault();

                antigo = modelo;

                string novoJsonResult = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                File.WriteAllText(DataModelo, novoJsonResult);
            }
            catch
            {
                Console.WriteLine("Erro ao editar avião");
            }
        }
        public static List<Modelo> GetAll()
        {
            try
            {
                string json = File.ReadAllText(DataModelo);
                List<Modelo> jObject = JsonConvert.DeserializeObject<List<Modelo>>(json).ToList();
                return jObject;
            }
            catch
            {
                return null;
            }
        }
    }
}
