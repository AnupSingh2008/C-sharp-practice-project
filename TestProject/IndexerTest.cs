using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TestProject
{
    class IndexerTest
    {
        //private static void Main(string[] args)
        //{
        //    Company cmp = new Company();
        //    Console.WriteLine("Employee Name of Id 1 : " + cmp[1]);
        //    Console.WriteLine("Employee Name of Id 2 : " + cmp[2]);
        //    Console.WriteLine("Employee Name of Id 8 : " + cmp[8]);

        //    Console.WriteLine();
        //    cmp[1] = "Anup Kumar Singh";
        //    cmp[2] = "Neha Singh";
        //    cmp[8] = "Ashi Singh";

        //    Console.WriteLine("Employee Name of Id 1 : " + cmp[1]);
        //    Console.WriteLine("Employee Name of Id 2 : " + cmp[2]);
        //    Console.WriteLine("Employee Name of Id 8 : " + cmp[8]);
        //}
    }
    class Employee1
    {
        private string _gender;
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }
        }
    }

    public class Company
    {
        List<Employee1> lstEmployee = new List<Employee1>();
        public Company()
        {
            lstEmployee.Add(new Employee1() { EmployeeId = 1, Name = "Anup", gender = "Male" });
            lstEmployee.Add(new Employee1() { EmployeeId = 2, Name = "Neha", gender = "Female" });
            lstEmployee.Add(new Employee1() { EmployeeId = 3, Name = "Anika", gender = "Female" });
            lstEmployee.Add(new Employee1() { EmployeeId = 4, Name = "Avyaan", gender = "Male" });
            lstEmployee.Add(new Employee1() { EmployeeId = 5, Name = "Sonu", gender = "Male" });
            lstEmployee.Add(new Employee1() { EmployeeId = 6, Name = "Ankit", gender = "Male" });
            lstEmployee.Add(new Employee1() { EmployeeId = 7, Name = "Kriti", gender = "Female" });
            lstEmployee.Add(new Employee1() { EmployeeId = 8, Name = "Ashi", gender = "Female" });
        }

        public string this[int EmployeeId]
        {
            get
            {
                return lstEmployee.FirstOrDefault(x => x.EmployeeId == EmployeeId).Name;
            }
            set
            {
                lstEmployee.FirstOrDefault(x => x.EmployeeId == EmployeeId).Name = value;
            }
        }

    }
}
