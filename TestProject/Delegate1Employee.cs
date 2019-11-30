using System;
using System.Collections.Generic;

namespace TestProject
{
    class Delegate1Employee
    {
        public static List<Employee> lstEmployee = new List<Employee>()
        {
           new Employee{Id=101,Name="Anup",Experience=5,Salary=5000},
           new Employee{Id=102,Name="Avyaan",Experience=1,Salary=2000},
           new Employee{Id=103,Name="Kriti",Experience=4,Salary=4000},
           new Employee{Id=104,Name="Ankit",Experience=6,Salary=6000}

           
        };
       
        //static void Main(string[] args)
        //{
        //    //isPromotable isPromotable = new isPromotable(promote);
        //    Employee.IsEmployeePromatable(lstEmployee,emp=>emp.Experience >5);
        //   Console.WriteLine("Hello World!");
        //}

        public static bool promote(Employee emp)
        {
            if(emp.Experience >=5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    delegate bool isPromotable(Employee emp);
    class Employee
    {
        public int Id { get; set; }
        public string Name  { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }

        public static void IsEmployeePromatable(List<Employee> employees,isPromotable isPromotable)
        {
            foreach(Employee emp in employees)
            {
                if(isPromotable(emp))
                {
                    Console.WriteLine(emp.Name + "Promoted!");
                }
            }
        }
    }

}
