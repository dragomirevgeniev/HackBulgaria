using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharHistogram
{
    public class CharHistogram
    {
        public static Dictionary<char, int> MakeCharHistogram(string str)
        {
            Dictionary<char, int> histogram = new Dictionary<char, int>();

            foreach (var letter in str)
            {
                if (histogram.ContainsKey(letter))
                {
                    histogram[letter] += 1;
                }

                else
                {
                    histogram.Add(letter, 1);
                }
            }

            foreach (var letter in histogram)
            {
                Console.Write("{0} : {1}, ", letter.Key, letter.Value);
            }

            return histogram;    
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string to count the occurences of the symbols in it:");
            string input = Console.ReadLine();
            MakeCharHistogram(input);
        }
    }
}
