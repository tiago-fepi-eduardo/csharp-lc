using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace Lc.Csharp.Modulo1
{
    class FileWork
    {
        static void Main()
        {
            // Via JSON
            using (StreamReader file = File.OpenText(@"C:\Tiago\LetsCode\repo_csharp\csharp-lc\Lc.Csharp.Modulo2\myfile.json"))
            {

                //Forma 1
                var lst2 = JsonConvert.DeserializeObject<Dictionary<string, string>>(file.ReadToEnd());
                foreach (var item in lst2)
                {
                    Console.WriteLine(item.Key + " " + item.Value);
                }

                //Forma 2
                //var lst1 = JsonConvert.DeserializeObject<dynamic>(file.ReadToEnd());
                //foreach (KeyValuePair<string, object> item in lst1)
                //{
                //    Console.WriteLine(item.Key + " " + item.Value);
                //}
            }

            // Via config xml
            string sValue = ConfigurationManager.AppSettings["Feature1"];
            bool featureEnable = Convert.ToBoolean(sValue);

            if (featureEnable)
                Console.WriteLine("Feature ativa");
            else
                Console.WriteLine("Feature desativada");
        }
    }
}
