using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassEmployee
{
    public partial class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public string Postion { get; set; }
        public decimal Bonus { get; set; }
        
        public Employee(string firstName, string lastName, decimal salary, string postion, decimal bonus)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Postion = postion;
            Bonus = bonus;
        }

        partial void Print();
    }
}
