using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo1.Lab04
{
    public class Animal
    {
        public readonly string Especie;
        private string Nome;
        public int Idade;

        public Animal(string especie, string nome)
        {
            Especie = especie;
            Nome = nome;
        }

        public string GetNome()
        {
            return Nome;
        }

        public void Alimentar(object alimento)
        {
            Console.WriteLine("Alimentado!");
        }
    }
}
