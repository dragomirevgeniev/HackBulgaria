using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerPalindromes
{
    class IntegerPalindromes
    {
        public static bool IsPalindrome(long input)
        {
            string number = input.ToString();

            for (int s = 0, e = number.Length - 1; s < number.Length; s++, e--)
            {
                if (number[s] != number[e])
                {
                    return false;
                }
            }

            return true;
        }

        public static long GetLargestPalindrome(long number)
        {
            for (long i = number; i > 0; i--)
            {
                if (IsPalindrome(i))
                {
                    return i;
                }
            }

            return number;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to check if it is a palindrome");
            long input = long.Parse(Console.ReadLine());
            Console.WriteLine("{0} is a palindrome : {1}", input, IsPalindrome(input));

            if (!IsPalindrome(input))
            {
                Console.WriteLine("The largest palindrome number smaller than {0} is : {1}", input, GetLargestPalindrome(input));
            }
        }
    }
}
