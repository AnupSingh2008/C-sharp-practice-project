using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TestProject
{
    class RecursionRealExample
    {
        //public static void Main(string[] args)
        //{
        //    FindFiles(@"C:\Users\anup4\OneDrive\MindTree Document Submit");
        //}

        public static void FindFiles(string path)
        {
            foreach(string fileName in Directory.GetFiles(path))
            {
                Console.WriteLine(fileName);
            }

            foreach(string directoryName in Directory.GetDirectories(path))
            {
                FindFiles(directoryName);
            }
        }
    }
}
