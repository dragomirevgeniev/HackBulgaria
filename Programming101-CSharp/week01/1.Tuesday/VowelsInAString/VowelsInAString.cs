using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsInAString
{
    public class VowelsInAString
    {
        public static int CountVowels(string str)
        {
            int total = str.Length;
            str = str.ToLower();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != 'a' && str[i] != 'e' && str[i] != 'i' && str[i] != 'o' && str[i] != 'u' && str[i] != 'y')
                {
                    total--;
                }
            }

            return total;
        }
        
        public static void Main(string[] args)
        {
            Console.Write("Please enter a word: ");
            string input = Console.ReadLine();
            Console.WriteLine("{0} has {1} vowels.", input, CountVowels(input));
        }
    }
}
