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
    public class NavioGuerra
    {
        string DataNavio = Environment.CurrentDirectory.Replace(@"\bin\Debug", "") + @"DataFiles\DataNaviosGuerra.JSON";

        public void Save(NavioGuerra veiculo)
        {
            try
            {
                string json = File.ReadAllText(DataNavio);
                var JObject = JsonConvert.DeserializeObject<List<NavioGuerra>>(json).ToList();

                JObject.Add(veiculo);

                string novoJsonResult = JsonConvert.SerializeObject(JObject, Formatting.Indented);
                File.WriteAllText(DataNavio, novoJsonResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar avião");
            }
        }
        public void Delete(NavioGuerra veiculo)
        {
            try
            {
                var json = File.ReadAllText(DataNavio);
                List<NavioGuerra> jObject = JsonConvert.DeserializeObject<List<NavioGuerra>>(json).ToList();

                jObject.Remove(veiculo);

                var saida = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                File.WriteAllText(DataNavio, saida);
            }
            catch
            {
                Console.WriteLine("Erro ao excluir avião");
            }
        }
        public void Edit(NavioGuerra veiculo)
        {
            try
            {
                string json = File.ReadAllText(DataNavio);
                List<NavioGuerra> jObject = JsonConvert.DeserializeObject<List<NavioGuerra>>(json).ToList();

                NavioGuerra antigo = jObject.Where(id => id.Id == veiculo.Id).FirstOrDefault();

                antigo = veiculo;

                string novoJsonResult = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                File.WriteAllText(DataNavio, novoJsonResult);
            }
            catch
            {
                Console.WriteLine("Erro ao editar avião");
            }
        }
        public List<NavioGuerra> GetAll()
        {
            try
            {
                string json = File.ReadAllText(DataNavio);
                List<NavioGuerra> jObject = JsonConvert.DeserializeObject<List<NavioGuerra>>(json).ToList();
                return jObject;
            }
            catch
            {
                return null;
            }
        }
    }
}
