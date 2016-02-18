using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee sasho = new Employee("Alexander", "Donkov", 2000m, "Software architect", 100m);
            Employee dido = new Employee("Dilyan", "Georgiev", 2500m, "Team Leader", 200m);
            sasho.PrintEmployee();
            Console.WriteLine("All income: {0}, Balance: {1}", sasho.CalculateAllIncome(), sasho.CalculateBalance());
            dido.PrintEmployee();
            Console.WriteLine("All income: {0}, Balance: {1}", dido.CalculateAllIncome(), dido.CalculateBalance());
        }
    }
}
