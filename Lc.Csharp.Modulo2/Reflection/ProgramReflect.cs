using System;
using System.Collections.Generic;
using System.Text;
using Presentation;
using System.Reflection;

namespace Lc.Csharp.Modulo2.Reflection
{
    class ProgramReflect
    {
        static void Main()
        {
            DllviaReflection();
        }

        static void DllviaReflection()
        {
            // Carrega dll
            Assembly assembly = Assembly.LoadFile(@"C:\Tiago\LetsCode\repo_csharp\csharp-lc\Lc.Csharp.Modulo2\dll\Presentation.dll");

            // Carrega namespace e classe
            Type exterType = assembly.GetType("Presentation.Externo");

            // Carrega metodo
            MethodInfo method = exterType.GetMethod("ConteudoPublico");

            // Cria instancia da classe
            object exterInstancia = Activator.CreateInstance(exterType);

            // Adiconada metodo
            var r = method.Invoke(exterInstancia, null);

            Console.WriteLine(r.ToString());
        }

        static void DllViaReferencia()
        {
            Integracao integracao = new Integracao();
            string res = integracao.RetornarString();
            Console.WriteLine(res);
        }
    }
}
