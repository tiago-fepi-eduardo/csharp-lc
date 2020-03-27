using System;
using System.Collections.Generic;

namespace Interface
{
    public interface IEmprestimo
    {
        void RealizarEmprestimo(int id, DateTime dataEmprestimo, IPessoa p, ILivro l);

        int GetId();

        ILivro GetLivro();

        public IPessoa GetPessoa();

        IEmprestimo BuscarEmprestimo(int id, List<IEmprestimo> listEmprestimo);

        IEmprestimo BuscarEmprestimoPorLivro(ILivro livro, List<IEmprestimo> listEmprestimo);

        IEmprestimo BuscarEmprestimoPorPessoa(IPessoa pessoa, List<IEmprestimo> listEmprestimo);

    }
}
