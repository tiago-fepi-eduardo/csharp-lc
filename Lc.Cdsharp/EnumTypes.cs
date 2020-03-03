using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo1
{
    class EnumTypes
    {
        /*
        static void Main()
        {
            Console.WriteLine("# Banco #");

            Conta conta = new Conta();
            conta.Nome = "Adao";
            conta.status = Status.Ativado;

            foreach (var item in Enum.GetValues(typeof(Status)))
            {
                Console.WriteLine("-> " + (int)item);
                Console.WriteLine("-> " + item);
            }
        
    */
    }

    class Conta
    {
        public string Nome { get; set; }

        public Status status { get; set; }
    }

    enum Status
    {
        Desativado = 1, 
        Ativado = 2,
        Pendente = 3
    }
}
