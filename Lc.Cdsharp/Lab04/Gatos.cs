using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo1.Lab04
{
    class Gatos : Animal
    {
        public string Brinquedo;

        public void Miar()
        {
            Alimentar();
            Console.WriteLine("Miau!");
        }

        
    }
}
