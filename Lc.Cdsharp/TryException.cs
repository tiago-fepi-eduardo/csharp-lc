using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo1
{
    class TryException
    {
        static void Main()
        {
            try
            {

            }
            catch(Exception e)
            {
                throw new Exception("Index do arrau invalido!");
            }
        }
    }

}
