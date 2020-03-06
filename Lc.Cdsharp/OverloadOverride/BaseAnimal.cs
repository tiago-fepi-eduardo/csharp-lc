using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo1.OverloadOverride
{
    class BaseAnimal
    {
        public void Alimentar()
        {
            Console.WriteLine("Animal alimentado.");
        }

        public virtual void Andar()
        {
            Console.WriteLine("Animal andou.");
        }

        public void Dormir()
        {
            Console.WriteLine("Animal dormiu.");
        }
    }
}
