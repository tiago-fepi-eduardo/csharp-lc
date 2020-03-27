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
                    case 11:
                        CadastrarLivro();
                        break;
                    case 12:
                        PesquisarLivro();
                        break;
                    case 13:
                        DeletarLivro();
                        break;
                    case 21:
                        CadastrarPessoa();
                        break;
                    case 22:
                        PesquisarPessoa();
                        break;
                    case 23:
                        DeletarPessoa();
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

        private static int Menu()
        {
            bool menuOK = true;
            int opt;
            do
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append("\n## MENU ##");
                stringBuilder.Append("\n- Livro");
                stringBuilder.Append("\n11 - Cadastrar livro");
                stringBuilder.Append("\n12 - Pesquisar livro");
                stringBuilder.Append("\n13 - Deletar livro");
                stringBuilder.Append("\n- Pessoa");
                stringBuilder.Append("\n21 - Cadastrar pessoa");
                stringBuilder.Append("\n22 - Pesquisar pessoa");
                stringBuilder.Append("\n23 - Deletar pessoa");
                stringBuilder.Append("\n3 - Emprestar Livro");
                stringBuilder.Append("\n4 - Devolver");
                stringBuilder.Append("\n5 - Sair");
                Console.WriteLine(stringBuilder);

                if (Int32.TryParse(Console.ReadLine(), out opt))
                    menuOK = true;
                else
                    menuOK = false;

            } while (!menuOK);

            return opt;
        }


        private static void DevolverEmprestimo()
        {
            BibliocatecaBusiness biblioteca = new BibliocatecaBusiness();
            IEmprestimo iEmprestimo;

            do
            {
                iEmprestimo = new Emprestimo();
                Console.Write("Entre o numero do emprestimo: ");
                var id = Convert.ToInt32(Console.ReadLine());

                iEmprestimo = biblioteca.Devolver(iEmprestimo, id, listEmprestimo);

                if (iEmprestimo == null)
                    Console.WriteLine("--> Devolucao nao existente. Tente novamente. ");
                else
                    listEmprestimo.Remove(iEmprestimo);

            } while (iEmprestimo == null);
            Console.WriteLine("--> Devolucao executada com sucesso");
        }

        private static void CadastrarEmprestimo()
        {
            BibliocatecaBusiness biblioteca = new BibliocatecaBusiness();
            IEmprestimo emprestimo = new Emprestimo();
            IPessoa iPessoa;
            ILivro iLivro;

            do
            {
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
            string cpf, nome, mail;
            do
            {
                Console.Write("Entre com um cpf: ");
                cpf = Console.ReadLine();
            } while (string.IsNullOrEmpty(cpf));

            do
            {
                Console.Write("Entre com um nome de pessoa: ");
                nome = Console.ReadLine();
            } while (string.IsNullOrEmpty(nome));

            do
            {
                Console.Write("Entre com um e-mail: ");
                mail = Console.ReadLine();
            } while (string.IsNullOrEmpty(mail));

            IPessoa pessoa = new Pessoa(cpf, nome, mail);
            listPessoa.Add(pessoa);
            Console.WriteLine("--> Pessoa cadastrado com sucesso.");
        }

        private static void CadastrarLivro()
        {
            string titulo, autor;

            do
            {
                Console.Write("Entre com um nome de um livro: ");
                titulo = Console.ReadLine();
            } while (string.IsNullOrEmpty(titulo));

            do
            {
                Console.Write("Entre com o autor do livro: ");
                autor = Console.ReadLine();
            } while (string.IsNullOrEmpty(autor));

            ILivro livro = new Livro(listLivro.Count, titulo, autor);
            listLivro.Add(livro);
            Console.WriteLine("--> Livro cadastrado com sucesso.");
        }

        private static void Sair()
        {
            Console.WriteLine("Saindo ...");
        }


        private static void DeletarPessoa()
        {
            BibliocatecaBusiness biblioteca = new BibliocatecaBusiness();
            IPessoa iPessoa;
            IEmprestimo iEmprestimo;

            do
            {
                iPessoa = new Pessoa();

                Console.Write("Entre com o CPF da pessoa: ");
                var cpf = Console.ReadLine();
                iPessoa = biblioteca.BuscarPessoa(iPessoa, cpf, listPessoa);

                if (iPessoa == null)
                    Console.WriteLine("--> Pessoa nao existente no cadastro. Tente novamente. ");
                else
                {
                    iEmprestimo = new Emprestimo();
                    iEmprestimo = biblioteca.BuscarEmprestimoPorPessoa(iEmprestimo, iPessoa, listEmprestimo);

                    if (iEmprestimo == null)
                    {
                        listPessoa.Remove(iPessoa);
                        Console.WriteLine("--> Pessoa removida com sucesso. ");
                    }
                    else
                        Console.WriteLine("--> Pessoa emprestado. Nao e possivel remove-lo neste momento. ");
                }

            } while (iPessoa == null);
        }

        private static void DeletarLivro()
        {
            BibliocatecaBusiness biblioteca = new BibliocatecaBusiness();
            ILivro iLivro;
            IEmprestimo iEmprestimo;

            do
            {
                iLivro = new Livro();

                Console.Write("Entre com o Tombo do livro: ");
                var tombo = Convert.ToInt32(Console.ReadLine());
                iLivro = biblioteca.BuscarLivro(iLivro, tombo, listLivro);

                if (iLivro == null)
                    Console.WriteLine("--> Livro nao existente no cadastro. Tente novamente. ");
                else
                {
                    iEmprestimo = new Emprestimo();
                    iEmprestimo = biblioteca.BuscarEmprestimoPorLivro(iEmprestimo, iLivro, listEmprestimo);

                    if (iEmprestimo == null)
                    {
                        listLivro.Remove(iLivro);
                        Console.WriteLine("--> Livro removida com sucesso. ");
                    }
                    else
                        Console.WriteLine("--> Livro emprestado. Nao e possivel remove-lo neste momento. ");
                }

            } while (iLivro == null);
        }


        private static void PesquisarPessoa()
        {
            BibliocatecaBusiness biblioteca = new BibliocatecaBusiness();
            IPessoa iPessoa;

            do
            {
                iPessoa = new Pessoa();

                Console.Write("Entre com o CPF da pessoa: ");
                var cpf = Console.ReadLine();
                iPessoa = biblioteca.BuscarPessoa(iPessoa, cpf, listPessoa);

                if (iPessoa == null)
                    Console.WriteLine("--> Pessoa nao existente no cadastro. Tente novamente. ");
                else
                    Console.WriteLine(iPessoa.ImprimirPessoa());

            } while (iPessoa == null);
        }

        private static void PesquisarLivro()
        {
            BibliocatecaBusiness biblioteca = new BibliocatecaBusiness();
            ILivro iLivro;

            do
            {
                iLivro = new Livro();

                Console.Write("Entre com o Tombo do livro: ");
                var tombo = Convert.ToInt32(Console.ReadLine());
                iLivro = biblioteca.BuscarLivro(iLivro, tombo, listLivro);

                if (iLivro == null)
                    Console.WriteLine("--> Livro nao existente no cadastro. Tente novamente. ");
                else
                    Console.WriteLine(iLivro.ImprimirLivro());

            } while (iLivro == null);
        }
    }
}
