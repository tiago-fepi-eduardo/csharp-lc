using System;
using System.Collections.Generic;

namespace Interface
{
    public interface ILivro
    {
        int GetTombo();

        ILivro BuscarLivro(int tombo, List<ILivro> listLivro);

        string ImprimirLivro();
    }
}
