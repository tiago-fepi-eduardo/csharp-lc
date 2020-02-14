using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo1
{
    class lista03
    {
        //static void Main()
        //{
        //    Time time = new Time("Flamengo", 25, "Futebol Feminino");

        //    time.Imprimir();

        //    Console.WriteLine("\n::Contratou");
        //    time.Contratar(1);

        //    time.Imprimir();

        //    time.SetQuantidadeJogador(DepartamentoMedico.LesionarJogador(time.GetQuantidadeJogador()));

        //    Console.WriteLine("\n::Lesionou");
        //    time.Imprimir();

        //    Console.ReadLine();
        //}
    }
    
    public class Time
    {
        public string Nome { get; set; }
        private int QuantidadeJogadores { get; set; }
        public string Esporte { get; }

        public Time(string nome, int numeroJogadores, string esporte)
        {
            Nome = nome;
            QuantidadeJogadores = numeroJogadores;
            Esporte = esporte;
        }
        
        public void Contratar(int quantidadeJogador)
        {
            QuantidadeJogadores += quantidadeJogador;
        }

        public int GetQuantidadeJogador()
        {
            return QuantidadeJogadores;
        }

        public void SetQuantidadeJogador(int qtde)
        {
            QuantidadeJogadores = qtde;
        }

        public void Imprimir()
        {
            StringBuilder str = new StringBuilder();
            str.Append($"\nTime: {Nome} \nQtde Jogadores: {QuantidadeJogadores} \nEsporte: {Esporte}");
            Console.WriteLine(str);
        }
    }

    public static class DepartamentoMedico
    {
        public static int LesionarJogador(int qtdeJogadores)
        {
            int lesionados = new Random().Next(0, 5);
            return qtdeJogadores - lesionados;
        }
    }

}