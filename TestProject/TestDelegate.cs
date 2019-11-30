using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    class ProgramTestDelegate   
    {
        static List<Customer> customers = new List<Customer>()
        {
            new Customer{Id=1,TotalShopping=10000 },
             new Customer{Id=2,TotalShopping=14000}
        };
        //static void Main(string[] args)
        //{
        //    Customer.CheckPromotion(customers, c => c.TotalShopping > 12000);
        //}
    }

    public delegate bool IsGoldCustomer(Customer customer);
    public class Customer
    {
        public int Id { get; set; }
        public int TotalShopping { get; set; }

        public static void CheckPromotion(List<Customer> customers,IsGoldCustomer isGold)
        {
            foreach(Customer customer in customers)
            {
                if(isGold(customer))
                {
                    Console.WriteLine(customer.Id + " is a gold customer.");
                }
            }
        }

    }
}
