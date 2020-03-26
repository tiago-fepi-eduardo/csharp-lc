using Interface;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class Pessoa : IPessoa
    {
        public string CPF { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(string c, string n, string e)
        {
            CPF = c;
            Nome = n;
            Email = e;
        }

        public IPessoa BuscarPessoa(string cpf, List<IPessoa> listPessoa)
        {
            return listPessoa.Where(x => x.GetCpf() == cpf).FirstOrDefault();
        }

        public string GetCpf()
        {
            return CPF;
        }

        public string ImprimirPessoa()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"--> CPF: {CPF} / Nome: {Nome} / E-mail: {Email}");
            return stringBuilder.ToString();
        }
    }
}
