using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasSeries
{
    public class LucasSeries
    {
        public static long FindNthLucas(int num)
        {
            if (num == 0)
            {
                return 2;
            }

            if (num == 1)
            {
                return 1;
            }

            return FindNthLucas(num - 1) + FindNthLucas(num - 2);
        }

        public static string FindFirstNLucas(int num)
        {
            string output = string.Empty;

            for (int i = 0; i <= num; i++)
            {
                output += FindNthLucas(i) + ", ";
            }

            return output.Substring(0, output.Length - 2);
        }
        
        public static void Main(string[] args)
        {
            Console.Write("Please enter a number N to get the Nth Lucas series number and the first N numbers from this series: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(FindNthLucas(input));
            Console.WriteLine(FindFirstNLucas(input));
        }
    }
}
