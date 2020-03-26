using System;
using System.Collections.Generic;

namespace Interface
{
    public interface IPessoa
    {
        string GetCpf();
        IPessoa BuscarPessoa(string cpf, List<IPessoa> listPessoa);
    }
}
