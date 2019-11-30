using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    class ContractEmployee:BaseEmployee
    {
        public int HourlyPay { get; set; }
        public int TotalHours { get; set; }

        public override int GetMonthlySalary()
        {
            return HourlyPay * TotalHours;
        }

      
    }
}
