using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    public class ReverseString
    {
        public static string Reverse(string str)//asd  ds
        {
            string result = "";
            for (int i = str.Length - 1; i >= 0 ; i--)
			{
			    result += str[i];
			}

            return result;
        }
        
        public static void Main(string[] args)
        {
            Console.Write("Please enter a string you want to reverse: ");
            string input = Console.ReadLine();
            Console.WriteLine("{0} reversed is {1}", input, Reverse(input));
        }
    }
}
