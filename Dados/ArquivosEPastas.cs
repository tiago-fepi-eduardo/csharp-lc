using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Dados
{
    public class ArquivosEPastas
    {
        public static bool CriarEscreverArquivo(Settings settings, string senha)
        {
            try
            {
                if (!File.Exists(settings.Caminho + settings.Pasta + settings.Arquivo))
                {
                    using (StreamWriter sw = File.CreateText(settings.Caminho + settings.Pasta + settings.Arquivo))
                    {
                        sw.WriteLine(senha);
                    }
                }
                else
                    return false;

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static string LerArquivo(Settings settings)
        {
            using (StreamReader sr = File.OpenText(settings.Caminho + settings.Pasta + settings.Arquivo))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    return s;
                }
                return string.Empty;
            }
        }

        public static bool CriarPasta(Settings settings)
        {
            try
            {
                Directory.CreateDirectory(settings.Caminho + settings.Pasta);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool DeletarPasta(Settings settings)
        {
            try
            {
                Directory.Delete(settings.Caminho + settings.Pasta, true);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
