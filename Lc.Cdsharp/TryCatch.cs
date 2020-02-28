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
        //    //int[] a = { 0, 1 };
        //    //int b = a[3];


        //    //int[] a = { 0, 1 };
        //    //try
        //    //{
        //    //    int b = a[3];
        //    //}
        //    //catch (Exception e)
        //    //{
        //    //    Console.WriteLine("Caught an exception -> \n {0}\n {1}\n\n", e.Message, e.StackTrace);
        //    //}
        //    //finally
        //    //{
        //    //    Console.WriteLine("Finally.");
        //    //}

        //    //Console.WriteLine("seguindo meu codigo.");


        //    //try
        //    //{
        //    //    int zero = 0;
        //    //    int a = 5 / zero;     //causa DivideByZeroException
        //    //    int[] b = { 1, 2 };
        //    //    a = b[3];             //causa IndexOutOfRangeException
        //    //}
        //    //catch (DivideByZeroException dz)
        //    //{
        //    //    Console.WriteLine("Got a DivideByZeroException: { 0}", dz);
        //    //}
        //    //catch (IndexOutOfRangeException ir)
        //    //{
        //    //    Console.WriteLine("Got a IndexOutOfRangeException: { 0}", ir);
        //    //}
        //    //catch (Exception e)
        //    //{
        //    //    Console.WriteLine("Got an exception: { 0}", e);
        //    //}


        //    //try
        //    //{
        //    //    MakeException.makeException(200);
        //    //}
        //    //catch (Exception e)
        //    //{
        //    //    Console.WriteLine(e);
        //    //}

        //    Console.ReadLine();
        //}
    }

    class MakeException
    {
        public static int ErrorCode { get; set; }
        public static void makeException(int errorCode)
        {
            ErrorCode = errorCode;
            throw new Exception($"Erro no Make Exception! ErroCode: {ErrorCode}");
        }
    }
}
