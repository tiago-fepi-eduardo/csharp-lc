using Lc.Csharp.Modulo1.Cripto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Lc.Csharp.Modulo2.Lista
{
    class M02Lista02
    {
        //static void Main()
        //{
        //    Settings _settings = new Settings();
        //    using (StreamReader file = File.OpenText(@"Lista\settings.json"))
        //    {
        //        _settings = JsonConvert.DeserializeObject<Settings>(file.ReadToEnd());
        //    }

        //    int opt = 0;
        //    do
        //    {
        //        opt = Menu();

        //        switch (opt)
        //        {
        //            case 1:
        //                CadastrarSenha(_settings);
        //                break;
        //            case 2:
        //                Logar(_settings);
        //                break;
        //            case 3:
        //                LimparBase(_settings);
        //                break;
        //            case 4:
        //                Sair();
        //                break;
        //        }

        //    } while (opt != 4);
        //}

        private static int Menu()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("\n1 - Configurar usuario / senha");
            stringBuilder.Append("\n2 - Logar");
            stringBuilder.Append("\n3 - Limpar base");
            stringBuilder.Append("\n4 - Sair");
            Console.WriteLine(stringBuilder);
            return Int32.Parse(Console.ReadLine());
        }

        private static void CadastrarSenha(Settings settings)
        {
            Console.WriteLine("Cadastrar nome de usuário:");
            string usuario = Console.ReadLine();
            Console.WriteLine("Cadastrar senha:");
            string senha = Console.ReadLine();

            Hash oHash = new Hash(MD5.Create());
            string senhaCriptografada = oHash.CriptografarSenha(senha);

            ArquivosEPastas.CriarPasta(settings);
            bool result = ArquivosEPastas.CriarEscreverArquivo(settings, usuario, senhaCriptografada);

            if (result)
                Console.WriteLine("Dados armazenados com sucesso.");
            else
                Console.WriteLine("Não foi possivel armazenar dados.");
            
        }

        private static void Logar(Settings settings)
        {
            Console.WriteLine("Digite nome de usuário:");
            string usuario = Console.ReadLine();
            Console.WriteLine("Digite senha:");
            string senha = Console.ReadLine();

            Hash oHash = new Hash(SHA1.Create());
            string senhaCriptografada = oHash.CriptografarSenha(senha);

            bool result = ArquivosEPastas.LerArquivo(settings, usuario, senhaCriptografada);
            
            if (result)
                Console.WriteLine("Logado com sucesso.");
            else
                Console.WriteLine("Não foi possivel logar.");

            
        }

        private static void LimparBase(Settings settings)
        {
            bool result = ArquivosEPastas.DeletarPasta(settings);

            if (result)
                Console.WriteLine("Base limpa com sucesso.");
            else
                Console.WriteLine("Não foi possivel limpar base.");
        }

        private static void Sair()
        {
            Console.WriteLine("Saindo...");
        }
    }

    public class Settings
    {
        public string Caminho { get; set; }
        public string Pasta { get; set; }
        public string Arquivo { get; set; }

        
    }

    public class ArquivosEPastas
    {
        public static bool CriarEscreverArquivo(Settings settings, string usuario, string senha)
        {
            try
            {
                if (!File.Exists(settings.Caminho + settings.Pasta + settings.Arquivo))
                {
                    using (StreamWriter sw = File.CreateText(settings.Caminho + settings.Pasta + settings.Arquivo))
                    {
                        sw.WriteLine(usuario + "#" + senha);
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

        public static bool LerArquivo(Settings settings, string usuario, string senha)
        {
            List<string> oList = new List<string>();

            try
            {
                using (StreamReader sr = File.OpenText(settings.Caminho + settings.Pasta + settings.Arquivo))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        oList.Add(s);
                    }
                }

                if (oList[0] == usuario && oList[1] == senha)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
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
