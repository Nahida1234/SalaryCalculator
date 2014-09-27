using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorApp
{
    class SalaryCalculator
    {
        public string employeeName;
        public double basicAmount;
        public double rent;
        public double allowance;

        public double CalculateSalary()
        {
            return basicAmount + (rent*100) + (allowance*100);
        }
    }
}
