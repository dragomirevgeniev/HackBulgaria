using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction() { }
        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be 0");
            }

            this.numerator = numerator;
            this.denominator = denominator;
        }

        public int Numerator
        {
            get{ return numerator; }

            set{ numerator = value; }
        }

        public int Denominator
        {
            get { return denominator; }

            set
            {
                if (value == 0)
                {
                    Console.WriteLine("ERROR: Denominator cannot be 0");
                }

                else
                {
                    denominator = value;
                }
            }
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", Numerator, Denominator);
        }

        public override bool Equals(object obj)
        {
            if (obj is Fraction)
            {
                Fraction frac = obj as Fraction;
                if (numerator != frac.Numerator || denominator != frac.Denominator)
                {
                    return false;
                }

                return true;
            }

            else return false;
        }

        public static bool operator==(Fraction frac1, Fraction frac2)
        {
            return frac1.Equals(frac2);
        }

        public static bool operator!=(Fraction frac1, Fraction frac2)
        {
            return !frac1.Equals(frac2);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + numerator.GetHashCode();
                hash = hash * 23 + denominator.GetHashCode();
                return hash;
            }
        }

        public Fraction Simplify()
        {
	        int counter = 2;
	        while (counter <= numerator && counter <= denominator)
	        {
		        if (numerator % counter == 0 && denominator % counter == 0)
		        {
			        numerator /= counter;
			        denominator /= counter;
		        }

		        else
		        {
			        counter++;
		        }
	        }

	        if (denominator < 0)
	        {
		        denominator *= -1;
		        numerator *= -1;
	        }

            return new Fraction(numerator, denominator);
        }

        public static explicit operator double(Fraction frac)
        {
            return (double)frac.numerator / (double)frac.denominator;
        }

        public static Fraction operator+(Fraction frac1, Fraction frac2)
        {
            int numerator;
            int denominator;

            if (frac1.denominator == frac2.denominator)
            {
                numerator = frac1.numerator + frac2.numerator;
                denominator = frac1.denominator;
            }

            else
            {
                numerator = frac1.numerator * frac2.denominator + frac2.numerator * frac1.denominator;
                denominator = frac1.denominator * frac2.denominator;
            }

            return new Fraction(numerator, denominator).Simplify();
        }

        public static Fraction operator-(Fraction frac1, Fraction frac2)
        {
            int numerator;
            int denominator;

            if (frac1.denominator == frac2.denominator)
            {
                numerator = frac1.numerator - frac2.numerator;
                denominator = frac1.denominator;
            }

            else
            {
                numerator = frac1.numerator * frac2.denominator - frac2.numerator * frac1.denominator;
                denominator = frac1.denominator * frac2.denominator;
            }

            return new Fraction(numerator, denominator).Simplify();
        }

        public static Fraction operator*(Fraction frac1, Fraction frac2)
        {
            int numerator = frac1.numerator * frac2.numerator;
            int denominator = frac1.denominator * frac2.denominator;

            return new Fraction(numerator, denominator).Simplify();
        }

        public static Fraction operator/(Fraction frac1, Fraction frac2)
        {
            int numerator = frac1.numerator * frac2.denominator;
            int denominator = frac1.denominator * frac2.numerator;

            return new Fraction(numerator, denominator).Simplify();
        }

        public static double operator+(Fraction frac, double number)
        {
            return (double)frac + number;
        }

        public static double operator+(double number, Fraction frac)
        {
            return number + (double)frac;
        }

        public static double operator-(Fraction frac, double number)
        {
            return (double)frac - number;
        }

        public static double operator-(double number, Fraction frac)
        {
            return number - (double)frac;
        }

        public static double operator*(Fraction frac, double number)
        {
            return (double)frac * number;
        }

        public static double operator*(double number, Fraction frac)
        {
            return number * (double)frac;
        }

        public static double operator/(Fraction frac, double number)
        {
            return (double)frac / number;
        }

        public static double operator/(double number, Fraction frac)
        {
            return number / (double)frac;
        }
    }
}
