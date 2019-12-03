using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    class EnumExample
    {
        //public static void Main(string[] args)
        //{
        //  short[] Values=  (short[])Enum.GetValues(typeof(Gender));
        //    foreach(short s in Values)
        //    {
        //        Console.WriteLine(s);
        //    }

        //    string[] Names = (string[])Enum.GetNames(typeof(Gender));
        //    foreach (string s in Names)
        //    {
        //        Console.WriteLine(s);
        //    }
        //}
    }

    enum Gender:short
    {
        Unknown=6,
        Male=10,
        Female=20
    }
}
