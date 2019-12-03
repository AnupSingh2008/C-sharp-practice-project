using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    public delegate void SampleDelegate();
    class MultiCastDelegate
    {
        //Observer design pattern and publish/subscribe pattern
        //public static void Main(string[] args)
        //{
        //    //SampleDelegate del, del1, del2, del3;
        //    //del1 = new SampleDelegate(SampleMethodOne);
        //    //del2 = new SampleDelegate(SampleMethodTwo);
        //    //del3 = new SampleDelegate(SampleMethodThree);
        //    //del = del1 + del2 + del3;
        //    //del();

        //    SampleDelegate sampleDelegate = new SampleDelegate(SampleMethodOne);
        //    sampleDelegate += SampleMethodTwo;
        //    sampleDelegate += SampleMethodThree;
        //    sampleDelegate -= SampleMethodOne;
        //    sampleDelegate();

        //}

        public static void SampleMethodOne()
        {
            Console.WriteLine("Sample method one");
        }

        public static void SampleMethodTwo()
        {
            Console.WriteLine("Sample method two");
        }

        public static void SampleMethodThree()
        {
            Console.WriteLine("Sample method three");
        }
    }
}
