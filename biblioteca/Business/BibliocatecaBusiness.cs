using Interface;
using System;
using System.Collections.Generic;

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

        public IEmprestimo BuscarEmprestimoPorLivro(IEmprestimo emprestimo, ILivro livro, List<IEmprestimo> listEmprestimo)
        {
            return emprestimo.BuscarEmprestimoPorLivro(livro, listEmprestimo);
        }

        public IEmprestimo BuscarEmprestimoPorPessoa(IEmprestimo emprestimo, IPessoa pessoa, List<IEmprestimo> listEmprestimo)
        {
            return emprestimo.BuscarEmprestimoPorPessoa(pessoa, listEmprestimo);
        }

        public IPessoa BuscarPessoa(IPessoa pessoa, string cpf, List<IPessoa> listPessoa)
        {
            return pessoa.BuscarPessoa(cpf, listPessoa);
        }

        public ILivro BuscarLivro(ILivro livro, int tombo, List<ILivro> listLivro)
        {
            return livro.BuscarLivro(tombo, listLivro);
        }

        public IEmprestimo Devolver(IEmprestimo emprestimo, int id, List<IEmprestimo> listEmprestimo)
        {
            return emprestimo.BuscarEmprestimo(id, listEmprestimo);
        }
    }
}
