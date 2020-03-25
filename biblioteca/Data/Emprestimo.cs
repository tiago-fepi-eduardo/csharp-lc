using Interface;
using System;

namespace Data
{
    public class Emprestimo : IEmprestimo
    {
        private int Id { get; set; }

        private DateTime DataEmprestimo { get; set; }

        private IPessoa Pessoa { get; set; }

        private ILivro Livro { get; set; }

        public void RealizarEmprestimo(int id, DateTime d, IPessoa p, ILivro l)
        {
            Id = id;
            DataEmprestimo = d;
            Pessoa = p;
            Livro = l;
        }

        public DateTime GetData()
        {
            return DataEmprestimo;
        }

        public int GetId()
        {
            return Id;
        }

        public ILivro GetLivro()
        {
            return Livro;
        }

        public IPessoa GetPessoa()
        {
            return Pessoa;
        }
    }
}
