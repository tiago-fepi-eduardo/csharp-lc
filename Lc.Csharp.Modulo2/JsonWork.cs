using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace Lc.Csharp.Modulo1
{
    class JsonWork
    {
        //static void Main()
        //{
        //    using (StreamReader file = File.OpenText("myfile.json"))
        //    {
        //        // Chave valor
        //        //var dic = JsonConvert.DeserializeObject<Dictionary<dynamic, dynamic>>(file.ReadToEnd());

        //        // Lista
        //        //var dic = JsonConvert.DeserializeObject<List<string>>(file.ReadToEnd());

        //        // classe com chave valor e lista
        //        var dic = JsonConvert.DeserializeObject<MinhaEstrutura>(file.ReadToEnd());
        //        Console.WriteLine(dic.chave1);
        //        Console.WriteLine(dic.chave2);
        //        Console.WriteLine(dic.chave3);
        //        Console.WriteLine(dic.chave5);

        //        foreach (var item in dic.chave4)
        //        {
        //            Console.WriteLine("\t" + item);
        //            //Console.WriteLine($"{item.Key} - {item.Value}");
        //        }
        //    }
        //}
    }

    class MinhaEstrutura
    {
        public string chave1 { get; set; }
        public int chave2 { get; set; }
        public bool chave3 { get; set; }
        public List<string> chave4 { get; set; }
        public string chave5 { get; set; }
    }
}
