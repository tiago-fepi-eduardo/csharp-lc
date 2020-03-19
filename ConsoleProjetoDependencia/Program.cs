using System;
using Dados;
using Negocios;

namespace ConsoleProjetoDependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ICadastro cadastro = new Cadastro();
            cadastro.Cadastrar("Tiago","Eduardo", 120);
            Console.WriteLine(cadastro.Imprimir());

            AnalisarCadastro analisarCadastro = new AnalisarCadastro();
            var ok = analisarCadastro.Analisar(cadastro);
            if (ok)
                Console.WriteLine("Cadstro ok");
            else
                Console.WriteLine("Não ok");
        }
    }
}
