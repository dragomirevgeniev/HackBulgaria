using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumber
{
    public class FibonacciNumber
    {

        public static int GetNthFibonacci(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }

            else
            {
                return GetNthFibonacci(n - 1) + GetNthFibonacci(n - 2);
            }
        }
        
        public static long FindFibNumber(int number)
        {
            string output = string.Empty;
            
            for (int i = 0; i <= number; i++)
            {
                output += GetNthFibonacci(i);
            }

            return long.Parse(output);
        }
        
        public static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("The first {0} numbers of the Fibonacci Series are: {1}", input, FindFibNumber(input));
        }
    }
}
