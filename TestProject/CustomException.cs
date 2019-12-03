using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace TestProject
{
    class CustomException
    {
        //public static void Main(string[] argas)
        //{
        //    try
        //    {
        //        throw new LoggedInUSerException("User is already looged in.");
        //    }
        //    catch(LoggedInUSerException exception)
        //    {
        //        Console.WriteLine(exception.Message);
        //    }
        //}

    }

    class LoggedInUSerException : Exception
    {
        public LoggedInUSerException()
        {

        }
        public LoggedInUSerException(string exception):base(exception)
        {

        }
        public LoggedInUSerException(string exception,Exception ex):base(exception,ex)
        {

        }
        public LoggedInUSerException(SerializationInfo info, StreamingContext context):base(info,context)
        {

        }
    }
}
