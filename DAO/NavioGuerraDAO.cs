﻿using Gerenciador_de_veículos.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_veículos.DAO
{
    public class NavioGuerraDAO
    {
        static string DataNavio = Environment.CurrentDirectory + @"\DataFiles\DataNaviosGuerra.json";

        public static void Save(NavioGuerra veiculo)
        {
            try
            {
                string json = File.ReadAllText(DataNavio);
                List<NavioGuerra> JObject;

                if (json == "")
                {
                    JObject = new List<NavioGuerra>();
                }
                else
                {
                    JObject = JsonConvert.DeserializeObject<List<NavioGuerra>>(json).ToList();
                }

                JObject.Add(veiculo);

                string novoJsonResult = JsonConvert.SerializeObject(JObject, Formatting.Indented);
                File.WriteAllText(DataNavio, novoJsonResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar avião");
            }
        }
        public static void Delete(NavioGuerra veiculo)
        {
            try
            {
                string json = File.ReadAllText(DataNavio);
                List<NavioGuerra> JObject;

                if (json == "")
                {
                    JObject = new List<NavioGuerra>();
                }
                else
                {
                    JObject = JsonConvert.DeserializeObject<List<NavioGuerra>>(json).ToList();
                }

                JObject.Remove(veiculo);

                string novoJsonResult = JsonConvert.SerializeObject(JObject, Formatting.Indented);
                File.WriteAllText(DataNavio, novoJsonResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar avião");
            }
        }
        public static void Edit(NavioGuerra veiculo)
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
        public static List<NavioGuerra> GetAll()
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
