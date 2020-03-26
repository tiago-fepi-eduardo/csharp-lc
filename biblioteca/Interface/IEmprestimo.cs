using System;
using System.Collections.Generic;

namespace Interface
{
    public interface IEmprestimo
    {
        void RealizarEmprestimo(int id, DateTime dataEmprestimo, IPessoa p, ILivro l);

        int GetId();

        IEmprestimo BuscarEmprestimo(int id, List<IEmprestimo> listEmprestimo);
    }
}
