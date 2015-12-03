using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackNumbers
{
    public class HackNumbers
    {
        public static string ToBinary(long number)
        {
            string digit = Convert.ToString(number % 2);
            if (number >= 2)
            {
                long remaining = number / 2;
                string remainingString = ToBinary(remaining);
                return remainingString + digit;
            }

            return digit;
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

        public static bool HasOdd1s(string digit)
        {
            char[] array = digit.ToCharArray();
            int counter = 0;
            for (int i = 0; i < digit.Length; i++)
            {
                if (digit[i] == '1')
                {
                    counter++;
                }
            }

            return (counter % 2 != 0);
        }

        public static bool IsHack(long number)
        {
            string binaryNubmer = ToBinary(number);
            return (IsPalindrome(binaryNubmer) && HasOdd1s(binaryNubmer));
        }

        public static long FindNextHack(long number)
        {
            bool hackFound = false;
            long nextHack = 0;

            while(!hackFound)
            {
                if (IsHack(number))
                {
                    hackFound = true;
                    nextHack = number;
                }

                number++;
            }

            return nextHack;
        }
        
        public static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            long input = long.Parse(Console.ReadLine());
            Console.WriteLine("{0} is hack number? {1}\nNext hack number is {2}", input, IsHack(input), FindNextHack(input));
        }
    }
}
