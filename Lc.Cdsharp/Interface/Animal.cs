using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo1.Interface
{
    class Animal : IAnimal
    {
        public string Especie;
        public string Nome;
        public int Idade;

        public void Alimentar()
        {
            Console.WriteLine("Nhame!");
        }

        public virtual void Brincar()
        {
            Console.WriteLine("Brincar classe pai");
        }
    }
}
