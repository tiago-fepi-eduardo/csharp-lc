using System;
using System.Collections.Generic;
using System.Text;

namespace Lc.Csharp.Modulo1
{
    /// <summary>
    /// Exception / Try catch
    /// </summary>
    class TryCatch
    {
        //static void Main()
        //{
            //int[] a = { 0, 1 };
            //int b = a[3];


            //int[] a = { 0, 1 };
            //try
            //{
            //    int b = a[3];
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Caught an exception -> \n {0}\n {1}\n\n", e.Message, e.StackTrace);
            //}



            //try
            //{
            //    int zero = 0;
            //    int a = 5 / zero;     //causa DivideByZeroException
            //    int[] b = { 1, 2 };
            //    a = b[3];             //causa IndexOutOfRangeException
            //}
            //catch (DivideByZeroException dz)
            //{
            //    Console.WriteLine("Got a DivideByZeroException: { 0}", dz);
            //}
            //catch (IndexOutOfRangeException ir)
            //{
            //    Console.WriteLine("Got a IndexOutOfRangeException: { 0}", ir);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Got an exception: { 0}", e);
            //}



        //    try
        //    {
        //        MakeException.makeException();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //    }

        //    try
        //    {
        //        MakeException.makeCustomException();
        //    }
        //    catch (MinhaException e)
        //    {
        //        Console.WriteLine("\n\nError Code: {0}\nException: {1}", e.ErrorCode, e);
        //        //throw (e); //RE-THROWING
        //        //throw new Exception(String.Format(“\n\nError Code:{0}\n Exception: {1}”, e.ErrorCode, e), e); //INNER EXCEPTION	
        //    }

        //    Console.ReadLine();
        //}
    }

    [Serializable]
    public class MinhaException : ApplicationException
    {
        public int ErrorCode;
        public MinhaException() { }
        public MinhaException(string message) : base(message) { }
        public MinhaException(string message, Exception inner, int errorCode) : base(message, inner)
        {
            ErrorCode = errorCode;
        }
    }

    class MakeException
    {
        public static void makeException()
        {
            throw new Exception("Erro no Make Exception!");
        }
        public static void makeCustomException()
        {
            throw new MinhaException("Erro no Make Custom Exception!", null, 19);
        }
    }

}
