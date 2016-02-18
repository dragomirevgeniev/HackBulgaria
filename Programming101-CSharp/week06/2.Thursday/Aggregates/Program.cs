using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregates
{
    public delegate T AggregationDelegate<T>(T sum, T number);
    
    class Program
    {
        static T AggregateCollection<T>(List<T> original, AggregationDelegate<T> aggregate)
        {
            T sum = original[0];
            for (int i = 1; i < original.Count; i++)
            {
                sum = aggregate(sum, original[i]);
            }

            return sum;
        }

        static decimal Sum(decimal currentSum, decimal newNumber)
        {
            return currentSum + newNumber;
        }

        static decimal Product(decimal currentProduct, decimal newNumber)
        {
            return currentProduct * newNumber;
        }

        static string Concat(string currentString, string newString)
        {
            return currentString + newString;
        }
        
        static void Main()
        {
            List<decimal> numbers = new List<decimal> { 1, 2, 3, 4, 5 };
            List<string> strings = new List<string> { "a", "a", "a", "a", "a" };
            Console.WriteLine("Sum: {0}", AggregateCollection(numbers, Sum));
            Console.WriteLine("Product {0}", AggregateCollection(numbers, Product));
            Console.WriteLine("Sum: {0}", AggregateCollection(strings, Concat));
        }
    }
}
