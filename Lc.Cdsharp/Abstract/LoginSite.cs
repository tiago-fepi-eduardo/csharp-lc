using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo1.Abstract
{
    class LoginSite : BaseLogin
    {
        public override void Login()
        {
            Console.WriteLine("Login site realizado com sucesso.");
        }

        public override void Login(dynamic senha)
        {
            bool result = Autentica(senha);
            if (result)
                Console.WriteLine("Login site realizado com sucesso.");
            else
                Console.WriteLine("Login falhou.");
        }

        public override void Logout()
        {
            Console.WriteLine("Logout site realizado com sucesso.");
        }
    }
}
