using System;
using System.Text;

namespace Aula4
{
    class HelperClasses
    {
        //static void Main(string[] args)
        //{
        //    // Gerando GUID. Id unico
        //    string guid = Guid.NewGuid().ToString();

        //    // Utilizando stringbuilder para montar textos longos
        //    StringBuilder str = new StringBuilder();
        //    str.Append("1 - Inserir");
        //    str.Append("\n2 - Imprimir");
        //    str.Append("\n3 - Sair");

        //    // Gerando numeros aleatorios inteiros ou fracinados.
        //    int numberInteiro = new Random().Next(0, 2);
        //    double number = numberInteiro + new Random().NextDouble();
        //    Console.WriteLine("\nInteiro= " + numberInteiro);
        //    Console.WriteLine("Fracao= " + number);

        //    // Vetor de classes. Criando uma lista para armazenar carros.           
        //    Carro[] listaDeCarros = new Carro[3];

        //    // Criando um carro
        //    Carro carro1 = new Carro();
        //    carro1.Modelo = "Monza";

        //    Carro carro2 = new Carro();
        //    carro2.Modelo = "Corolla";

        //    Carro carro3 = new Carro();
        //    carro3.Modelo = "Gol";

        //    // Armazenando meus carros na minha lista de carros.
        //    listaDeCarros[0] = carro1;
        //    listaDeCarros[1] = carro2;
        //    listaDeCarros[2] = carro3;

        //    // Imprimindo minha lista e todos os carros dentro.
        //    foreach (Carro carro in listaDeCarros)
        //    {
        //        Console.WriteLine("\nMeu carro = " + carro.Modelo);
        //        carro.Acelerar();
        //    }

        //    Console.Read();
        //}
    }

    class Carro
    {
        public string Modelo { get; set; }
        public void Acelerar()
        {
            Console.WriteLine("Vrummm!");
        }
    }
}