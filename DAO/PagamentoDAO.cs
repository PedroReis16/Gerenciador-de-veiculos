using Gerenciador_de_veículos.Objects;
using Gerenciador_de_veículos.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Gerenciador_de_veículos.DAO
{
    public class PagamentoDAO
    {
        static string DataPagamento = Environment.CurrentDirectory.Replace(@"\bin\Debug", "") + @"DataFiles\DataPagamento.JSON";

        public static void Save(Pagamento pagamento)
        {
            try
            {
                string json = File.ReadAllText(DataPagamento);
                var JObject = JsonConvert.DeserializeObject<List<Pagamento>>(json).ToList();

                JObject.Add(pagamento);

                string novoJsonResult = JsonConvert.SerializeObject(JObject, Formatting.Indented);
                File.WriteAllText(DataPagamento, novoJsonResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar avião");
            }
        }
        public static void Delete(Pagamento pagamento)
        {
            try
            {
                var json = File.ReadAllText(DataPagamento);
                List<Pagamento> jObject = JsonConvert.DeserializeObject<List<Pagamento>>(json).ToList();

                jObject.Remove(pagamento);

                var saida = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                File.WriteAllText(DataPagamento, saida);
            }
            catch
            {
                Console.WriteLine("Erro ao excluir avião");
            }
        }
        public static void Edit(Pagamento pagamento)
        {
            try
            {
                string json = File.ReadAllText(DataPagamento);
                List<Pagamento> jObject = JsonConvert.DeserializeObject<List<Pagamento>>(json).ToList();

                Pagamento antigo = jObject.Where(id => id.Id == pagamento.Id).FirstOrDefault();

                antigo = pagamento;

                string novoJsonResult = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                File.WriteAllText(DataPagamento, novoJsonResult);
            }
            catch
            {
                Console.WriteLine("Erro ao editar avião");
            }
        }
        public static List<Pagamento> GetAll()
        {
            try
            {
                string json = File.ReadAllText(DataPagamento);
                List<Pagamento> jObject = JsonConvert.DeserializeObject<List<Pagamento>>(json).ToList();
                return jObject;
            }
            catch
            {
                return null;
            }
        }
    }
}
