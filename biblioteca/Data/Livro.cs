using Interface;
using System.Linq;
using System.Collections.Generic;

namespace Data
{
    public class Livro : ILivro
    {
        public int Tombo { get; set; }

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public Livro()
        {

        }

        public Livro(int c, string n, string e)
        {
            Tombo = c;
            Titulo = n;
            Autor = e;
        }

        public ILivro BuscarLivro(int tombo, List<ILivro> listLivro)
        {
            return listLivro.Where(x => x.GetTombo() == tombo).FirstOrDefault();
        }

        public int GetTombo()
        {
            return Tombo;
        }
    }
}
