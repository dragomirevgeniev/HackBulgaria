using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsonantsInAString
{
    public class ConsonantsInAString
    {
        public static int CountConsonats(string str)
        {
            int total = str.Length;
            str = str.ToLower();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != 'b' && str[i] != 'c' && str[i] != 'd' && str[i] != 'f' && str[i] != 'g' && str[i] != 'h' &&
                    str[i] != 'j' && str[i] != 'k' && str[i] != 'l' && str[i] != 'm' && str[i] != 'n' && str[i] != 'p' &&
                    str[i] != 'q' && str[i] != 'r' && str[i] != 's' && str[i] != 't' && str[i] != 'v' && str[i] != 'w' &&
                    str[i] != 'x' && str[i] != 'z')
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
            Console.WriteLine("{0} has {1} consonants.", input, CountConsonats(input));
        }
    }
}
