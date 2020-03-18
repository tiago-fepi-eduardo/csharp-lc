using System;
using Repositorio;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cadastro cad = new Cadastro();
            cad.SetNome("Tiago");
            Console.WriteLine(cad.GetNome());

            ICadastro cad2 = new Cadastro();
            cad2.SetNome("Eduardo");
        }
    }
}
