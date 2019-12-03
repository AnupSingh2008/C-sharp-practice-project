using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace TestProject
{
    class ReflectionTest
    {
        //private static void Main()
        //{
        //    Customer1 c1 = new Customer1(10,"Anup");
        //    int HashCode = c1.GetHashCode();
        //    Console.WriteLine(HashCode);

        //    Type T = Type.GetType("TestProject.Customer1");
        //    Console.WriteLine("Full Name :" + T.FullName);
        //    Console.WriteLine("Name :" + T.Name);
        //    Console.WriteLine("Namespace " + T.Namespace);

        //    Console.WriteLine();
        //    Console.WriteLine("List of properties.");
        //    PropertyInfo[] infos = T.GetProperties();
        //    foreach(PropertyInfo info in infos)
        //    {
        //        Console.WriteLine(info.Name + "  " + info.PropertyType.Name);
        //    }

        //    Console.WriteLine();
        //    Console.WriteLine("List of methods.");
        //    MethodInfo[] methodInfos = T.GetMethods();
        //    foreach (MethodInfo info in methodInfos)
        //    {
        //        Console.WriteLine(info.Name + "  " + info.ReturnType.Name);
        //    }

        //    Console.WriteLine();
        //    Console.WriteLine("List of Constructors.");
        //    ConstructorInfo[] constructorInfos = T.GetConstructors();
        //    foreach (ConstructorInfo constructorInfo in constructorInfos)
        //    {
        //        Console.WriteLine(constructorInfo.ToString());
        //    }

        //    Console.WriteLine("Calling method.....");
        //    //Calling of methods through regflection i.e. Late Binding
        //    Assembly executingAssembly = Assembly.GetExecutingAssembly();
        //    Type customerType = executingAssembly.GetType("TestProject.Customer1");
        //    object customerInstance = Activator.CreateInstance(customerType);
        //    MethodInfo getFullNameMethod = customerType.GetMethod("GetFullName");

        //    string[] parameter = new string[2];
        //    parameter[0] = "Avyaan";
        //    parameter[1] = "Singh";

        //    string fullName = (string)getFullNameMethod.Invoke(customerInstance, parameter);
        //    Console.WriteLine(fullName);

        //}
    }

    class Customer1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Customer1()
        {

        }
        public Customer1(int Id,string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public void Print_Id()
        {
            Console.WriteLine("Id : {0}", this.Id);
        }
        public void Print_Name()
        {
            Console.WriteLine("Name : {0}", this.Name);
        }

        public string GetFullName(string firstName,string lastName)
        {
            return firstName + " " + lastName;
        }
    }
}
