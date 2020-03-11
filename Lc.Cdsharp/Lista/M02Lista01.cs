using Lc.Csharp.Modulo1.Cripto;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Lc.Csharp.Modulo1.Lista
{
    class M02Lista01
    {
        //static void Main()
        //{
        //    Console.WriteLine("## Login Modulo ##");

        //    LoginGmail loginGmail = new LoginGmail();
        //    var resultLogin1 = loginGmail.Login("tiago", "1", TipoEmail.Gmail);
        //    var resultLogout1 = loginGmail.Logout();

        //    LoginInstagram loginInstagram = new LoginInstagram();
        //    var resultLogin2 = loginInstagram.Login("tiago", "2", TipoEmail.Facebook);
        //    var resultLogout2 = loginInstagram.Logout();

        //    LoginFacebook loginFacebook = new LoginFacebook();
        //    var resultLogin3 = loginFacebook.Login("tiago", "1", TipoEmail.Facebook);
        //    var resultLogout3 = loginFacebook.Logout();

        //    Console.WriteLine("Login 1: " + resultLogin1);
        //    Console.WriteLine("Logout 1: " + resultLogout1);

        //    Console.WriteLine("Login 2: " + resultLogin2);
        //    Console.WriteLine("Logout 2: " + resultLogout2);

        //    Console.WriteLine("Login 3: " + resultLogin1);
        //    Console.WriteLine("Logout 3: " + resultLogout3);
        //}
    }

    public enum TipoEmail
    {
        Facebook,
        Gmail,
        Instagram
    }

    abstract class SuperLogin
    {
        public abstract bool Login(string user, string senha, TipoEmail tipo);

        public abstract bool Logout();

        protected bool Autentica(string user, string senha, TipoEmail tipo)
        {
            //Hash hash = new Hash(SHA512.Create());
            //string result = hash.CriptografarSenha(senha);
            //bool ok = hash.VerificarSenha(senha, result);

            switch (tipo)
            {
                case TipoEmail.Facebook:
                    if(user == "tiago" && senha == "1")
                        return true;
                    else
                        return false;
                    break;
                case TipoEmail.Gmail:
                    if (user == "tiago" && senha == "2")
                        return true;
                    else
                        return false;
                    break;
                case TipoEmail.Instagram:
                    if (user == "tiago" && senha == "3")
                        return true;
                    else
                        return false;
                    break;
                default:
                    return false;
                    break;
            }
        }
    }

    class LoginGmail : SuperLogin
    {
        public override bool Login(string user, string senha, TipoEmail tipo)
        {
            return Autentica(user, senha, tipo);
        }

        public override bool Logout()
        {
            return true;
        }
    }

    class LoginFacebook : SuperLogin
    {
        public override bool Login(string user, string senha, TipoEmail tipo)
        {
            return Autentica(user, senha, tipo);
        }

        public override bool Logout()
        {
            return true;
        }
    }

    class LoginInstagram : SuperLogin
    {
        public override bool Login(string user, string senha, TipoEmail tipo)
        {
            return Autentica(user, senha, tipo);
        }

        public override bool Logout()
        {
            return true;
        }
    }
}
