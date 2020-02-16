using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo1.Heranca2
{
    class Gato : Animal
    {
        public string Nome { get; }

        public Gato(DateTime nasc, string n) : base(nasc)
        {
            Nome = n;
        }
        public void Miar()
        {
            Console.WriteLine("Miau!");
        }
    }
}
