using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithDigits
{
    public class WorkingWIthDigits
    {
        public static int CountDigits(int number)
        {
            int counter = 0;

            while (number > 0)
            {
                number /= 10;
                counter++;
            }

            return counter;
        }
        
        public static int SumDigits(int number)
        {
            int sum = 0;
            int numberOfDigits = CountDigits(number);

            for (int i = 0; i < numberOfDigits; i++)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }

        public static int FindFactorialDigits(int number)
        {
            int sum = 0;
            int numberOfDigits = CountDigits(number);

            for (int i = 0; i < numberOfDigits; i++)
            {
                sum += Factorial(number % 10);
                number /= 10;
            }

            return sum;
        }

        public static int Factorial(int num)
        {
            if (num <= 0)
            {
                return 1;
            }

            return num * Factorial(num - 1);
        }

        public static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("The number has {0} digit(s)\nThe sum of the digits is {1}\nThe sum of the factorials of the digits is {2}",
                                            CountDigits(input), SumDigits(input), FindFactorialDigits(input));
        }
    }
}
