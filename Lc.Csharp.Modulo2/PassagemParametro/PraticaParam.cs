using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo2.PassagemParametro
{
    class PraticaParam
    {

        static void Main()
        {
            Console.WriteLine("Entre com o primeiro valor: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o segundo valor: ");
            int b = int.Parse(Console.ReadLine());

            // Soma
            int soma = NormalFuncSoma(a, b);
            Console.WriteLine("Soma = " + soma);

            // Subtracao
            int sub = 0;
            RefFuncSubtracao(a, b, ref sub);
            Console.WriteLine("Subtracao = " + sub);

            // Multiplicacao
            OutFuncMultiplicacao(a, b, out int mult);
            Console.WriteLine("Multiplicacao = " + mult);

            // Divisao
            VarFuncDivisao(a, b);
        }

        static int NormalFuncSoma(int a, int b)
        {
            return a + b;
        }

        static void RefFuncSubtracao(int a, int b, ref int sub)
        {
            sub = a - b;
        }

        static void OutFuncMultiplicacao(int a, int b, out int res)
        {
            res = a * b;
        }

        static void VarFuncDivisao(params object[] extraParams)
        {
            int result = int.Parse(extraParams[0].ToString()) / int.Parse(extraParams[1].ToString());

            Console.WriteLine("Divisao = " + result);
        }
    }
}
