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
    public class OnibusDAO
    {
        static string DataOnibus = Environment.CurrentDirectory + @"\DataFiles\DataOnibus.json";

        public static void Save(Onibus veiculo)
        {
            try
            {
                string json = File.ReadAllText(DataOnibus);
                List<Onibus> JObject;

                if (json == "")
                {
                    JObject = new List<Onibus>();
                }
                else
                {
                    JObject = JsonConvert.DeserializeObject<List<Onibus>>(json).ToList();
                }

                JObject.Add(veiculo);

                string novoJsonResult = JsonConvert.SerializeObject(JObject, Formatting.Indented);
                File.WriteAllText(DataOnibus, novoJsonResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar ônibus");
            }
        }
        public static void Delete(Onibus veiculo)
        {
            try
            {
                string json = File.ReadAllText(DataOnibus);
                List<Onibus> JObject;

                if (json == "")
                {
                    JObject = new List<Onibus>();
                }
                else
                {
                    JObject = JsonConvert.DeserializeObject<List<Onibus>>(json).ToList();
                }

                JObject.Remove(veiculo);

                string novoJsonResult = JsonConvert.SerializeObject(JObject, Formatting.Indented);
                File.WriteAllText(DataOnibus, novoJsonResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar ônibus");
            }
        }
        public static void Edit(Onibus veiculo)
        {
            try
            {
                string json = File.ReadAllText(DataOnibus);
                List<Onibus> jObject = JsonConvert.DeserializeObject<List<Onibus>>(json).ToList();

                Onibus antigo = jObject.Where(id => id.Id == veiculo.Id).FirstOrDefault();

                antigo = veiculo;

                string novoJsonResult = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                File.WriteAllText(DataOnibus, novoJsonResult);
            }
            catch
            {

            }
        }
        public static List<Onibus> GetAll()
        {
            try
            {
                string json = File.ReadAllText(DataOnibus);
                List<Onibus> jObject = JsonConvert.DeserializeObject<List<Onibus>>(json).ToList();
                return jObject;
            }
            catch
            {
                return null;
            }
        }
    }
}
