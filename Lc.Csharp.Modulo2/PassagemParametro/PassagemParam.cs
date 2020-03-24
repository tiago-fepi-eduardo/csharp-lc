using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo2.PassagemParametro
{
    class PassagemParam
    {
        //static void Main()
        //{
        //    // Passagem de parametro padrao
        //    int x = NormalFunc(100);
        //    Console.WriteLine(x);

        //    // Passagem por referencia
        //    int y = 200;
        //    RefFunc(ref y);
        //    Console.WriteLine(y);

        //    // Funcao que retorna out
        //    int z = 300;
        //    OutFunc(z, out int zz);
        //    Console.WriteLine(zz);

        //    // Passagem de uma lista de valores diferente
        //    int w = 400;
        //    string s = "Propriedade";
        //    VarFunc(s, w);
        //}

        static int NormalFunc(int num)
        {
            num++;
            return num;
        }

        static void RefFunc(ref int num)
        {
            num++;
        }

        static void OutFunc(int num, out int res)
        {
            res = num + 1;
        }

        static void VarFunc(params object[] extraParams)
        {
            foreach (object o in extraParams)
            {
                Console.WriteLine($"{o.ToString()}");
            }
        }

    }
}
