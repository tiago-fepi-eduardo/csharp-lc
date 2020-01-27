using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo1
{
    class Lista03
    {
        static void Main()
        {
            Exercicio1();

            Exercicio2();

            Exercicio3();

            Exercicio4();

            Exercicio5();

            Exercicio6();

            Exercicio7();

            Exercicio8();

            Exercicio9();

            Exercicio10(); 

            Console.Read();   
        }

        public static void Exercicio1()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Hello World!");
            }
        }

        public static void Exercicio2()
        {
            Console.WriteLine("Digite o comando:");
            string comando = Console.ReadLine().ToLower();

            while (comando != "q")
            {
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

                Console.WriteLine("Digite o comando:");
                comando = Console.ReadLine().ToLower();
            }
        }

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

        public static void Exercicio4()
        {
            int[] numeros = new int[11];
            int acc = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Digite o número {i + 1}:");
                int num = int.Parse(Console.ReadLine());
                numeros[i] = num;
                acc += num;
            }

            float media = acc / 11.0f;

            Array.Sort(numeros);

            int mediana = numeros[5];

            Console.WriteLine($"Média: {media} | Mediana: {mediana}");
        }

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

        public static void Exercicio6()
        {
            int[] numeros = { 10, 20, 30, 40, 50 };
            int[] novos = new int[numeros.Length];

            for (int i = 0; i < numeros.Length; i++)
            {
                novos[i] = numeros[i] / 10;
            }

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }

        public static void Exercicio7()
        {
            bool continuar = true;
            int votosCadidato1 = 0;
            int votosCadidato2 = 0;
            int votosNulos = 0;
            int votosBrancos = 0;
            int totalDeVotos = 0;

            do
            {
                Console.WriteLine("1- Candidato 1\n2- Candidato 2\n3- Nulo\n4- Branco\nDigite seu voto:");
                string digitado = Console.ReadLine();
                int opcao;
                if (int.TryParse(digitado, out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            votosCadidato1++;
                            totalDeVotos++;
                            break;
                        case 2:
                            votosCadidato2++;
                            totalDeVotos++;
                            break;
                        case 3:
                            votosNulos++;
                            totalDeVotos++;
                            break;
                        case 4:
                            votosBrancos++;
                            totalDeVotos++;
                            break;
                        case 6:
                            continuar = false;
                            break;
                    }
                }
            } while (continuar);

            string result = $"Total de votos: {totalDeVotos}";
            result += $"\nCandidato Vencedor: {(votosCadidato1 > votosCadidato2 ? "Candidato 1" : "Candidato 2")}";
            result += $"\nCandidato 1: {votosCadidato1}";
            result += $"\nCandidato 2: {votosCadidato2}";
            result += $"\nPorcentagem Nulos: {((float)votosNulos / (float)totalDeVotos) * 10}%";
            result += $"\nPorcentagem Brancos: {((float)votosBrancos / (float)totalDeVotos) * 10}%";
            Console.WriteLine(result);
        }

        public static void Exercicio8()
        {
            int num;
            Console.WriteLine("Digite um número:");
            string digitado = Console.ReadLine();
            if (int.TryParse(digitado, out num))
            {
                int result = 1;
                for (int i = 1; i <= num; i++)
                {
                    result *= i;
                }
                Console.WriteLine($"fatorial de {num} é {result}.");
            }
        }

        public static void Exercicio9()
        {
            //Usando internal function
            int fatorial(int n)
            {
                if (n == 1) return 1;
                return (n * fatorial(n - 1));
            }
            int num;
            Console.WriteLine("Digite um numero:");
            string digitado = Console.ReadLine();
            if (int.TryParse(digitado, out num))
            {
                int result = fatorial(num);
                Console.WriteLine($"fatorial de {num} é {result}.");
            }
        }

        public static void Exercicio10()
        {
            int[] numeros = new int[11];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Digite o número {i + 1}:");
                string digitado = Console.ReadLine();
                int num = int.Parse(digitado);
                numeros[i] = num;
            }

            int soma = 0;

            foreach (var num in numeros)
            {
                soma += num;
            }

            Array.Sort(numeros);

            int mediana = numeros[5];
            float media = (float)soma / (float)numeros.Length;

            int[] quantidades = new int[numeros.Length];
            for (int i = 0; i < numeros.Length; i++)
            {
                int total = 1;
                for (int j = 0; j < numeros.Length; j++)
                {
                    if (i != j && numeros[i] == numeros[j])
                    {
                        total++;
                    }
                }
                quantidades[i] = total;
            }

            int qtd = -1;
            int index = -1;
            for (int i = 0; i < quantidades.Length; i++)
            {
                if (quantidades[i] > qtd)
                {
                    qtd = quantidades[i];
                    index = i;
                }
            }

            int moda = numeros[index];

            Console.WriteLine($"Média: {media} | Mediana: {mediana} | Moda: {moda}");
        }
    }
}
