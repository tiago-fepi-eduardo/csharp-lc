using System;
using System.Globalization;

namespace Lc.Cdsharp
{
    class DataYpe
    {
        #region Main

        //static void Main()
        //{
        //    Console.WriteLine("Iniciando programa!");

        //    /*            
        //    int numero = 100;
        //    long numeroL = 100;
        //    bool ok = true;
        //    char letra = 't';
        //    double valorD = 1.123;
        //    decimal dinheiro = 1.123M;
        //    float valorF = 1.123F;

        //    Console.WriteLine("Minha impressao: " + texto);
        //    Console.WriteLine("Minha impressao: " + numeroL);
        //    Console.WriteLine("Minha impressao: " + numero);
        //    Console.WriteLine("Minha impressao: " + letra);
        //    Console.WriteLine("Minha impressao: " + valorD);
        //    Console.WriteLine("Minha impressao: " + valorF);
        //    Console.WriteLine("Minha impressao: " + ok);
        //    Console.WriteLine("Minha impressao: " + dinheiro);
    
        //    // Concatenacao de string
        //    string texto1 = "Ola";
        //    string texto2 = "Tiago";
        //    string concatenado = texto1 + " / " + texto2;
        //    Console.WriteLine("Concat = " + concatenado);

        //    // Soma
        //    int num1 = 100;
        //    int num2 = 50;
        //    int result = num1 + num2;
        //    string res = Convert.ToString(num1 + num2);
            
        //    Console.WriteLine("Soma = " + result);
        //    Console.WriteLine("Soma e transforma = " + res);
    
        //    // Conversao inteiros
        //    string num3 = "1";
        //    string num4 = "2";
        //    string resultado = num3 + num4;
        //    int resultadoInt = Convert.ToInt32(num3) + Convert.ToInt32(num4);
        //    Console.WriteLine("Concate = " + resultado);
        //    Console.WriteLine("Convert str -> int = " + resultadoInt);
        //    */

        //    //CultureInfo culture = new CultureInfo("en-US");

        //    //DateTime dateTime = DateTime.Now.AddDays(1);
        //    //DateTime dateTimeManual = new DateTime(1990, 01, 01, 20, 10, 34);

        //    //Console.WriteLine("Horario atual: " + dateTime.ToString(culture));
        //    //Console.WriteLine("Horario atual: " + dateTime.ToShortDateString());
        //    //Console.WriteLine("Horario atual: " + dateTime.ToShortTimeString());
        //    //Console.WriteLine("Horario atual: " + dateTimeManual);

        //    double num1 = 10;

        //    double pot = Math.Pow(num1, 2);
        //    double raiz = Math.Sqrt(num1);
        //    double cub = Math.Cbrt(num1);
        //    double max = Math.Max(1, 100);
        //    double min = Math.Min(1, 100);
        //    double round = Math.Round(1.34567, 2);

        //    Console.WriteLine(pot);
        //    Console.WriteLine(raiz);
        //    Console.WriteLine(cub);
        //    Console.WriteLine(max);
        //    Console.WriteLine(min);
        //    Console.WriteLine(round);
        //}

        //static void Main(string[] args)
        //{
        //    for (int argnum = 0; argnum < args.Length; argnum++)
        //    {
        //        Console.WriteLine("arg {0}: {1}", argnum++, args[argnum]);
        //    }
        //    Console.Read();
        //}

        //static int Main(string[] args)
        //{
        //    return -1;
        //}

        //static int Main()
        //{
        //    Random r = new Random();
        //
        //    if (r.Next(2) == 0)
        //    {
        //        Console.WriteLine("Returning SUCCESS(0)");
        //        return 0;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Returning ERROR(-1)");
        //        return -1;
        //    }
        //}

        #endregion

        #region Variaveis, conversão,  concatenacao, operacoes, culturas, math

        //static void Main()
        //{
        //    #region Variaveis

        //    int i = 1;
        //    long l = 10;
        //    string s = "Hello World";
        //    bool b = true;
        //    char c = 'a';
        //    decimal d = 1.345M;
        //    float f = 1.345F;
        //    double dou = 1.345;

        //    //Float    2 ^ 24     4 bytes
        //    //Double   2 ^ 53     8 bytes
        //    //Decimal  2 ^ 113    16 bytes

        //    Console.Write("i = " + i);
        //    Console.Write("s = " + s);
        //    Console.Write("b = " + b);
        //    Console.Write("c = " + c);
        //    Console.Write("d = " + d);
        //    Console.Write("f = " + f);
        //    Console.Write("dou = " + dou);

        //    #endregion

        //    #region Conversao e concatenacao

        //    //Conversao
        //    string num1 = "1";
        //    string num2 = "1";
        //    int num1Converted = Convert.ToInt16(num1);
        //    int num2Converted = Convert.ToInt16(num2);
        //    int result1 = num1Converted + num2Converted;
        //    Console.WriteLine("Soma = " + result1);

        //    //Concatenacao
        //    string num3 = "1";
        //    string num4 = "1";
        //    string result2 = num3 + num4;
        //    Console.WriteLine("Concatenacao = " + result2);

        //    double num5 = 1.1;
        //    float num6 = 1.1F;
        //    double result3 = num5 + num6;
        //    Console.WriteLine("Soma = " + result3);
        //    Console.WriteLine("Soma arredondada = " + Math.Round(result3, 2));
        //    Console.WriteLine("Soma currency = " + result3.ToString("C3"));
        //    Console.WriteLine("Soma float = " + result3.ToString("F3"));

        //    decimal num7 = 1.1M;
        //    decimal num8 = 1.1M;
        //    double num9 = 1.1;
        //    decimal result4 = num7 + num8 + Convert.ToDecimal(num9);
        //    Console.WriteLine("Soma = " + result4);

        //    #endregion

        //    #region Datas e Culturas

        //    DateTime dateValue = new DateTime(2019, 6, 1, 16, 37, 0);
        //    CultureInfo[] cultures = { new CultureInfo("en-US"),
        //                         new CultureInfo("fr-FR"),
        //                         new CultureInfo("it-IT"),
        //                         new CultureInfo("de-DE"),
        //                            new CultureInfo("pt-BR")};
        //    foreach (CultureInfo culture in cultures)
        //    {
        //        Console.WriteLine("{0}: {1}", culture.Name, dateValue.ToString(culture));
        //        Console.WriteLine("Soma currency = " + result3.ToString("C2", culture));
        //    }

        //    #endregion

        //    #region Operadores

        //    double n1 = 1.5;
        //    double n2 = 1.5;
        //    double som, mult, div, sub, pot, raiz, max, min;
        //    som = n1 + n2;
        //    mult = n1 * n2;
        //    div = n1 / n2;
        //    sub = n1 - n2;
        //    pot = Math.Pow(n1, 10);
        //    raiz = Math.Sqrt(n1);
        //    max = Math.Max(1, 10);
        //    min = Math.Min(1, 10);

        //    Console.WriteLine("Soma: " + som);
        //    Console.WriteLine("Mult: " + mult);
        //    Console.WriteLine("Div: " + div);
        //    Console.WriteLine("Sub: " + sub);
        //    Console.WriteLine("Pot: " + pot);
        //    Console.WriteLine("Raiz: " + raiz);
        //    Console.WriteLine("Max: " + max);
        //    Console.WriteLine("Min: " + min);

        //    #endregion

        //    #region arrays

        //    string[] regiao = { "Sul", "Centro", "sudeste", "Nordeste", "Norte" };
        //    string[] cidades = new string[3];

        //    cidades[0] = "Barueri";
        //    cidades[1] = "Belo Horizonte";
        //    cidades[2] = "Sao Paulo";

        //    //Console.WriteLine("Regiao: " + regiao[0]);
        //    //Console.WriteLine("cidade: " + cidades[0]);

        //    for (int indice = 0; indice < regiao.Length; indice++)
        //    {
        //        Console.WriteLine("Regiao: " + regiao[indice]);
        //    }

        //    #endregion

        //    Console.Read();
        //}

        #endregion
    }
}

