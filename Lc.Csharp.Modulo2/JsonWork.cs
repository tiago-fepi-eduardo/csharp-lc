using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lc.Csharp.Modulo1
{
    class JsonWork
    {























    /*
        static void Main()
        {
            string arquivo = "myfile.json";
            StreamReader file = File.OpenText(arquivo);
            //var dic = JsonConvert.DeserializeObject<List<string>>(file.ReadToEnd());
            //var dic = JsonConvert.DeserializeObject<Dictionary<string,string>>(file.ReadToEnd());
            var dic = JsonConvert.DeserializeObject<MeuJson>(file.ReadToEnd());

            Console.WriteLine(dic.prop1);
            Console.WriteLine(dic.prop2);
            Console.WriteLine(dic.prop5);

            foreach (var item in dic.prop4)
            {
                Console.WriteLine("\t"+item);
                //Console.WriteLine($"{item.Key} - {item.Value}");
            }
            file.Dispose();
            file.Close();
        }
        */
    }

    /*
    public class MeuJson
    {
        public string prop1 { get; set; }
        public string prop2 { get; set; }
        public string prop3 { get; set; }
        public List<string> prop4 { get; set; }
        public string prop5 { get; set; }
    }
    */
}
