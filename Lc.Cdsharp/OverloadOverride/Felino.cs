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

        public void Dormir(int i)
        {
            Console.WriteLine("Animal dormiu " + i + " horas");
        }

        public void Dormir(int i, string x)
        {
            Console.WriteLine("Animal dormiu " + i + " horas e " + x);
        }

        public void Dormir(bool b)
        {
            Console.WriteLine("Animal dormiu cmo bol");
        }
    }
}
