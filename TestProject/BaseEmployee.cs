using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    public abstract class BaseEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public BaseEmployee()
        {
           
        }
        public string FullName()
        {
            return FirstName + " " + LastName;
        }
        public abstract int GetMonthlySalary();
      
    }

    //class program
    //{
    //    public static void Main(string[] args)
    //    {
    //        FullTimeEmployee fte = new FullTimeEmployee()
    //        {
    //            Id = 100,
    //            FirstName = "Anup",
    //            LastName = "Singh",
    //            AnualSalary = 1600000

    //        };
    //        Console.WriteLine(fte.GetMonthlySalary());
    //        Console.WriteLine("----------");

    //        ContractEmployee cte = new ContractEmployee()
    //        {
    //            Id = 200,
    //            FirstName = "Ankit",
    //            LastName = "singh",
    //            HourlyPay = 400,
    //            TotalHours = 40
    //        };
    //        Console.WriteLine(cte.GetMonthlySalary());
    //        Console.WriteLine("------------");

    //    }
    //}
}

