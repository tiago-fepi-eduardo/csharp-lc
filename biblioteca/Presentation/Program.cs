using Business;
using Data;
using Interface;
using System;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Biblioteca");

            ILivro livro = new Livro(1, "O Iluminado", "Steohen King");
            IPessoa pessoa = new Pessoa(015, "Tiago", "tiago@google.com");
            IEmprestimo emprestimo = new Emprestimo();

            BibliocatecaBusiness biblioteca = new BibliocatecaBusiness();
            emprestimo = biblioteca.Emprestar(pessoa, livro, emprestimo);

            Console.WriteLine(emprestimo.GetId());
            Console.WriteLine(emprestimo.GetLivro().GetTitulo());
            Console.WriteLine(emprestimo.GetLivro().GetAutor());
            Console.WriteLine(emprestimo.GetPessoa().GetCPF());
            Console.WriteLine(emprestimo.GetPessoa().GetNome());

        }
    }
}
