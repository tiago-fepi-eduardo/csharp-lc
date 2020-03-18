using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo2.General
{
    class ProgramI
    {
        static void Main()
        {
            // Instancia das classes concretas
            Passaro oPassaro = new Passaro();
            Console.WriteLine( oPassaro.BaterAsas());

            Peixe oPeixe = new Peixe();
            Console.WriteLine(oPeixe.MexerNadadeiras());

            Mutacao oMutacao = new Mutacao();
            Console.WriteLine( oMutacao.BaterAsas());
            oMutacao.MexerNadadeiras();

            // Instancias baseado na interface
            IVoar voar = new Passaro();
            Console.WriteLine( voar.BaterAsas());

            INadar nadar = new Peixe();
            Console.WriteLine( nadar.MexerNadadeiras());

            IVoar voar2 = new Mutacao();
            Console.WriteLine( voar.BaterAsas());
            INadar nadar2 = new Mutacao();
            Console.WriteLine(nadar2.MexerNadadeiras());
        }
    }
}
