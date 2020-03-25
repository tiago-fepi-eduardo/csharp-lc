using Interface;
using System;

namespace Data
{
    public class Pessoa : IPessoa
    {
        public int CPF { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public Pessoa(int c, string n, string e)
        {
            CPF = c;
            Nome = n;
            Email = e;
        }

        public int GetCPF()
        {
            return CPF;
        }

        public string GetNome()
        {
            return Nome;
        }

        public string GetEmail()
        {
            return Email;
        }

    }
}
