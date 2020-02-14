using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo1.Interface
{
    class Cachorro : Animal, IFilhote, IAdulto
    {
        public void CheckUp()
        {
            Console.WriteLine("Exames ok!");
        }

        public void Latir()
        {
            Console.WriteLine("Au au!");
        }

        public void Vacinar()
        {
            Console.WriteLine("Vacinado!");
        }

        public override void Brincar()
        {
            base.Brincar();
            Console.WriteLine("Brincar classe filha.");
        }

    }
}
