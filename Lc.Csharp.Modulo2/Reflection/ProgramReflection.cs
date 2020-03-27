using System;
using System.Reflection;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Lc.Csharp.Modulo2.Reflection
{
    class ProgramReflection
    {
        //static void Main()
        //{
        //    //Console.WriteLine("## Reflection ##");
        //}

        static void DllReferencia()
        {
            //using Presentation;

            //Externo externo = new Externo();

            //var s = externo.ConteudoPublico();

            //Console.WriteLine(s);
        }

        static void DllExterna()
        {
            // Carrega dll
            Assembly testAssembly = Assembly.LoadFile(@"C:\Tiago\LetsCode\repo_csharp\csharp-lc\Lc.Csharp.Modulo2\dll\Presentation.dll");

            // Carrega namespace e classe
            Type exterType = testAssembly.GetType("Presentation.Externo");

            // Cria instancia da classe
            object exterInstancia = Activator.CreateInstance(exterType);

            // Carrega metodo
            MethodInfo method = exterType.GetMethod("ConteudoPublico");

            // Adiconada metodo
            var r = method.Invoke(exterInstancia, null) as string;

            Console.WriteLine(r);
        }

        public static void APISincronoTexto()
        {
            using (var client = new WebClient()) //WebClient  
            {
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("Accept:application/json");

                //client.Headers.Add("host:https://");
                //client.Headers.Add("key:chave");

                var result = client.DownloadString("http://dummy.restapiexample.com/api/v1/employees"); //URI  

                Console.WriteLine(Environment.NewLine + result);
            }
        }
        
        static async Task RunHttp()
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync("http://www.contoso.com/");

            string responseBody = await response.Content.ReadAsStringAsync();

            Console.WriteLine(responseBody);
        }

        public static async Task RunAsync()
        {
            //RunAsync().Wait();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://dummy.restapiexample.com/");

                var response = await client.GetAsync("api/v1/employees");

                var data = response.Content.ReadAsStringAsync().Result;

                //Console.WriteLine(data);

                var result = JsonConvert.DeserializeObject<Result>(data);

                foreach (var item in result.Data)
                {
                    Console.WriteLine($"{item.employee_name}\n{item.employee_age}\n{item.employee_salary}\n");
                }
            }
        }
    }

    public class Result
    {
        public string Status { get; set; }

        public List<Employee> Data { get; set; }
    }

    public class Employee
    {
        public string Status { get; set; }
        public string employee_name { get; set; }
        public string employee_salary { get; set; }
        public string employee_age { get; set; }
        public string profile_image { get; set; }
    }
}
