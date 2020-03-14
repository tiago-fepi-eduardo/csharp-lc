using System;
using System.IO;

namespace Lc.Csharp.Modulo1
{
    class FileWork
    {
        static void Main()
        {
            LerArquivos();
        }

        #region Folder

        static void CriarPasta()
        {
            /*
            string folder = "Origem";
            string path = @"C:\Users\\tiago\Documents\ExemploAula\";
            string pathComplete = Path.Combine(path, folder);
            */

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

            Directory.Delete(sourcePath);
            Directory.Delete(targetPath);

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
                using (StreamWriter sw = File.CreateText(pathString))
                {
                    sw.WriteLine("New file created: {0}", DateTime.Now.ToString());
                    sw.WriteLine("Add one more line 1");
                    sw.WriteLine("Done!!!!!!!!!");
                }
                Console.WriteLine("Sucesso");
            }
            else
                Console.WriteLine("Arquivo ja existe");
        }

        static void LerArquivos()
        {
            string file = "FileNovo_copy.txt";
            string pasta = @"C:\Users\tiago\Documents\ExemploAula\Destino";
            string pathString = Path.Combine(pasta, file);

            using (StreamReader sr = File.OpenText(pathString))
            {
                // Ler o arquivo todo.
                //Console.WriteLine(sr.ReadToEnd());

                // Ler por linha
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
            string file = "FileNovo.txt";
            string pasta = @"C:\Users\tiago\Documents\ExemploAula\";
            string pathString = Path.Combine(pasta, file);

            if (File.Exists(pathString))
            {
                File.Delete(pathString);
            }
            else
                Console.WriteLine("Arquivo nao existe");
        }

        static void CopiarArquivo()
        {
            string sourcePath = @"C:\Users\tiago\Documents\ExemploAula\Origem\fileNovo.txt";
            string targetPath = @"C:\Users\tiago\Documents\ExemploAula\Destino\fileNovo_copy.txt";

            File.Copy(sourcePath, targetPath);

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
