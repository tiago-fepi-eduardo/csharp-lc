using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo1
{
    class Methods
    {
        //static void Main()
        //{
        //    int number1 = 2;
        //    int number2 = 5;

        //    Lab03 instancia = new Lab03();
        //    int res1 = instancia.Somar(number1, number2);
        //    Impressao("soma", res1);

        //    int res2 = instancia.Subtrair(number1, number2);
        //    Impressao("substracao", res2);

        //    int res3 = instancia.Multiplicar(number1, number2);
        //    Impressao("multiplicacao", res3);

        //    int res4 = Dividir(number1, number2);
        //    Impressao("divisao", res4);

        //    Console.Read();
        //}

        private int Somar(int number1, int number2)
        {
            int resultado = number1 + number2;
            return resultado;
        }

        private int Subtrair(int number1, int number2)
        {
            int resultado = number1 - number2;
            return resultado;
        }

        private int Multiplicar(int number1, int number2)
        {
            int resultado = number1 * number2;
            return resultado;
        }

        private static int Dividir(int number1, int number2)
        {
            return number1 / number2;
        }

        private static void Impressao(string operacao, int resultado)
        {
            Console.WriteLine("Resultado da " + operacao + " " + resultado);
        }
    }
}
