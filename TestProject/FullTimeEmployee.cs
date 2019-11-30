using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    class FullTimeEmployee:BaseEmployee
    {
        public int AnualSalary { get; set; }
        public override int GetMonthlySalary()
        {
            return AnualSalary / 12;
        }
    }
}
