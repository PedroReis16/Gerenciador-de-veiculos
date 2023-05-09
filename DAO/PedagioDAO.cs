using Gerenciador_de_veículos.Objects;
using Gerenciador_de_veículos.Service;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_veículos.DAO
{
    public class PedagioDAO
    {
        static string DataPedagio = Environment.CurrentDirectory.Replace(@"\bin\Debug", "") + @"DataFiles\DataPedagio.JSON";

        public static void Save(Pedagio pedagio)
        {
            try
            {
                string json = File.ReadAllText(DataPedagio);
                var JObject = JsonConvert.DeserializeObject<List<Pedagio>>(json).ToList();

                JObject.Add(pedagio);

                string novoJsonResult = JsonConvert.SerializeObject(JObject, Formatting.Indented);
                File.WriteAllText(DataPedagio, novoJsonResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar avião");
            }
        }
        public static void Delete(Pedagio pedagio)
        {
            try
            {
                var json = File.ReadAllText(DataPedagio);
                List<Pedagio> jObject = JsonConvert.DeserializeObject<List<Pedagio>>(json).ToList();

                jObject.Remove(pedagio);

                var saida = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                File.WriteAllText(DataPedagio, saida);
            }
            catch
            {
                Console.WriteLine("Erro ao excluir pedágio");
            }
        }
        public static void Edit(Pedagio pedagio)
        {
            try
            {
                string json = File.ReadAllText(DataPedagio);
                List<Pedagio> jObject = JsonConvert.DeserializeObject<List<Pedagio>>(json).ToList();

                Pedagio antigo = jObject.Where(x => x.Id == pedagio.Id).FirstOrDefault();

                antigo = pedagio;

                string novoJsonResult = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                File.WriteAllText(DataPedagio, novoJsonResult);
            }
            catch
            {
                Console.WriteLine("Erro ao editar pedágio");
            }
        }
        public static List<Pedagio> GetAll()
        {
            try
            {
                string json = File.ReadAllText(DataPedagio);
                List<Pedagio> jObject = JsonConvert.DeserializeObject<List<Pedagio>>(json).ToList();
                return jObject;
            }
            catch
            {
                return null;
            }
        }
    }
}
