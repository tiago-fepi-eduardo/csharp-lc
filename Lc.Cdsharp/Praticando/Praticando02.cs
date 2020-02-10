using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo1.Praticando
{
    public class Praticando02
    {
        static void Main()
        {
            Console.WriteLine("-------CONTAS CRIADAS");
            ContaBancaria contaBancaria = new ContaBancaria();
            contaBancaria.nome = "Joaquin Phenix";
            contaBancaria.cpf = 0152020000;
            contaBancaria.email = "killthebatman@gotham.us";
            contaBancaria.Saldo = 10.00;
            contaBancaria.ImprimirFicha();

            ContaBancaria contaBancaria2 = new ContaBancaria();
            contaBancaria2.nome = "Bart Simpson";
            contaBancaria2.cpf = 333320000;
            contaBancaria2.email = "skate@destroy.us";
            contaBancaria2.Saldo = 10.00;
            contaBancaria2.ImprimirFicha();

            ContaBancaria contaBancaria3 = new ContaBancaria();
            contaBancaria3.nome = "Monica";
            contaBancaria3.cpf = 321456987;
            contaBancaria3.email = "lovehabbit@melancia.com";
            contaBancaria3.Saldo = 10.00;
            contaBancaria3.ImprimirFicha();

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
    }

    class ContaBancaria
    {
        public string nome;
        public int cpf;
        public string email;
        public double Saldo;

        public void ImprimirFicha()
        {
            Console.WriteLine($"\nNome: {nome} \nCPF: {cpf} \nE-mail: {email} \nSaldo: {Saldo.ToString("C")}");
        }
    }

    public static class Investimento
    {
        public static double Investimento01(int prazo, double valor)
        {
            return valor * prazo * 1.4;
        }

        public static double Investimento02(int prazo, double valor)
        {
            return valor * prazo * 1.3;
        }

        public static double Investimento03(int prazo, double valor)
        {
            return valor * prazo * 1.2;
        }
    }
}
