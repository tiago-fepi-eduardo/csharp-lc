using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace Lc.Csharp.Modulo1
{
    class FileWork
    {
        //static void Main()
        //{
            
        //}

        #region Folder

        static void CriarPasta()
        {
            string sourcePath = @"C:\Users\tiago\Documents\ExemploAula\Origem";
            string targetPath = @"C:\Users\tiago\Documents\ExemploAula\Destino";

            Directory.CreateDirectory(sourcePath);
            Directory.CreateDirectory(targetPath);

            Console.WriteLine("Sucesso");
        }

        static void DeletarPasta()
        {
            string sourcePath = @"C:\Users\tiago\Documents\ExemploAula\Origem";
            string targetPath = @"C:\Users\tiago\Documents\ExemploAula\Destino";

            try
            {
                Directory.Delete(sourcePath);
                Directory.Delete(targetPath);
                //Directory.Delete(targetPath, true);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Sucesso");
        }

        #endregion

        #region File

        static void CriarArquivo()
        {
            string file = "FileNovo.txt";
            string pasta = @"C:\Users\tiago\Documents\ExemploAula\Origem";
            string pathString = Path.Combine(pasta, file);

            if (!File.Exists(pathString))
            {
                //using (FileStream fs = File.Create(pathString))
                //{
                //    Byte[] texto1 = new UTF8Encoding(true).GetBytes("Primeira linha");
                //    fs.Write(texto1, 0, texto1.Length);

                //    byte[] texto2 = new UTF8Encoding(true).GetBytes("Segunda linha");
                //    fs.Write(texto2, 0, texto2.Length);
                //}

                using (StreamWriter sw = File.CreateText(pathString))
                {
                    sw.WriteLine("New file created: {0}", DateTime.Now.ToString());
                    sw.WriteLine("Author: Mahesh Chand");
                    sw.WriteLine("Add one more line ");
                    sw.WriteLine("Add one more line ");
                    sw.WriteLine("Done! ");
                }
            }
            else
            {
                Console.WriteLine("Aruivo \"{0}\" ja existe.", file);
                return;
            }

            Console.WriteLine("Sucesso");
        }

        static void LerArquivos()
        {
            string pathString = @"C:\Users\tiago\Documents\ExemploAula\Origem\FileNovo.txt";

            using (StreamReader sr = File.OpenText(pathString))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

            Console.WriteLine("Sucesso");
        }

        static void DeletarArquivo()
        {
            string file = @"C:\Users\tiago\Documents\ExemploAula\Origem\fileNovo.txt";

            //if (File.Exists(file))
            //{

            File.Delete(file);

            //}

            Console.WriteLine("Sucesso");
        }

        static void MoverArquivo()
        {
            string sourcePath = @"C:\Users\tiago\Documents\ExemploAula\Origem\fileNovo.txt";
            string targetPath = @"C:\Users\tiago\Documents\ExemploAula\Destino\fileNovo_copy.txt";

            File.Copy(sourcePath, targetPath, true);

            Console.WriteLine("Sucesso");
        }

        static void MoverTodosArquivos()
        {
            string sourcePath = @"C:\Users\tiago\Documents\ExemploAula\Origem";
            string targetPath = @"C:\Users\tiago\Documents\ExemploAula\Destino";

            if (Directory.Exists(sourcePath))
            {
                string[] files = Directory.GetFiles(sourcePath);

                foreach (string s in files)
                {
                    string fileName = Path.GetFileName(s);
                    string destFile = Path.Combine(targetPath, fileName);
                    File.Copy(s, destFile, true);
                }
            }
            else
            {
                Console.WriteLine("Source path does not exist!");
            }

            Console.WriteLine("Sucesso");
        }

        #endregion
    }
}
