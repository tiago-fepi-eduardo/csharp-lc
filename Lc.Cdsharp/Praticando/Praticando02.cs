using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Lc.Csharp.Modulo1.Praticando
{
    public class Praticando02
    {
        static void Main()
        {
            Console.WriteLine("-------CONTAS CRIADAS");

            #region ContaBancaria

            ContaBancaria contaBancaria = new ContaBancaria(1,"Joaquim", 0124, "mail", 10);
            contaBancaria.ImprimirFicha();

            ContaBancaria contaBancaria2 = new ContaBancaria(2,"Emma", 013334, "mail", 10);
            contaBancaria2.ImprimirFicha();

            ContaBancaria contaBancaria3 = new ContaBancaria(3,"Bart", 01223, "mail", 10);
            contaBancaria3.ImprimirFicha();

            #endregion

            //Investindo
            contaBancaria.Saldo = Investimento.Investimento01(12, contaBancaria.Saldo);
            contaBancaria2.Saldo = Investimento.Investimento02(12, contaBancaria2.Saldo);
            contaBancaria3.Saldo = Investimento.Investimento03(12, contaBancaria3.Saldo);

            //Reimprimindo
            Console.WriteLine("\n\n-------APOS 12 MESES DE INVESTIMENTO");
            contaBancaria.ImprimirFicha();
            contaBancaria2.ImprimirFicha();
            contaBancaria3.ImprimirFicha();

            Console.WriteLine();
            Console.WriteLine();
        }

        static void Method()
        {
            string variavel = "main";
        }
    }

    class ContaBancaria
    {
        public readonly double Id;
        
        public string nome { get; set; }
        public int cpf { get; set; }
        public string email { get; set; }

        private double saldo;
        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                saldo = value;
            }
        }

        public ContaBancaria(int i)
        {
        }
        public ContaBancaria(long i)
        {
        }


        public ContaBancaria(double id, string n, int c, string e, double s)
        {
            Id = id;
            nome = n;
            cpf = c;
            email = e;
            saldo = s;
        }

        public void ImprimirFicha()
        {
            Imprimir();
        }

        private void Imprimir()
        {
            Console.WriteLine($"\nNome:{nome} \nCPF: {cpf} \nE-mail: {email} \nSaldo: {saldo.ToString("C")}");
        }
    }

    static class Investimento
    {
        public const double alicota = 1.1;

        public static double Investimento01(int prazo, double valor)
        {
            return valor * prazo * alicota;
        }

        public static double Investimento02(int prazo, double valor)
        {
            return valor * prazo * alicota;
        }

        public static double Investimento03(int prazo, double valor)
        {
            return valor * prazo * alicota;
        }
    }
}
