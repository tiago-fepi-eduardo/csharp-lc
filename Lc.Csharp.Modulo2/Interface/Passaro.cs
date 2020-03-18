using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo2.Interface
{
    class Passaro : IVoar
    {
        public string Especie { get; set; }

        public string BaterAsas()
        {
            return "Batendo asas!";
        }

        public string Bicar()
        {
            return "Bicando!";
        }
    }
}
