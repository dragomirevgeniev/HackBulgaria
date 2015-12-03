using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    class TestFractions : Fraction
    {
        static void Main(string[] args)
        {
            Fraction fr = new Fraction(1, 3);
            Fraction fr2 = new Fraction(1, 3);
            Console.WriteLine("{0} equals {1} : {2}", fr, fr2, fr.Equals(fr2));

            Fraction frac1 = new Fraction(1, 2);
            Fraction frac2 = new Fraction(1, 4);
            double number = 0.5;

            Console.WriteLine("{0} + {1} = {2}", frac1, frac2, frac1 + frac2);
            Console.WriteLine("{0} - {1} = {2}", frac1, frac2, frac1 - frac2);
            Console.WriteLine("{0} * {1} = {2}", frac1, frac2, frac1 * frac2);
            Console.WriteLine("{0} / {1} = {2}", frac1, frac2, frac1 / frac2);
            Console.WriteLine();
            Console.WriteLine("{0} + {1} = {2}", number, frac2, number + frac2);
            Console.WriteLine("{0} - {1} = {2}", number, frac2, number - frac2);
            Console.WriteLine("{0} * {1} = {2}", number, frac2, number * frac2);
            Console.WriteLine("{0} / {1} = {2}", number, frac2, number / frac2);
            Console.WriteLine();
            Console.WriteLine("{0} + {1} = {2}", frac1, number, frac1 + number);
            Console.WriteLine("{0} - {1} = {2}", frac1, number, frac1 - number);
            Console.WriteLine("{0} * {1} = {2}", frac1, number, frac1 * number);
            Console.WriteLine("{0} / {1} = {2}", frac1, number, frac1 / number);
        }
    }
}
