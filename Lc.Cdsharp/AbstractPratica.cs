//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Lc.Csharp.Modulo1
//{
//    class AbstractPratica
//    {
//        //static void Main()
//        //{
//        //    string usuario = "tiago";
//        //    var senha = "123456";
//        //    string opcao = "gmail";

//        //    switch (opcao)
//        //    {
//        //        case "gmail":
//        //            LoginFacebook objLogin = new LoginFacebook();
//        //            objLogin.FazerLogin(usuario, senha, opcao);
//        //            objLogin.FazerLogout();
//        //            break;
//        //        case "facebook":
//        //            LoginGmail objSite = new LoginGmail();
//        //            objSite.FazerLogin(usuario, senha, opcao);
//        //            objSite.FazerLogout();
//        //            break;
//        //    }
//        //}
//    }

//    public abstract class Login
//    {
//        public abstract void FazerLogin(string usuario, dynamic senha);

//        public abstract void FazerLogout();
        
//        protected virtual bool ValidarSeguranca(string usuario, dynamic senha)
//        {
//            if (senha is Int32)
//            {
//                if (senha == 123456)
//                    return true;
//                else
//                    return false;
//            }
//            else if (senha is string)
//            {
//                if (senha == "123456")
//                    return true;
//                else
//                    return false;
//            }
//            else
//                return false;
//        }
//    }

//    public class LoginFacebook : Login
//    {
//        public override void FazerLogin(string usuario, dynamic senha)
//        {
//            bool resultValidacao = ValidarSeguranca(usuario, senha);
//            if(resultValidacao)
//                Console.WriteLine("Login app realizado.");
//            else
//                Console.WriteLine("Login app falhou.");
//        }

//        public override void FazerLogout()
//        {
//            Console.WriteLine("Logout app realizado.");
//        }
//    }

//    public class LoginGmail : Login
//    {
//        public override void FazerLogin(string usuario, dynamic senha)
//        {
//            bool resultValidacao = ValidarSeguranca(usuario, senha, opcao);
//            if (resultValidacao)
//                Console.WriteLine("Login site realizado.");
//            else
//                Console.WriteLine("Login site falhou.");
//        }

//        public override void FazerLogout()
//        {
//            Console.WriteLine("Logout site realizado.");
//        }

//        protected override bool ValidarSeguranca(string usuario, dynamic senha, opcao)
//        {
//            if (senha is Int32)
//            {
//                if (senha == 123456)
//                    return true;
//                else
//                    return false;
//            }
//            else if (senha is string)
//            {
//                if (senha == "123456")
//                    return true;
//                else
//                    return false;
//            }
//            else
//                return false;
//        }
//    }
//}
