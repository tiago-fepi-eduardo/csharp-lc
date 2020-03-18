using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo2.Interface
{
    public class Peixe : INadar
    {
        public string  Especie { get; set; }

        public string MexerNadadeiras()
        {
            return "Mexendo nadadeiras!";
        }

        public string Respirar()
        {
            return "Respirando agua!";
        }
    }
}
