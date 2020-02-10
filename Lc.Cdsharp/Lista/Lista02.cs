using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo1
{
    class Lista02
    {
        //static void Main()
        //{
            //Exercicio1();
            
            //Exercicio2();
            
            //Exercicio3();
            
            //Exercicio4();
            
            //Exercicio5();
            
            //Exercicio6();
            
        //    Exercicio7();
            
        //    Console.Read();
        //}

        /* 1. (IF) Solicite duas notas ao usuário, faça a média e imprima na tela “passou” se a média for maior ou igual a 6 e “não passou” caso contrário.*/
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

        /*2. (SWITCH) Imprima na tela “digite ‘i’ para inserir, ‘e’ para editar, ou ‘r’ para remover”.  
        Se digitado ‘i’ imprima “inserindo”, se digitado ‘e’ imprima “editando”, se digitado ‘r’ imprima “removendo”.  
        Se for digitado algo diferente, imprima “comando inválido”.*/
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

        /*3. (ARRAY e FOR) Solicite dez números ao usuário. Armazene esses números em um array de int. Ao final imprima os dez números na tela. */
        public static void Exercicio3()
        {
            int[] numeros = new int[10];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Digite o número {i + 1}:");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

        }

        /*4. Solicite ao usuário 3 números, guarde os 3 valores em variáveis, em seguida, imprima o maior, o menor e a média.*/
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

            if (num1 < num2 && num1 < num3)
                menor = num1;
            else if (num2 < num3)
                menor = num2;
            else
                menor = num3;

            int maior;
            if (num1 > num2 && num1 > num3)
                maior = num1;
            else if (num2 > num3)
                maior = num2;
            else
                maior = num3;

            Console.WriteLine($"Menor: {menor} | Maior: {maior} | Média: {media}");
        }

        /*5. Dado o array[10, 20, 30, 40, 50] solicite ao usuário que digite um número e imprima ‘sim’ se o número estiver presente no array 
        e ‘não’ se ele não estiver presente.*/
        public static void Exercicio5()
        {
            int[] numeros = { 10, 20, 30, 40, 50 };
            Console.WriteLine($"Digite o número:");
            int num = int.Parse(Console.ReadLine());

            bool existe = false;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == num) existe = true;
            }

            Console.WriteLine(existe ? "Sim" : "Não");
        }

        /*6. Um produto custa R$0,50 centavos, mas se comprados pelo menos 100 o preço cai para R$0,20 centavos.
        Solicite ao usuário a quantidade desejada e imprima o valor total da compra. */
        public static void Exercicio6()
        {
            Console.WriteLine("Digite a quantidade:");
            int qtd = int.Parse(Console.ReadLine());

            if (qtd >= 100)
                Console.WriteLine("Valor Total: " + qtd * 0.2f);
            else
                Console.WriteLine("Valor Total: " + qtd * 0.5f);
        }

        /*7.Solicite ao usuário duas datas, essas datas devem ser digitadas em três passos: ano, mês e dia.
        Compare as datas e imprima na tela se a data2 é antes, depois ou a mesma data que data1.*/
        public static void Exercicio7()
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

            //

            Console.WriteLine("Digite o ano da data 2:");
            digitado = Console.ReadLine();
            ano2 = int.Parse(digitado);

            Console.WriteLine("Digite o mês da data 2:");
            digitado = Console.ReadLine();
            mes2 = int.Parse(digitado);

            Console.WriteLine("Digite o dia da data 2:");
            digitado = Console.ReadLine();
            dia2 = int.Parse(digitado);

            if (ano1 > ano2) 
                Console.WriteLine("Data 1 é maior");
            else if (ano1 < ano2) 
                Console.WriteLine("Data 2 é maior");
            else
            {
                if (mes1 > mes2) 
                    Console.WriteLine("Data 1 é maior");
                else if (mes1 < mes2) 
                    Console.WriteLine("Data 2 é maior");
                else
                {
                    if (dia1 > dia2) 
                        Console.WriteLine("Data 1 é maior");
                    else if (dia1 < dia2) 
                        Console.WriteLine("Data 2 é maior");
                    else
                    {
                        Console.WriteLine("As datas são iguais");
                    }
                }
            }
        }
    }
}
