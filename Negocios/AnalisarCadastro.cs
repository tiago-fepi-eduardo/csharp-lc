using Comum;
using System;
using System.Text;

namespace Negocios
{
    public class AnalisarCadastro
    {
        public string Analisar(ICadastro icadastro)
        {
            StringBuilder validacao = new StringBuilder();

            if (string.IsNullOrEmpty(icadastro.GetNome()))
                validacao.Append("\n Nome nao valido.");

            if (string.IsNullOrEmpty(icadastro.GetSobrenome()))
                validacao.Append("\n Sobrenome nao valido.");

            if (icadastro.GetIdade() < 1 || icadastro.GetIdade() > 150)
                validacao.Append("\n Idade nao valido.");

            return validacao.ToString();
        }
    }
}
