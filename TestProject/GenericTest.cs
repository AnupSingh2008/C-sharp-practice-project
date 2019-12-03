using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    class GenericTest
    {
        //private static void Main()
        //{
        //   bool isEqual = Calculator.AreEqula<string>("Anup", "Anup");
        //    Console.WriteLine(isEqual);
        //    isEqual = Calculator.AreEqula<int>(10,10);
        //    Console.WriteLine(isEqual);

        //    int val = Calculator.Add<int,int>(10, 20);
        //    Console.WriteLine(val);

        //    string strValue = Calculator.Add<string,int>("Anup", 10);
        //    Console.WriteLine(strValue);

        //    strValue = Calculator.Add<string, string>("Anup", "Singh");
        //    Console.WriteLine(strValue);
        //}
    }
    public class Calculator
    {
        public static bool AreEqula<t>(t value1,t value2)
        {
            return value1.Equals(value2);
        }

        public static t1 Add<t1,t2>(t1 value1, t2 value2)
        {
            dynamic a = value2;
            dynamic b = value1;
            return a + b;
        }
    }
}
