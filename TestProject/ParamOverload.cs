using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    class ParamOverload
    {

        private static void Main()
        {
            Add(10, 30, 40, 50, 60);
            Add(10, 20);
            Add(10, 20, new object[] { 10, 30, 80, 90 });
        }
        public static void Add(int FN,int SN,params object[] restOfNumber)
        {
            int result = 0;
            result = FN + SN;
            if(restOfNumber != null)
            {
                foreach(int i in restOfNumber)
                {
                    result = result + i;
                }
            }

            Console.WriteLine(result);
           
        }
    }
}
