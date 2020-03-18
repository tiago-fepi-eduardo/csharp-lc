using System;

namespace Repositorio
{
    public class Cadastro : ICadastro
    {
        private string Nome { get; set; }

        public string GetNome()
        {
            return Nome;
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }
    }
}
