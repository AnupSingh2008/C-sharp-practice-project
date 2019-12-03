using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TestProject
{
    class InnerException
    {
        //public static void Main(string[] args)
        //{
        //    try
        //    {
        //        try
        //        {


        //            Console.WriteLine("Enter First Number :");
        //            int FN = Convert.ToInt32(Console.ReadLine());


        //            Console.WriteLine("Enter Second Number :");
        //            int SN = Convert.ToInt32(Console.ReadLine());

        //            int result = FN / SN;

        //            Console.WriteLine("Result = {0}", result);
        //        }
        //        catch (Exception ex)
        //        {
        //            string FilePath = @"C:\Users\anup4\OneDrive\Documents\Sample\data.txt";
        //            StreamWriter sw = new StreamWriter(FilePath);
        //            if (File.Exists(FilePath))
        //            {
        //                sw.Write(ex.GetType().Name);
        //                sw.WriteLine();
        //                sw.Write("Some problem occured");
        //                sw.Close();
        //            }
        //            else
        //            {
        //                throw new FileNotFoundException("File NOt Found exception", ex);
        //            }
        //        }
        //    }
        //    catch(Exception exception)
        //    {
        //        Console.WriteLine("Current Exception : {0}", exception.GetType().Name);
        //        if(exception.InnerException != null)
        //        Console.WriteLine("Current Exception : {0}", exception.InnerException.GetType().Name);
        //    }
        //}
    }
}
