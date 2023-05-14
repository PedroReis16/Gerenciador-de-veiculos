using Gerenciador_de_veículos.Fonts;
using Gerenciador_de_veículos.Objects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Gerenciador_de_veículos.DAO
{
    public class VeiculosDAO
    {
        static string DataVeiculo = Environment.CurrentDirectory +@"\DataFiles\DataVeiculos.json";
        static string json = File.ReadAllText(DataVeiculo);

        public static void Save(object veiculo)
        {
            try
            {
                List<object> JObject = JsonConvert.DeserializeObject<List<object>>(json).ToList();

                JObject.Add(veiculo);
                
                string dado = JsonConvert.SerializeObject(JObject, Formatting.Indented);

                //JsonSerializerSettings cfg = new JsonSerializerSettings();
                //cfg.TypeNameHandling = TypeNameHandling.All;

                //string dado = JsonConvert.SerializeObject(veiculo, cfg);

                //string novoJsonResult = JsonConvert.SerializeObject(JObject, Formatting.Indented);
                //string novoJsonResult = JsonConvert.SerializeObject(dado, Formatting.Indented);
                File.WriteAllText(DataVeiculo, dado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar avião");
            }
        }
        public static void Delete(object veiculo)
        {
            try
            {
                //var json = File.ReadAllText(DataCarro);
                List<object> jObject = JsonConvert.DeserializeObject<List<object>>(json).ToList();

                jObject.Remove(veiculo);

                var saida = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                File.WriteAllText(DataVeiculo, saida);
            }
            catch
            {
                Console.WriteLine("Erro ao excluir carro");
            }
        }
        public static void Edit(object veiculo)
        {
            try
            {
                //string json = File.ReadAllText(DataCarro);
                List<object> jObject = JsonConvert.DeserializeObject<List<object>>(json).ToList();
                int index;

                if (veiculo is Carro carro)
                {
                    Carro novo = (Carro)veiculo;

                    carro = jObject.OfType<Carro>().Where(id => id.Id == novo.Id).FirstOrDefault();
                    index = jObject.IndexOf(carro);
                    jObject[index] = null;
                    jObject[index] = novo;
                }
                else if (veiculo is Moto moto)
                {
                    Moto novo = (Moto)veiculo;

                    moto = jObject.OfType<Moto>().Where(id => id.Id == novo.Id).FirstOrDefault();
                    index = jObject.IndexOf(moto);
                    jObject[index] = null;
                    jObject[index] = novo;
                }
                else if (veiculo is Caminhao caminhao)
                {
                    Caminhao novo = (Caminhao)veiculo;

                    caminhao = jObject.OfType<Caminhao>().Where(id => id.Id == novo.Id).FirstOrDefault();
                    index = jObject.IndexOf(caminhao);
                    jObject[index] = null;
                    jObject[index] = novo;
                }
                else if (veiculo is Onibus onibus)
                {
                    Onibus novo = (Onibus)veiculo;

                    onibus = jObject.OfType<Onibus>().Where(id => id.Id == novo.Id).FirstOrDefault();
                    index = jObject.IndexOf(onibus);
                    jObject[index] = null;
                    jObject[index] = novo;
                }
                else if (veiculo is Aviao aviao)
                {
                    Aviao novo = (Aviao)veiculo;

                    aviao = jObject.OfType<Aviao>().Where(id => id.Id == novo.Id).FirstOrDefault();
                    index = jObject.IndexOf(aviao);
                    jObject[index] = null;
                    jObject[index] = novo;
                }
                else if (veiculo is AviaoGuerra aviaoG)
                {
                    AviaoGuerra novo = (AviaoGuerra)veiculo;

                    aviaoG = jObject.OfType<AviaoGuerra>().Where(id => id.Id == novo.Id).FirstOrDefault();
                    index = jObject.IndexOf(aviaoG);
                    jObject[index] = null;
                    jObject[index] = novo;
                }
                else if (veiculo is Navio navio)
                {
                    Navio novo = (Navio)veiculo;

                    navio = jObject.OfType<Navio>().Where(id => id.Id == novo.Id).FirstOrDefault();
                    index = jObject.IndexOf(navio);
                    jObject[index] = null;
                    jObject[index] = novo;
                }
                else if (veiculo is NavioGuerra navioG)
                {
                    NavioGuerra novo = (NavioGuerra)veiculo;

                    novo = jObject.OfType<NavioGuerra>().Where(id => id.Id == novo.Id).FirstOrDefault();
                    index = jObject.IndexOf(navioG);
                    jObject[index] = null;
                    jObject[index] = novo;
                }
                else if (veiculo is Trem trem)
                {
                    Trem novo = (Trem)veiculo;

                    trem = jObject.OfType<Trem>().Where(id => id.Id == novo.Id).FirstOrDefault();
                    index = jObject.IndexOf(trem);
                    jObject[index] = null;
                    jObject[index] = trem;
                }

                string novoJsonResult = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                File.WriteAllText(DataVeiculo, novoJsonResult);
            }
            catch
            {
                Console.WriteLine("Erro ao editar veículo");
            }
        }

        public static List<object> GetAllVehicles()
        {
            List<object> list = JsonConvert.DeserializeObject<List<object>>(json).ToList();

            return list;
        }
        public static List<object> GetAllRoadVehicles()
        {
            List<object> list = JsonConvert.DeserializeObject<List<object>>(json).ToList();
            List<object> result = new List<object>();

            foreach (var i in list)
            {
                if (i is Carro || i is Moto || i is Caminhao || i is Onibus)
                {
                    result.Add((Veiculo)i);
                }
            }

            return result;
        }
        public static List<object> GetAllPlanes()
        {
            List<object> list = JsonConvert.DeserializeObject<List<object>>(json).ToList();
            List<object> result = new List<object>();
            foreach (var i in list)
            {
                if (i is Aviao || i is AviaoGuerra)
                {
                    result.Add(i);
                }
            }
            return result;
        }
        public static List<object> GetAllShips()
        {
            List<object> list = JsonConvert.DeserializeObject<List<object>>(json).ToList();
            List<object> result = new List<object>();
            foreach (var i in list)
            {
                if (i is Navio || i is NavioGuerra)
                {
                    result.Add(i);
                }
            }
            return result;
        }
        public static List<object> GetAllTrains()
        {
            List<object> list = JsonConvert.DeserializeObject<List<object>>(json).ToList();
            List<object> result = new List<object>();
            foreach (var i in list)
            {
                if (i is Trem)
                {
                    result.Add((Trem)i);
                }
            }
            return result;
        }
    }
}
