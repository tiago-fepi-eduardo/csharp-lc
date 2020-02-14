using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo1.Heranca
{
    class Gato : Animal
    {
        public string Brinquedo;

        public void Miar()
        {
            Alimentar();
            Console.WriteLine("Miau!");
        }

        
    }
}
