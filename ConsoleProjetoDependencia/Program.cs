using Comum;
using Dados;
using Negocios;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Security.Cryptography;

namespace ConsoleProjetoDependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, sobrenome, senha;
            int idade = 0;
            bool dadosOk, idadeOk;
            Settings _settings = new Settings();

            // Ler arquivo JSON
            using (StreamReader file = File.OpenText(@"settings.json"))
            {
                _settings = JsonConvert.DeserializeObject<Settings>(file.ReadToEnd());
            }

            do
            {
                // Captura informacaoes da tela
                Console.WriteLine("Entre com nome:");
                nome = Console.ReadLine();

                Console.WriteLine("Entre com sobrenome:");
                sobrenome = Console.ReadLine();
                
                // Captura e trata informacao de idade da tela
                do
                {
                    Console.WriteLine("Entre com idade:");
                    if (Int32.TryParse(Console.ReadLine(), out idade))
                        idadeOk = true;
                    else
                        idadeOk = false;
                } while(idadeOk == false);

                Console.WriteLine("Entre com senha:");
                senha = Console.ReadLine();

                // Criptografar senha
                Criptografia criptografia = new Criptografia(MD5.Create());
                senha = criptografia.CriptografarSenha(senha);

                // Cadastra informacoes
                Cadastro cadastro = new Cadastro(nome, sobrenome, idade, senha);
                ICadastro icadastro = cadastro;

                // Valida informacoes
                AnalisarCadastro analisarCadastro = new AnalisarCadastro();
                string validacao = analisarCadastro.Analisar(icadastro);

                if (string.IsNullOrEmpty(validacao))
                {
                    Console.WriteLine("Cadastro ok");
                    dadosOk = true;

                    // Salvar no arquivo
                    ArquivosEPastas.CriarPasta(_settings);
                    ArquivosEPastas.CriarEscreverArquivo(_settings, senha);
                    ArquivosEPastas.LerArquivo(_settings);
                    Console.WriteLine("Arquivo salvo.");

                    Console.WriteLine(cadastro.Imprimir());
                }
                else
                {
                    Console.WriteLine("Não ok.");
                    Console.WriteLine(validacao);
                    dadosOk = false;
                }
            } while (dadosOk == false);
        }
    }
}
