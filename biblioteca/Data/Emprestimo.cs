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

        public int GetId()
        {
            return Id;
        }
    }
}
