using Gerenciador_de_veículos.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Windows;

namespace Gerenciador_de_veículos.DAO
{
    public class CarrosDAO
    {
        static string DataCarro = Environment.CurrentDirectory + @"\DataFiles\DataCarros.json";

        public static void Save(Carro carro)
        {
            try
            {
                string json = File.ReadAllText(DataCarro);
                List<Carro> lista;

                if (json == "")
                {
                    lista = new List<Carro>();
                }
                else
                {
                    lista = JsonConvert.DeserializeObject<List<Carro>>(json).ToList();
                }
                //p: Por que o método acima, para deserialize o json, esta chamando uma classe que não possui relação com o carro nesse momento?

                lista.Add(carro);

                string novoJsonResult = JsonConvert.SerializeObject(lista, Formatting.Indented);
                File.WriteAllText(DataCarro, novoJsonResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar carro");
            }
        }
        public static void Delete(Carro carro)
        {
            try
            {
                string json = File.ReadAllText(DataCarro);
                List<Carro> JObject;

                if (json == "")
                {
                    JObject = new List<Carro>();
                }
                else
                {
                    JObject = JsonConvert.DeserializeObject<List<Carro>>(json).ToList();
                }

                JObject.Remove(carro);

                string novoJsonResult = JsonConvert.SerializeObject(JObject, Formatting.Indented);
                File.WriteAllText(DataCarro, novoJsonResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar carro");
            }
        }
        public static void Edit(Carro carro)
        {
            try
            {
                string json = File.ReadAllText(DataCarro);
                List<Carro> jObject = JsonConvert.DeserializeObject<List<Carro>>(json).ToList();

                Carro antigo = jObject.Where(id => id.Id == carro.Id).FirstOrDefault();

                antigo = carro;

                string novoJsonResult = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                File.WriteAllText(DataCarro, novoJsonResult);
            }
            catch
            {
                Console.WriteLine("Erro ao editar avião");
            }
        }
        public static List<Carro> GetAll()
        {
            try
            {
                string json = File.ReadAllText(DataCarro);
                List<Carro> jObject = JsonConvert.DeserializeObject<List<Carro>>(json).ToList();
                return jObject;
            }
            catch
            {
                return null;
            }
        }
    }
}
