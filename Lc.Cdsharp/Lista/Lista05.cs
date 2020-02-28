using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo1.Lista
{
    class Lista05
    {
        //static void Main()
        //{
        //    //Listar();

        //    //Dicionario();

        //    //Pilha();

        //    //Fila();
        //}

        private static void Listar()
        {
            List<int> list = new List<int>();

            while (list.Count < 5)
            {
                Console.WriteLine("## Entre com um numero");
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("\nLista original");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nLista crescente");
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nLista decrescente");
            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nTotal de itens: " + list.Count);
        }

        private static void Dicionario()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            while (dic.Count < 5)
            {
                Console.WriteLine("## Entre com um nome de site");
                string site = Console.ReadLine();

                Console.WriteLine("## Entre com a url do site");
                string url = Console.ReadLine();

                dic.Add(site, url);
            }

            Console.WriteLine("\nToda lista");
            foreach (var item in dic)
            {
                Console.WriteLine(item);
            }

            int opt = 0;
            do
            {
                Console.WriteLine("\n## 1 - Achar um site");
                Console.WriteLine("## 2 - Sair");
                opt = int.Parse(Console.ReadLine());

                if (opt == 1)
                {
                    Console.WriteLine("## Entre com um nome de site");
                    string site = Console.ReadLine();

                    if (dic.TryGetValue(site, out string value))
                        Console.WriteLine("Url = " + value);
                    else
                        Console.WriteLine("Site não encontrado.");
                }
                else if (opt == 2)
                    break;

            } while (opt != 2);
        }

        private static void Pilha()
        {
            Stack<int> s = new Stack<int>();
            int opt = 0;

            do
            {
                Console.WriteLine("\n## 1 - Inserir numero");
                Console.WriteLine("## 2 - Remover numero");
                Console.WriteLine("## 3 - Sair");
                opt = int.Parse(Console.ReadLine());

                if (opt == 1)
                {
                    Console.WriteLine("## Entre com um numero");
                    int  n = int.Parse(Console.ReadLine());
                    s.Push(n);

                    Console.WriteLine("## Impressao");
                    foreach (var item in s)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if(opt == 2)
                {
                    Console.WriteLine("## Removido. ");
                    s.Pop();
                    foreach (var item in s)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (opt == 3)
                    break;

            } while (opt != 3);
        }

        private static void Fila()
        {
            Queue<int> s = new Queue<int>();
            int opt = 0;

            do
            {
                Console.WriteLine("\n## 1 - Inserir numero");
                Console.WriteLine("## 2 - Remover numero");
                Console.WriteLine("## 3 - Sair");
                opt = int.Parse(Console.ReadLine());

                if (opt == 1)
                {
                    Console.WriteLine("## Entre com um numero");
                    int n = int.Parse(Console.ReadLine());
                    s.Enqueue(n);

                    Console.WriteLine("## Impressao");
                    foreach (var item in s)
                    {
                        Console.Write(item);
                    }
                }
                else if (opt == 2)
                {
                    Console.WriteLine("## Removido. ");
                    s.Dequeue();
                    foreach (var item in s)
                    {
                        Console.Write(item);
                    }
                }
                else if (opt == 3)
                    break;

            } while (opt != 3);
        }
    }
}
