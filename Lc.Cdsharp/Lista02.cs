using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo1
{
    class Lista02
    {
        //static void Main()
        //{
        //    Exercicio1();

        //    Exercicio2();

        //    Exercicio3();

        //    Exercicio4();

        //    Exercicio5();

        //    Exercicio6();

        //    Exercicio7();

        //    Exercicio8();

        //    Exercicio9();

        //    Exercicio10();

        //    Console.Read();
        //}

        public static void Exercicio1()
        {
            Console.WriteLine("Digite a nota 1");
            float nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 2");
            float nota2 = float.Parse(Console.ReadLine());

            float media = (nota1 + nota2) / 2.0f;

            if (media >= 6) Console.WriteLine("Passou");
            else Console.WriteLine("Não Passou");
        }

        public static void Exercicio2()
        {
            Console.WriteLine("digite ‘i’ para inserir, ‘e’ para editar, ou ‘r’ para remover");
            string comando = Console.ReadLine();
            switch (comando)
            {
                case "i":
                    System.Console.WriteLine("Inserindo...");
                    break;
                case "e":
                    System.Console.WriteLine("Editando...");
                    break;
                case "r":
                    System.Console.WriteLine("Removendo...");
                    break;
                default:
                    System.Console.WriteLine("Comando Inválido!");
                    break;
            }
        }

        public static void Exercicio3()
        {
            Console.WriteLine("Digite um número:");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0) Console.WriteLine("Par");
            else Console.WriteLine("Impar");
        }

        public static void Exercicio4()
        {
            Console.WriteLine("Digite um número:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número:");
            int num3 = int.Parse(Console.ReadLine());

            float media = (num1 + num2 + num3) / 3.0f;

            int menor;

            if (num1 < num2 && num1 < num3) menor = num1;
            else if (num2 < num3) menor = num2;
            else menor = num3;

            int maior;
            if (num1 > num2 && num1 > num3) maior = num1;
            else if (num2 > num3) maior = num2;
            else maior = num3;

            Console.WriteLine($"Menor: {menor} | Maior: {maior} | Média: {media}");
        }

        public static void Exercicio5()
        {
            int num;
            int menor = int.MaxValue;
            int maior = int.MinValue;
            int somat = 0;

            Console.WriteLine("Digite um número:");
            num = int.Parse(Console.ReadLine());

            if (num < menor) menor = num;
            if (num > maior) maior = num;
            somat += num;

            Console.WriteLine("Digite outro número:");
            num = int.Parse(Console.ReadLine());

            if (num < menor) menor = num;
            if (num > maior) maior = num;
            somat += num;

            Console.WriteLine("Digite outro número:");
            num = int.Parse(Console.ReadLine());

            if (num < menor) menor = num;
            if (num > maior) maior = num;
            somat += num;

            float media = somat / 3.0f;

            Console.WriteLine($"Menor: {menor} | Maior: {maior} | Média: {media}");
        }

        public static void Exercicio6()
        {
            Console.WriteLine("Digite a quantidade:");
            int qtd = int.Parse(Console.ReadLine());

            if (qtd >= 100) Console.WriteLine("Valor Total: " + qtd * 0.2f);
            else Console.WriteLine("Valor Total: " + qtd * 0.5f);
        }

        public static void Exercicio7()
        {
            Console.WriteLine("Digite o tamanho do lado 1:");
            int lado1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o tamanho do lado 2:");
            int lado2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o tamanho do lado 3:");
            int lado3 = int.Parse(Console.ReadLine());

            if (lado1 == lado2 && lado1 == lado3) Console.WriteLine("equilátero");
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3) Console.WriteLine("Isósceles");
            else Console.WriteLine("Escaleno");
        }

        public static void Exercicio8()
        {
            int maior, menor, meio;
            string digitado;
            int n1, n2, n3;

            Console.WriteLine("Digite o número 1:");
            digitado = Console.ReadLine();
            n1 = int.Parse(digitado);

            Console.WriteLine("Digite o número 2:");
            digitado = Console.ReadLine();
            n2 = int.Parse(digitado);

            Console.WriteLine("Digite o número 3:");
            digitado = Console.ReadLine();
            n3 = int.Parse(digitado);

            if (n1 > n2 && n1 > n3)
            {
                maior = n1;
                if (n2 > n3)
                {
                    meio = n2;
                    menor = n3;
                }
                else
                {
                    meio = n3;
                    menor = n2;
                }
            }
            else if (n2 > n1 && n2 > n3)
            {
                maior = n2;
                if (n1 > n3)
                {
                    meio = n1;
                    menor = n3;
                }
                else
                {
                    meio = n3;
                    menor = n1;
                }
            }

            else
            {
                maior = n3;
                if (n1 > n2)
                {
                    meio = n1;
                    menor = n2;
                }
                else
                {
                    meio = n2;
                    menor = n1;
                }
            }

            Console.WriteLine($"{menor} {meio} {maior}");
        }

        public static void Exercicio9()
        {
            string digitado;
            int ano1, mes1, dia1;
            int ano2, mes2, dia2;

            Console.WriteLine("Digite o ano da data 1:");
            digitado = Console.ReadLine();
            ano1 = int.Parse(digitado);

            Console.WriteLine("Digite o mês da data 1:");
            digitado = Console.ReadLine();
            mes1 = int.Parse(digitado);

            Console.WriteLine("Digite o dia da data 1:");
            digitado = Console.ReadLine();
            dia1 = int.Parse(digitado);


            Console.WriteLine("Digite o ano da data 2:");
            digitado = Console.ReadLine();
            ano2 = int.Parse(digitado);

            Console.WriteLine("Digite o mês da data 2:");
            digitado = Console.ReadLine();
            mes2 = int.Parse(digitado);

            Console.WriteLine("Digite o dia da data 2:");
            digitado = Console.ReadLine();
            dia2 = int.Parse(digitado);

            if (ano1 > ano2) Console.WriteLine("Data 1 é maior");
            else if (ano1 < ano2) Console.WriteLine("Data 2 é maior");
            else
            {
                if (mes1 > mes2) Console.WriteLine("Data 1 é maior");
                else if (mes1 < mes2) Console.WriteLine("Data 2 é maior");
                else
                {
                    if (dia1 > dia2) Console.WriteLine("Data 1 é maior");
                    else if (dia1 < dia2) Console.WriteLine("Data 2 é maior");
                    else
                    {
                        Console.WriteLine("As datas são iguais");
                    }
                }
            }
        }

        public static void Exercicio10()
        {
            string digitado;
            int a, b, c;

            Console.WriteLine("Digite a:");
            digitado = Console.ReadLine();
            a = int.Parse(digitado);

            Console.WriteLine("Digite b:");
            digitado = Console.ReadLine();
            b = int.Parse(digitado);

            Console.WriteLine("Digite c:");
            digitado = Console.ReadLine();
            c = int.Parse(digitado);

            int delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("Não existem raizes reais");
            }

            else if (delta == 0)
            {
                double raiz = ((b * -1) + Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine($"Uma raize real: {raiz}");
            }

            else
            {
                double raiz = ((b * -1) + Math.Sqrt(delta)) / 2 * a;
                double raiz2 = ((b * -1) - Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine($"Duas raizes reais: {raiz} e {raiz2}");
            }
        }
    }
}
