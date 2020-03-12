using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace Lc.Csharp.Modulo1.Cripto
{
    public static class Criptogra
    {
        //static void Main()
        //{
        //    Console.WriteLine("### Cripto ###");

        //    //Hash hash = new Hash(SHA512.Create());
        //    Hash hash = new Hash(MD5.Create());

        //    string result = hash.CriptografarSenha("123456");

        //    bool ok = hash.VerificarSenha("1234567", result);

        //    Console.WriteLine(result);
        //    Console.WriteLine(ok);
        //}
    }

    public class Hash
    {
        private HashAlgorithm _algoritmo;

        public Hash(HashAlgorithm algoritmo)
        {
            _algoritmo = algoritmo;
        }

        public string CriptografarSenha(string senha)
        {
            var encodedValue = Encoding.UTF8.GetBytes(senha);
            var encryptedPassword = _algoritmo.ComputeHash(encodedValue);

            var sb = new StringBuilder();
            foreach (var caracter in encryptedPassword)
            {
                sb.Append(caracter.ToString("X2"));
            }

            return sb.ToString();
        }

        public bool VerificarSenha(string senhaDigitada, string senhaCadastrada)
        {
            if (string.IsNullOrEmpty(senhaCadastrada))
                throw new NullReferenceException("Cadastre uma senha.");

            var encryptedPassword = _algoritmo.ComputeHash(Encoding.UTF8.GetBytes(senhaDigitada));

            var sb = new StringBuilder();
            foreach (var caractere in encryptedPassword)
            {
                sb.Append(caractere.ToString("X2"));
            }

            return sb.ToString() == senhaCadastrada;
        }
    }
}
