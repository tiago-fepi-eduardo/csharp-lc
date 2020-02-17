using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Lc.Csharp.Modulo1.Praticando
{
    public class Lista04
    {
        static Conta[] contas = new Conta[3];

        static void Main()
        {
            Iniciar();

            Console.WriteLine();
            Console.WriteLine();
        }

        static void Iniciar()
        {
            int run = -1;
            do
            {
                Console.WriteLine("\n## Escolhe uma opçao ##");
                StringBuilder menu = new StringBuilder();
                menu.Append("1 - Criar conta max");
                menu.Append("\n2 - Criar conta universitaria");
                menu.Append("\n3 - Imprimir conta");
                menu.Append("\n0 - Sair");
                Console.WriteLine(menu);
                int tecla = int.Parse(Console.ReadLine());

                switch (tecla)
                {
                    case 1:
                        AdicionarContaMax();
                        break;
                    case 2:
                        AdicionarContaUniversitaria();
                        break;
                    case 3:
                        ListarContas();
                        break;
                    case 0:
                        run = 0;
                        break;
                    default:
                        Console.WriteLine("Opcao invalida.");
                        break;
                }
            } while (run != 0);
        }

        static void AdicionarContaUniversitaria()
        {
            Console.WriteLine("Digite um nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o CPF:");
            int cpf = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um email:");
            string email = Console.ReadLine();

            string id = new Guid().ToString();
            DateTime criado = DateTime.Now;
            DateTime modificado = DateTime.Now;
            double saldo = 1;

            ContaMax contaBancaria = new ContaMax(id, nome, cpf, email, saldo, criado, modificado);

            bool sucesso = false;
            for (int i = 0; i < contas.Length; i++)
            {
                if (contas[i] != null)
                    continue;
                else
                {
                    contas[i] = contaBancaria;
                    sucesso = true;
                    break;
                }
            }

            if (sucesso)
                Console.WriteLine("Adicionado com sucesso!");
            else
                Console.WriteLine("Não foi possivel adicionar. Lista cheia!");
        }

        static void AdicionarContaMax()
        {
            Console.WriteLine("Digite um nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o CPF:");
            int cpf = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um email:");
            string email = Console.ReadLine();

            string id = new Guid().ToString();
            DateTime criado = DateTime.Now;
            DateTime modificado = DateTime.Now;
            double saldo = 1;

            ContaMax contaBancaria = new ContaMax(id, nome, cpf, email, saldo, criado, modificado);

            bool sucesso = false;
            for (int i = 0; i < contas.Length; i++)
            {
                if (contas[i] != null)
                    continue;
                else
                {
                    contas[i] = contaBancaria;
                    sucesso = true;
                    break;
                }
            }

            if (sucesso)
                Console.WriteLine("Adicionado com sucesso!");
            else
                Console.WriteLine("Não foi possivel adicionar. Lista cheia!");
        }

        static void ListarContas()
        {
            Console.WriteLine("## Imprimindo ##");
            foreach (var conta in contas)
            {
                if (conta != null)
                {
                    if (conta.GetType().Name == typeof(ContaUniversitaria).Name)
                    {
                        ContaUniversitaria contaU = (ContaUniversitaria)conta;
                        contaU.ImprimirConta();
                    }
                    else
                    {
                        ContaMax contaM = (ContaMax)conta;
                        contaM.ImprimirConta();
                    }
                }
            }
        }
    }

    class Conta
    {
        public double saldo;
        public readonly string Id;

        public string Nome { get; set; }
        public int Cpf { get; set; }
        public string Email { get; set; }
        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                saldo = value;
                Modificado = DateTime.Now;
            }
        }
        public DateTime Modificado { get; set; }
        public DateTime Criado { get; }

        public Conta(string id, string n, int c, string e, double s, DateTime cr, DateTime m)
        {
            Id = id;
            Nome = n;
            Cpf = c;
            Email = e;
            saldo = s;
            Criado = cr;
            Modificado = m;
        }
    }

    class ContaUniversitaria : Conta
    {
        public static double Taxa = 1.2;

        public ContaUniversitaria(string id, string n, int c, string e, double s, DateTime cr, DateTime m)
           : base(id, n, c, e, s, cr, m)
        {
        }

        public void ImprimirConta()
        {
            Console.WriteLine("\nConta Universitária");
            Console.WriteLine($"\nIF: {Id} \nNome: {Nome} \nCPF: {Cpf} \nE-mail: {Email} \nSaldo: {saldo.ToString("C")} \nCriado: {Criado} \nModificado: {Modificado}");
        }
    }

    class ContaMax : Conta
    {
        public static double Taxa = 1.2;

        public ContaMax(string id, string n, int c, string e, double s, DateTime cr, DateTime m)
           : base(id, n, c, e, s, cr, m)
        {
        }

        public void ImprimirConta()
        {
            Console.WriteLine("\nConta Max");
            Console.WriteLine($"\nID: {Id} \nNome: {Nome} \nCPF: {Cpf} \nE-mail: {Email} \nSaldo: {saldo.ToString("C")} \nCriado: {Criado} \nModificado: {Modificado}");
        }
    }

    static class Investimento
    {
        public static double InvestimentoFixo(int taxa, double valor)
        {
            return valor * taxa;
        }

        public static double InvestimentoVariavel(int taxa, double valor)
        {
            double taxaVariable = new Random(1).NextDouble();
            return valor * taxa * taxaVariable;
        }
    }
}
