using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo1.Heranca2
{
    class Cachorro : Animal
    {
        public string Nome { get; }
        public Cachorro(DateTime nasc, string n) : base(nasc)
        {
            Nome = n;
        }

        public void Latir()
        {
            Console.WriteLine("Au!");
        }
    }
}
