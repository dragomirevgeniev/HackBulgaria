using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            AverageAggregator aggregator = new AverageAggregator
               (delegate(object sender, decimal oldAverage, decimal newAverage)
               {
                   Console.Write("-Event fired: ");
                   Console.WriteLine("Average changed from {0} to {1}.", oldAverage, newAverage);
               });

            Console.WriteLine("Add numbers to the aggregator. Add 0 to stop.");
            int input = -1;
            while(input != 0)
            {
                input = int.Parse(Console.ReadLine());
                Console.WriteLine("{0} has been added to the aggregator", input);
                aggregator.AddNumber(input);
            }
        }
    }
}
