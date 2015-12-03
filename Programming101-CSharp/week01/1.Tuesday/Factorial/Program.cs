using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    public class Factorial
    {
        public static int FactorialLoop(int num)
        {
            int total = 1;

            for (int i = num; i > 1; i--)
            {
                total *= i;
            }

            return total;
        }

        public static int FactorialRecursion(int num)
        {
            if (num <= 0)
            {
                return 1;
            }

            return num * FactorialRecursion(num - 1);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(FactorialLoop(5));
            Console.WriteLine(FactorialRecursion(5));
        }
    }
}
