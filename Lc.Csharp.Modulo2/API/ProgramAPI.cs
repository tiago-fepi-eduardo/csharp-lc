using System;
using System.Reflection;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Lc.Csharp.Modulo2.Reflection
{

    class ProgramAPI
    {
        //static void Main()
        //{
        //    RunAsync().Wait();
        //}

        public static async Task RunAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://swapi.co/api/");

                var response = client.GetAsync("people/1/").Result;

                var data = response.Content.ReadAsStringAsync().Result;

                var results = JsonConvert.DeserializeObject<Pessoa>(data);

                Console.WriteLine(results.Name);
                Console.WriteLine(results.Height);
                Console.WriteLine(results.Mass);
            }
        }
    }

    public class Pessoa
    {
        public string Name { get; set; }

        public string Height { get; set; }

        public string Mass { get; set; }
    }
}