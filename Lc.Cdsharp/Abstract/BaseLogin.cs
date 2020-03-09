using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo1.Abstract
{
    public abstract class BaseLogin
    {
        public abstract void Login();

        public abstract void Login(dynamic senha);

        public abstract void Logout();

        protected bool Autentica(dynamic senha)
        {
            var strSenha = Convert.ToString(senha);

            if (strSenha == "adm")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
