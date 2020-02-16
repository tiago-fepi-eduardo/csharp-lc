using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Lc.Csharp.Modulo1.Praticando
{
    public class Lista04
    {
        static ContaBancaria[] contas = new ContaBancaria[5];

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
                menu.Append("1 - Criar conta");
                menu.Append("\n2 - Imprimir conta");
                menu.Append("\n0 - Sair");
                Console.WriteLine(menu);
                int tecla = int.Parse(Console.ReadLine());

                switch (tecla)
                {
                    case 1:
                        AdicionarConta();
                        break;
                    case 2:
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

        static void AdicionarConta()
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

            ContaBancaria contaBancaria = new ContaBancaria(id, nome, cpf, email, saldo, criado, modificado);

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
                    conta.ImprimirConta();
            }
        }
    }

    class ContaBancaria
    {
        private double saldo;
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

        public ContaBancaria(string id, string n, int c, string e, double s, DateTime cr, DateTime m)
        {
            Id = id;
            Nome = n;
            Cpf = c;
            Email = e;
            saldo = s;
            Criado = cr;
            Modificado = m;
        }

        public void ImprimirConta()
        {
            Console.WriteLine($"\nIF: {Id} \nNome: {Nome} \nCPF: {Cpf} \nE-mail: {Email} \nSaldo: {saldo.ToString("C")} \nCriado: {Criado} \nModificado: {Modificado}");
        }
    }

    static class Investimento
    {
        public const double alicota = 1.1;

        public static double InvestimentoFixo(int prazo, double valor)
        {
            return valor * prazo * alicota;
        }

        public static double InvestimentoVariavel(int prazo, double valor)
        {
            double taxa = new Random(1).NextDouble();
            return valor * prazo * taxa;
        }
    }
}
