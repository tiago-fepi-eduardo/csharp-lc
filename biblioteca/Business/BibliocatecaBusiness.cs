using Interface;
using System;

namespace Business
{
    public class BibliocatecaBusiness
    {
        public IEmprestimo Emprestar(IPessoa pessoa, ILivro livro, IEmprestimo emprestimo)
        {
            int id = 1;
            DateTime dataEmprestimo = DateTime.Now;
            emprestimo.RealizarEmprestimo(id, dataEmprestimo, pessoa, livro);
            return emprestimo;            
        }
    }
}
