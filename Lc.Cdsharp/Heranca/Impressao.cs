using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo1.Heranca2
{
     static class Impressao
    {
        public static void Imprimir(Animal a)
        {
            string especie = a.GetType().Name;
            Console.WriteLine($"{especie} Nascimento: {a.Nascimento}");
        }
    }
}
