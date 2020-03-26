using Business;
using Data;
using Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Presentation
{
    public class Program
    {
        public static List<IPessoa> listPessoa = new List<IPessoa>();
        public static List<ILivro> listLivro = new List<ILivro>();
        public static List<IEmprestimo> listEmprestimo = new List<IEmprestimo>();

        static void Main(string[] args)
        {
            int opt = 0;
            do
            {
                opt = Menu();

                switch (opt)
                {
                    case 1:
                        CadastrarLivro();
                        break;
                    case 2:
                        CadastrarPessoa();
                        break;
                    case 3:
                        CadastrarEmprestimo();
                        break;
                    case 4:
                        DevolverEmprestimo();
                        break;
                    case 5:
                        Sair();
                        break;
                }

            } while (opt != 5);
        }

        private static void DevolverEmprestimo()
        {
            BibliocatecaBusiness biblioteca = new BibliocatecaBusiness();
            IEmprestimo iEmprestimo;

            do {
                iEmprestimo = new Emprestimo();
                Console.Write("Entre o numero do emprestimo: ");
                var id = Convert.ToInt32(Console.ReadLine());

                iEmprestimo = biblioteca.Devolver(iEmprestimo, id, listEmprestimo);

                if (iEmprestimo == null)
                    Console.WriteLine("--> Devolucao nao existente. Tente novamente. ");

            } while (iEmprestimo == null);
            Console.WriteLine("--> Devolucao executada com sucesso");
        }

        private static void CadastrarEmprestimo()
        {
            BibliocatecaBusiness biblioteca = new BibliocatecaBusiness();
            IEmprestimo emprestimo = new Emprestimo();
            IPessoa iPessoa;
            ILivro iLivro;

            do {
                iPessoa = new Pessoa();
                iLivro = new Livro();

                Console.Write("Entre com o CPF do solicitante: ");
                var cpf = Console.ReadLine();
                Console.Write("Entre com o Tombo do livro: ");
                var tombo = Convert.ToInt32(Console.ReadLine());

                iPessoa = biblioteca.BuscarPessoa(iPessoa, cpf, listPessoa);
                iLivro = biblioteca.BuscarLivro(iLivro, tombo, listLivro);

                if (iPessoa == null)
                    Console.WriteLine("--> Pessoa nao existente no cadastro. Tente novamente. ");

                if (iLivro == null)
                    Console.WriteLine("--> Livro nao existente no cadastro. Tente novamente. ");

            } while (iPessoa == null || iLivro == null);

            emprestimo = biblioteca.Emprestar(iPessoa, iLivro, emprestimo);
            listEmprestimo.Add(emprestimo);
            Console.WriteLine("--> Emprestimo realizado com sucesso.");
        }

        private static void CadastrarPessoa()
        {
            Console.Write("Entre com um cpf: ");
            var cpf = Console.ReadLine();
            Console.Write("Entre com um nome de pessoa: ");
            var nome = Console.ReadLine();
            Console.Write("Entre com um e-mail: ");
            var mail = Console.ReadLine();

            IPessoa pessoa = new Pessoa(cpf, nome, mail);

            listPessoa.Add(pessoa);
            Console.WriteLine("--> Pessoa cadastrado com sucesso.");
        }

        private static void CadastrarLivro()
        {
            Console.Write("Entre com um nome de um livro: ");
            var titulo = Console.ReadLine();
            Console.Write("Entre com o autor do livro: ");
            var autor = Console.ReadLine();

            ILivro livro = new Livro(listLivro.Count, titulo, autor);

            listLivro.Add(livro);
            Console.WriteLine("--> Livro cadastrado com sucesso.");
        }

        private static int Menu()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("\n## MENU ##");
            stringBuilder.Append("\n1 - Cadastrar livro");
            stringBuilder.Append("\n2 - Cadastrar Pessoa ");
            stringBuilder.Append("\n3 - Emprestar Livro");
            stringBuilder.Append("\n4 - Devolver");
            stringBuilder.Append("\n5 - Sair");
            Console.WriteLine(stringBuilder);
            return Int32.Parse(Console.ReadLine());
        }

        private static void Sair()
        {
            Console.WriteLine("Saindo ...");
        }
    }
}
