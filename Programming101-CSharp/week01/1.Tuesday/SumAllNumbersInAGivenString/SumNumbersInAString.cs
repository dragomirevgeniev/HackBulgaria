using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAllNumbersInAGivenString
{
    public class SumNumbersInAString
    {
        public static int CalculateSum(string str)
        {
            bool lastIsDigit = false;
            int curNum = -1;
            int sum = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    if (lastIsDigit)
                    {
                        curNum = curNum * 10 + int.Parse(str[i].ToString());
                    }

                    else
                    {
                        lastIsDigit = true;
                        curNum = int.Parse(str[i].ToString());
                    }
                }

                else
                {
                    lastIsDigit = false;
                    if (curNum != -1)
                    {
                        sum += curNum;
                        curNum = -1;
                    }
                }
            }

            if (curNum != -1)
            {
                sum += curNum;
            }

            return sum;
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string with numbers to calculate their sum:");
            string input = Console.ReadLine();
            Console.WriteLine("The sum is {0}", CalculateSum(input));
        }
    }
}
