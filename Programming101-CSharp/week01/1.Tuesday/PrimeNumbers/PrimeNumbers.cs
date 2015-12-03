using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    public class PrimeNumbers
    {
        public static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static List<int> ListFirstPrimes(int n)
        {
            List<int> primes = new List<int>();
            primes.Add(2);
            int nextNumber = 3;
            while (primes.Count < n)
            {
                if (IsPrime(nextNumber))
                {
                    primes.Add(nextNumber);
                }

                nextNumber++;
            }

            return primes;
        }

        public static List<int> SieveOfEr(int n)
        {
            Boolean[] numbers = new Boolean[n];
            List<int> result = new List<int>();

            for (int i = 0; i < n; i++)
            {
                numbers[i] = true;
            }

            numbers[0] = false;
            numbers[1] = false;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i])
                {
                    for (int j = 0; j * i < n; j++)
                    {
                        numbers[i * j] = false;
                    }

                    result.Add(i);
                }
            }

            return result;
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to check if it is prime: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} is prime number: {1}", input, IsPrime(input));

            Console.WriteLine("The first {0} prime numbers are: ", input);
            foreach (int number in ListFirstPrimes(input))
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            Console.WriteLine("The prime numbers before {0} are: ", input);
            foreach (int number in SieveOfEr(input))
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }
}
