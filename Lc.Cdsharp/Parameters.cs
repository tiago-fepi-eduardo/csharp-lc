using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo1
{
    class Parameters
    {
        //static void Main()
        //{
        //    //Metodo void sem parametro
        //    ExecutarVetores();

        //    //Metodo com retorno mas sem parametro
        //    Console.WriteLine(AcionarSemafaro());

        //    //Metodo com parametro mas sem retorno
        //    int[] numeros = { 1, 2, 3, 4, 5 };
        //    ExecutarForEach(numeros);
            
        //    //Metodo com retorno e com parametro
        //    Console.WriteLine(AcionarSemafaroV2("AMARELO"));

        //    //Acessando Classes
        //    Pessoa pessoa1 = new Pessoa();
        //    pessoa1.idade = 25;
        //    pessoa1.Nome = "Adao";
        //    pessoa1.ImprimirIdentidade();

        //    Pessoa pessoa2 = new Pessoa();
        //    pessoa2.idade = 20;
        //    pessoa2.Nome = "Eva";
        //    pessoa2.ImprimirIdentidade();

        //    //Acessando classe static
        //    double resultado = Calculo.Delta(2, 3, 5);
        //    Console.WriteLine("Delta e: " + resultado);



        //    /*
        //    ///////WHILE
            
        //    int cont = 0;
        //    bool status = true;
        //    while (status)
        //    {
        //        Console.WriteLine("True");

        //        if (cont == 5)
        //            status = false;
        //        else
        //            cont++;
        //    }


        //    ////////DO
        //    int cont = 0;
        //    bool status = true;
        //    do
        //    {
        //        Console.WriteLine("True");

        //        if (cont == 5)
        //            status = false;
        //        else
        //            cont++;
        //    } while (status);


        //    ////////FOR
        //    int[] numeros = { 1, 2, 3, 4 };
        //    string[] cidades = { "Santa Rita", "Campinas", "Varginha", "Sao Tome das Letras" };
        //    for (int i = 0; i < numeros.Length; i++)
        //    {
        //        Console.WriteLine("indice=" + i + " Valor=" + numeros[i]);
        //    }
        //    */
        //}

        static void ExecutarVetores()
        {
            string[] cidades = { "Santa Rita", "Campinas" };
            string[] pessoas = new string[5];
            pessoas[0] = "Kuririn";
            pessoas[1] = "Kurir";
            pessoas[2] = "Kur";
            pessoas[3] = "Ku";
            pessoas[4] = "K";

            Console.WriteLine("Cidade= " + cidades[0]);
            Console.WriteLine("Cidade= " + pessoas[2]);
        }

        static string AcionarSemafaro()
        {
            string result = string.Empty;

            string semafaro = "amarelo";
            switch (semafaro.ToUpper())
            {
                case "VERMELHO":
                    result = "VERMELHO";
                    break;
                case "AMARELO":
                    result = "AMARELO";
                    break;
                default:
                    result = "VERDE";
                    break;
            }

            return result;
        }

        static void ExecutarForEach(int[] numeros)
        {
            foreach (int x in numeros)
            {
                Console.WriteLine("Numeros=" + x);
            }
        }

        static string AcionarSemafaroV2(string semafaro)
        {
            string result;

            if (semafaro.ToUpper().Equals("VERMELHO"))
                result = "VERMELHO";
            else if (semafaro.ToUpper().Equals("AMARELO"))
                result = "AMARELO";
            else
                result = "VERDE";

            return result;
        }

        //static void Main()
        //{
        //    #region If else

        //    bool ok = true;

        //    if (ok == true)
        //        Console.WriteLine("Dentro do if");
        //    else
        //        Console.WriteLine("Fora do if");


        //    string semaforo = "vermelho";

        //    if(semaforo == "vermelho")
        //        Console.WriteLine("If Vermelho");
        //    else if(semaforo == "amarelo")
        //        Console.WriteLine("If Amarelo");
        //    else
        //        Console.WriteLine("If Verde");

        //    #endregion

        //    Console.WriteLine(); // Pular linha

        //    #region switch 

        //    switch (semaforo)
        //    {
        //        case "vermelho":
        //            Console.WriteLine("Switch Vermelho");
        //            break;
        //        case "amarelo":
        //            Console.WriteLine("Switch Amarelo");
        //            break;
        //        default:
        //            Console.WriteLine("Switch Verde");
        //            break;
        //    }
        //    // Double similar case
        //    // tips: tab tab

        //    #endregion

        //    Console.WriteLine(); // Pular linha

        //    #region For

        //    int tamanho = 10;

        //    for (int i = 0; i < tamanho; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    // Decrescente ou andar de 2 em 2

        //    #endregion

        //    Console.WriteLine(); // Pular linha

        //    #region while / Do

        //    int indice = 0;
        //    bool gatilho = true;

        //    while (gatilho)
        //    {
        //        Console.WriteLine("While " + gatilho);

        //        if (indice == 1)
        //            gatilho = false;
        //        else
        //            indice++;
        //    }

        //    Console.WriteLine(); // Pular linha

        //    // Reset the variables
        //    indice = 0;
        //    gatilho = true;
        //    do
        //    {
        //        Console.WriteLine("Do " + gatilho);

        //        if (indice == 1)
        //            gatilho = false;
        //        else
        //            indice++;
        //    } while (gatilho);

        //    #endregion

        //    Console.WriteLine(); // Pular linha

        //    #region Foreach

        //    int[] idades = { 9, 8, 10, 7, 5, 4 };

        //    foreach (var idade in idades)
        //    {
        //        Console.WriteLine("Idade = " + idade);
        //    }

        //    #endregion

        //    Console.Read();
        //}
    }

    /// <summary>
    /// Classe
    /// </summary>
    class Pessoa
    {
        public string Nome;
        public int idade;

        public string ImprimirIdentidade()
        {
            return "\nNome = " + Nome + "\nIdade = " + idade;
        }
    }

    /// <summary>
    /// Classe static
    /// </summary>
    static class Calculo
    {
        public static string Dia;
        public static int idade;

        public static double Delta(int a, int b, int c)
        {
            return (b * b) - (4 * a * c);
        }
    }
}
