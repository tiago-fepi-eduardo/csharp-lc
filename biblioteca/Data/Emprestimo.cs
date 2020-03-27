using Interface;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public IEmprestimo BuscarEmprestimo(int id, List<IEmprestimo> listEmprestimo)
        {
            return listEmprestimo.Where(x => x.GetId() == id).FirstOrDefault();
        }

        public IEmprestimo BuscarEmprestimoPorPessoa(IPessoa pessoa, List<IEmprestimo> listEmprestimo)
        {
            return listEmprestimo.Where(x => x.GetPessoa() == pessoa).FirstOrDefault();
        }

        public IEmprestimo BuscarEmprestimoPorLivro(ILivro livro, List<IEmprestimo> listEmprestimo)
        {
            return listEmprestimo.Where(x => x.GetLivro() == livro).FirstOrDefault();
        }

        public int GetId()
        {
            return Id;
        }

        public IPessoa GetPessoa()
        {
            return Pessoa;
        }

        public ILivro GetLivro()
        {
            return Livro;
        }
    }
}
