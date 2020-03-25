using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lc.Csharp.Modulo2.Linq
{
    class LinqPratica
    {
        //static void Main()
        //{
        //    // Popular
        //    List<Alunos> alunos = new List<Alunos>();
        //    alunos.Add(new Alunos() { Nome = "J", Idade = 13, Media = 9.5, Imigrante = false });
        //    alunos.Add(new Alunos() { Nome = "B", Idade = 12, Media = 9.2, Imigrante = false });
        //    alunos.Add(new Alunos() { Nome = "C", Idade = 13, Media = 9.7, Imigrante = false });
        //    alunos.Add(new Alunos() { Nome = "G", Idade = 12, Media = 9.9, Imigrante = true });
        //    alunos.Add(new Alunos() { Nome = "E", Idade = 14, Media = 8, Imigrante = false });
        //    alunos.Add(new Alunos() { Nome = "F", Idade = 14, Media = 7, Imigrante = false });
        //    alunos.Add(new Alunos() { Nome = "D", Idade = 13, Media = 5.1, Imigrante = false });
        //    alunos.Add(new Alunos() { Nome = "H", Idade = 13, Media = 6.1, Imigrante = true });
        //    alunos.Add(new Alunos() { Nome = "I", Idade = 11, Media = 7, Imigrante = true });
        //    alunos.Add(new Alunos() { Nome = "A", Idade = 12, Media = 5, Imigrante = false });

        //    var r1 = alunos.Where(x => x.Imigrante == true);
        //    Console.WriteLine($"Quantos alunos são imigrantes: {r1.Count()}");

        //    var r2 = alunos.Where(x => x.Media > 9);
        //    Console.WriteLine($"Quantos alunos possuem media maior que 9: {r2.Count()}");

        //    var r3 = alunos.Where(x => x.Media > 8 && x.Idade == 12);
        //    Console.WriteLine($"Quantos alunos possuem 12 anos e media maior que 8: {r3.Count()}");

        //    Console.WriteLine("\nListe alunos por ordem alfabética");
        //    var r4 = alunos.OrderBy(x => x.Nome);
        //    foreach (var item in r4)
        //    {
        //        Console.Write($" {item.Nome} ");
        //    }

        //    Console.WriteLine("\nListe alunos por ordem decrescente de idade e após por alfabética de nome");
        //    var r5 = alunos.OrderByDescending(x => x.Idade).ThenBy(x => x.Nome);
        //    foreach (var item in r5)
        //    {
        //        Console.Write($" {item.Nome} ");
        //    }

        //    Console.WriteLine("\nListe alunos por ordem crescente de media, depois por ordem alfabetica de nome e que não são imigrantes");
        //    var r6 = alunos.OrderBy(x => x.Media).ThenBy(x => x.Nome).Where(x => x.Imigrante == false);
        //    foreach (var item in r6)
        //    {
        //        Console.Write($" {item.Nome} ");
        //    }
        //}
    }

    public class Alunos
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Media { get; set; }
        public bool Imigrante { get; set; }
    }
}
