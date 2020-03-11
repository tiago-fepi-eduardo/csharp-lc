using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo1
{
    class DynamicVar
    {
        //static void Main()
        //{
        //    var oList = new List<int>();
        //    oList.Add(1);
        //    Executar(oList);
        //}

        static void Executar(dynamic collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

    }
}
