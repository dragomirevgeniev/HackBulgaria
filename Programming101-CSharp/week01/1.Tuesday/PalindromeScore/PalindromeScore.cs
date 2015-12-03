using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeScore
{
    public class PalindromeScore
    {
        public static int CalculatePScore(int input)
        {
            string number = input.ToString();

            if (IsPalindrome(number))
            {
                return 1;
            }

            else
            {
                return (1 + CalculatePScore(input + int.Parse(Reverse(input.ToString()))));
            }
        }

        public static string Reverse(string str)
        {
            char[] charArray = str.ToCharArray();
            System.Array.Reverse(charArray);
            return new string(charArray);
        }

        public static bool IsPalindrome(string digit)
        {
            return digit.Equals(Reverse(digit));
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer to calculate its \"Palindrome score\":");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}'s palindrome score is {1}", input, CalculatePScore(input));
        }
    }
}
