using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassEmployee
{
    public partial class Employee
    {
        private const decimal TAX = 0.2m;

        partial void Print()
        {
            Console.WriteLine(string.Format("{0} {1}", FirstName, LastName));
        }

        public void PrintEmployee()
        {
            Print();
        }

        public decimal CalculateAllIncome()
        {
            return Bonus + Salary;
        }

        public decimal CalculateBalance()
        {
            return CalculateTaxes(CalculateAllIncome());
        }

        private decimal CalculateTaxes(decimal income)
        {
            return income - income * TAX;
        }
    }
}
