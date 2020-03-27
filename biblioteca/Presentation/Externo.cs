using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation
{
    public class Externo
    {
        private string ConteudoPrivado()
        {
            return "Conteudo da dll externo";
        }

        protected string ConteudoProtected()
        {
            return "Conteudo da dll externo";
        }

        public string ConteudoPublico()
        {
            return "Conteudo da dll externo";
        }

        internal string ConteudoInternal()
        {
            return "Conteudo da dll externo";
        }
    }
}
