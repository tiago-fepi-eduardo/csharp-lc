using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo1.Praticando
{
    class PraticandoEnum
    {
        //static void Main()
        //{
        //    Console.WriteLine("## ENUM ##");
        //    Console.WriteLine("Enum = " + Cor.Verde);
        //    Console.WriteLine("Enum = " + (int)Cor.Verde);


        //    string palavra = "";
        //    Cor variavelTipoCor = Cor.Verde;
        //    Console.WriteLine("Tipo = " + variavelTipoCor);


        //    Carro carro = new Carro();
        //    carro.Fabricante = "fiat";
        //    carro.Marca = "Palio";
        //    carro.Pintura = Cor.Vermelho;

        //    Console.ReadKey();
        //}
    }

    enum Cor
    {
        Verde = 100,
        Amarelo = 200,
        Vermelho = 300
    }

    class Carro
    {
        public string Marca { get; set; }

        public string Fabricante { get; set; }

        public Cor Pintura { get; set; }
    }
}
