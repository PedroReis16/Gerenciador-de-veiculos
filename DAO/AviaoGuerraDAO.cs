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
    public class AviaoGuerraDAO
    {
        static string DataAviao = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"DataFiles\DataAvioesGuerra.JSON";
        

        public static void Save(AviaoGuerra veiculo)
        {
            try
            {
                string json = File.ReadAllText(DataAviao);
                var JObject = JsonConvert.DeserializeObject<List<AviaoGuerra>>(json).ToList();

                JObject.Add(veiculo);

                string novoJsonResult = JsonConvert.SerializeObject(JObject, Formatting.Indented);
                File.WriteAllText(DataAviao, novoJsonResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar avião");
            }
        }
        public static void Delete(AviaoGuerra veiculo)
        {
            try
            {
                var json = File.ReadAllText(DataAviao);
                List<AviaoGuerra> jObject = JsonConvert.DeserializeObject<List<AviaoGuerra>>(json).ToList();

                jObject.Remove(veiculo);

                var saida = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                File.WriteAllText(DataAviao, saida);
            }
            catch
            {
                Console.WriteLine("Erro ao excluir avião");
            }
        }
        public static void Edit(AviaoGuerra veiculo)
        {
            try
            {
                string json = File.ReadAllText(DataAviao);
                List<AviaoGuerra> jObject = JsonConvert.DeserializeObject<List<AviaoGuerra>>(json).ToList();

                AviaoGuerra antigo = jObject.Where(id => id.Id == veiculo.Id).FirstOrDefault();

                antigo = veiculo;

                string novoJsonResult = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                File.WriteAllText(DataAviao, novoJsonResult);
            }
            catch
            {
                Console.WriteLine("Erro ao editar avião");
            }
        }
        public  static List<AviaoGuerra> GetAll()
        {
            try
            {
                string json = File.ReadAllText(DataAviao);
                List<AviaoGuerra> jObject = JsonConvert.DeserializeObject<List<AviaoGuerra>>(json).ToList();
                return jObject;
            }
            catch
            {
                return null;
            }
        }
    }
}
