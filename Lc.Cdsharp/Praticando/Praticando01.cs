﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo1
{
    class Praticando01
    {
        //static void Main()
        //{
        //    Exercicio1();

        //    Exercicio2();  
        //}

        public static void Exercicio1()
        {
            bool repetirPergunta = true;

            do
            {
                Console.WriteLine("Insira um numero: ");
                int contador = int.Parse(Console.ReadLine());

                if (contador < 11)
                {
                    Exercicio1_Imprimir(contador);
                    repetirPergunta = false;
                }
                else
                    repetirPergunta = true;

            } while (repetirPergunta);
        }

        public static void Exercicio1_Imprimir(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i} Hello World!");
            }
        }
                
        public static void Exercicio2()
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
    }
}
