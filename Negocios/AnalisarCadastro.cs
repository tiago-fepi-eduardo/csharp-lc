using System;

namespace Negocios
{
    public class AnalisarCadastro
    {
        public bool Analisar(string cadastro)
        {
            if (cadastro == "")
                return false;
            else
                return true;
        }
    }
}
