﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo1.Projeto
{
    public class Program
    {
        public static List<Candidato> votacao = new List<Candidato>();
        public static List<Candidato> candidatos = new List<Candidato>();

        //static void Main()
        //{
        //    CriarCandidatos();

        //    int optMenu01 = 0;
        //    do
        //    {
        //        StringBuilder menu01 = new StringBuilder();
        //        menu01.Append("\n1 - Votar");
        //        menu01.Append("\n2 - Contagem");
        //        menu01.Append("\n3 - Sair");

        //        Console.WriteLine(menu01);
        //        optMenu01 = Int32.Parse(Console.ReadLine());

        //        switch (optMenu01)
        //        {
        //            case 1:
        //                Votar();
        //                break;
        //            case 2:
        //                Contagem();
        //                break;
        //            case 3:
        //                break;
        //        }

        //    } while (optMenu01 != 3);
        //}

        private static void CriarCandidatos()
        {
            Candidato candidato1 = new Candidato("\nCandidato 1", 1, TipoCandidato.Valido);
            Candidato candidato2 = new Candidato("\nCandidato 2", 2, TipoCandidato.Valido);
            Candidato candidato3 = new Candidato("\nBranco", 3, TipoCandidato.Branco);
            Candidato candidato4 = new Candidato("\nNulo", 4, TipoCandidato.Nulo);

            candidatos.Add(candidato1);
            candidatos.Add(candidato2);
            candidatos.Add(candidato3);
            candidatos.Add(candidato4);
        }

        private static void Contagem()
        {
            Eleicao.Contagem();
        }

        private static void Votar()
        {
            bool votoValido = false;
            do
            {
                StringBuilder menu02 = new StringBuilder();
                menu02.Append("\n1 - Candidato 1");
                menu02.Append("\n2 - Candidato 2");
                menu02.Append("\n3 - Branco");
                menu02.Append("\n4 - Nulo");
                Console.WriteLine(menu02);
                int voto = Int32.Parse(Console.ReadLine());

                switch (voto)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        Eleicao.Votar(candidatos[voto - 1]);
                        votoValido = true;
                        break;
                    default:
                        votoValido = false;
                        break;
                }
            } while (! votoValido);
        }
    }

    public enum TipoCandidato
    {
        Valido,
        Nulo,
        Branco
    }

    public class Candidato
    {
        public string Nome { get; set; }

        public int Numero { get; }

        public TipoCandidato Tipo { get; set; }

        public Candidato(string n, int c, TipoCandidato t)
        {
            Nome = n;
            Numero = c;
            Tipo = t;
        }
    }

    public static class Eleicao
    {
        public static void Votar(Candidato candidato)
        {
            Program.votacao.Add(candidato);
        }

        public static void Contagem()
        {
            int totalCandidato1 = 0;
            int totalCandidato2 = 0;
            int totalNulo = 0;
            int totalBranco = 0;
            int totalVotos = Program.votacao.Count;
            string vencedor = string.Empty;

            foreach (var item in Program.votacao)
            {
                switch (item.Numero)
                {
                    case 1:
                        totalCandidato1++;
                        break;
                    case 2:
                        totalCandidato2++;
                        break;
                    case 3:
                        totalBranco++;
                        break;
                    case 4:
                        totalNulo++;
                        break;
                }
            }

            if (totalCandidato1 > totalCandidato2)
                vencedor = Program.candidatos[0].Nome;
            else if (totalCandidato1 < totalCandidato2)
                vencedor = Program.candidatos[1].Nome;
            else
                vencedor = "Empate";

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"\nTotal de Votos: {totalVotos}");
            stringBuilder.Append($"\nTotal de Nulo: {ConvertePorcentagem(totalVotos, totalNulo)}");
            stringBuilder.Append($"\nTotal Branco {ConvertePorcentagem( totalVotos, totalBranco)}");
            stringBuilder.Append($"\nCandidato 1: {ConvertePorcentagem(totalVotos, totalCandidato1)}");
            stringBuilder.Append($"\nCandidato 2: {ConvertePorcentagem(totalVotos, totalCandidato2)}");
            stringBuilder.Append($"\nVENCEDOR: {vencedor}");
            Console.WriteLine(stringBuilder);
        }

        private static double ConvertePorcentagem(int total, int valor)
        {
            return (valor * 100) / total;
        }
    }
}
