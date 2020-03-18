using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo2.General
{
    class Mutacao : INadar, IVoar
    {
        public string BaterAsas()
        {
            return "Bater asas!";
        }

        public string MexerNadadeiras()
        {
            return "Nadando!";
        }
    }
}
