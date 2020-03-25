using Interface;
using System;

namespace Data
{
    public class Livro : ILivro
    {
        public int Tombo { get; set; }

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public Livro(int c, string n, string e)
        {
            Tombo = c;
            Titulo = n;
            Autor = e;
        }

        public int GetTombo()
        {
            return Tombo;
        }

        public string GetTitulo()
        {
            return Titulo;
        }

        public string GetAutor()
        {
            return Autor;
        }
    }
}
