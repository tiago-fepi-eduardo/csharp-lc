using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation
{
    public class Integracao
    {
        public string RetornarStringPublic()
        {
            string texto = "Integracao exectada com sucesso!!!";
            return texto;
        }

        private string RetornarStringPrivate()
        {
            string texto = "Integracao exectada com sucesso 1!!!";
            return texto;
        }

        internal string RetornarStringInternal()
        {
            string texto = "Integracao exectada com sucesso 3!!!";
            return texto;
        }

        protected string RetornarStringProtected()
        {
            string texto = "Integracao exectada com sucesso 4!!!";
            return texto;
        }
    }
}
