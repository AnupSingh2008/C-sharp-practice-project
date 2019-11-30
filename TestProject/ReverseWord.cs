using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProject
{
    class ReverseWord
    {
        public static void Main(string[] args)
        {
            string inputString = "One Two Three Four Five";
            string reversestring= string.Join(" ", inputString.Split(' ').Select(x=> new String(x.Reverse().ToArray())));
            Console.WriteLine(reversestring);
        }

    }
}
