using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo1.Heranca2
{
    class Animal
    {
        public DateTime Nascimento { get; set; }

        public Animal(DateTime nasc)
        {
            Nascimento = nasc;
        }

        public void Passear()
        {
            Console.WriteLine("Passeando!");
        }
    }
}
