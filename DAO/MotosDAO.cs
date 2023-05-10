using Gerenciador_de_veículos.Objects;
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
    public class MotosDAO
    {
        static string DataMoto = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"DataFiles\DataMotos.JSON";

        public static void Save(Moto veiculo)
        {
            try
            {
                string json = File.ReadAllText(DataMoto);
                var JObject = JsonConvert.DeserializeObject<List<Moto>>(json).ToList();

                JObject.Add(veiculo);

                string novoJsonResult = JsonConvert.SerializeObject(JObject, Formatting.Indented);
                File.WriteAllText(DataMoto, novoJsonResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar carro");
            }
        }
        public static void Delete(Moto veiculo)
        {
            try
            {
                var json = File.ReadAllText(DataMoto);
                List<Moto> jObject = JsonConvert.DeserializeObject<List<Moto>>(json).ToList();

                jObject.Remove(veiculo);

                var saida = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                File.WriteAllText(DataMoto, saida);
            }
            catch
            {
                Console.WriteLine("Erro ao excluir carro");
            }
        }
        public static void Edit(Moto veiculo)
        {
            try
            {
                string json = File.ReadAllText(DataMoto);
                List<Moto> jObject = JsonConvert.DeserializeObject<List<Moto>>(json).ToList();

                Moto antigo = jObject.Where(id => id.Id == veiculo.Id).FirstOrDefault();

                antigo = veiculo;

                string novoJsonResult = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                File.WriteAllText(DataMoto, novoJsonResult);
            }
            catch
            {
                Console.WriteLine("Error ao editar moto");
            }
        }
        public static List<Moto> GetAll()
        {
            try
            {
                string json = File.ReadAllText(DataMoto);
                List<Moto> jObject = JsonConvert.DeserializeObject<List<Moto>>(json).ToList();
                return jObject;
            }
            catch
            {
                return null;
            }
        }
    }
}
