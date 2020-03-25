using System;

namespace Interface
{
    public interface IEmprestimo
    {
        int GetId();

        ILivro GetLivro();

        IPessoa GetPessoa();

        void RealizarEmprestimo(int id, DateTime dataEmprestimo, IPessoa p, ILivro l);
    }
}
