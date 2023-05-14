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
    public class MotosDAO
    {
        static string DataMoto = Environment.CurrentDirectory + @"\DataFiles\DataMotos.json";

        public static void Save(Moto veiculo)
        {
            try
            {
                string json = File.ReadAllText(DataMoto);
                List<Moto> JObject;

                if (json == "")
                {
                    JObject = new List<Moto>();
                }
                else
                {
                    JObject = JsonConvert.DeserializeObject<List<Moto>>(json).ToList();
                }

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
                string json = File.ReadAllText(DataMoto);
                List<Moto> JObject;

                if (json == "")
                {
                    JObject = new List<Moto>();
                }
                else
                {
                    JObject = JsonConvert.DeserializeObject<List<Moto>>(json).ToList();
                }

                JObject.Remove(veiculo);

                string novoJsonResult = JsonConvert.SerializeObject(JObject, Formatting.Indented);
                File.WriteAllText(DataMoto, novoJsonResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar carro");
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
