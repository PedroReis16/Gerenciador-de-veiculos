using Gerenciador_de_veículos.Objects;
using Gerenciador_de_veículos.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_veículos.DAO
{
    public class ModelosDAO
    {
        static string DataAviao = Environment.CurrentDirectory.Replace(@"\bin\Debug", "") + @"DataFiles\DataModelos.JSON";

        public static void Save(Modelo modelo)
        {
            try
            {
                string json = File.ReadAllText(DataAviao);
                var JObject = JsonConvert.DeserializeObject<List<Modelo>>(json).ToList();

                JObject.Add(modelo);

                string novoJsonResult = JsonConvert.SerializeObject(JObject, Formatting.Indented);
                File.WriteAllText(DataAviao, novoJsonResult);
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
                var json = File.ReadAllText(DataAviao);
                List<Modelo> jObject = JsonConvert.DeserializeObject<List<Modelo>>(json).ToList();

                jObject.Remove(modelo);

                var saida = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                File.WriteAllText(DataAviao, saida);
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
                string json = File.ReadAllText(DataAviao);
                List<Modelo> jObject = JsonConvert.DeserializeObject<List<Modelo>>(json).ToList();

                Modelo antigo = jObject.Where(id => id.Codigo == modelo.Codigo).FirstOrDefault();

                antigo = modelo;

                string novoJsonResult = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                File.WriteAllText(DataAviao, novoJsonResult);
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
                string json = File.ReadAllText(DataAviao);
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
