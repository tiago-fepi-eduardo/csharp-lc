using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo1.OverloadOverride
{
    class Felino : BaseAnimal
    {
        public new void Andar()
        {
            Console.WriteLine("Felino andou.");
        }
    }
}
