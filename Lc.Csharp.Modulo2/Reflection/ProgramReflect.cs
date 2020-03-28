using System;
using Presentation;
using System.Reflection;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Lc.Csharp.Modulo2.Reflection
{
    class ProgramReflect
    {
        static void Main()
        {
            ApiJson().Wait();
        }

        static void DllviaReflection()
        {
            // Carrega dll
            Assembly assembly = Assembly.LoadFile(@"C:\Tiago\LetsCode\repo_csharp\csharp-lc\Lc.Csharp.Modulo2\dll\Presentation.dll");

            // Carrega namespace e classe
            Type exterType = assembly.GetType("Presentation.Externo");

            // Carrega metodo
            MethodInfo method = exterType.GetMethod("ConteudoPublico");

            // Cria instancia da classe
            object exterInstancia = Activator.CreateInstance(exterType);

            // Adiconada metodo
            var r = method.Invoke(exterInstancia, null);

            Console.WriteLine(r.ToString());
        }

        static void DllViaReferencia()
        {
            Integracao integracao = new Integracao();
            string res = integracao.RetornarString();
            Console.WriteLine(res);
        }

        static void ApiString()
        {
            using (var client = new WebClient())
            {
                var result = client.DownloadString("http://dummy.restapiexample.com/api/v1/employees"); //URI  

                Console.WriteLine(Environment.NewLine + result);
            }
        }

        static async Task ApiJson()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://dummy.restapiexample.com/");

                var response = await client.GetAsync("api/v1/employees");

                var data = response.Content.ReadAsStringAsync().Result;

                //Console.WriteLine(data);

                var result = JsonConvert.DeserializeObject<Empregados>(data);

                Console.WriteLine("Status: " + result.Status);

                foreach (var item in result.Data)
                {
                    Console.WriteLine($"{item.Employee_name}\n{item.Employee_age}\n{item.Employee_salary}\n");
                }
            }
        }
    }

    public class Empregados
    {
        public string Status { get; set; }

        public List<Empregado> Data { get; set; }
    }

    public class Empregado
    {
        public string Id { get; set; }
        public string Employee_name { get; set; }
        public string Employee_salary { get; set; }
        public string Employee_age { get; set; }
        public string Profile_image { get; set; }
    }
}
