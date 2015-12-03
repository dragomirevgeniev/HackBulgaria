using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseEachWordInASentence
{
    public class ReverseEachWordInASentence
    {
        private static string ReverseEveryWord(string input)
        {
            string reversed = string.Empty;
            string[] words = input.Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);
            // string[] words = input.Split(' ');
            
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = words[i].Length - 1; j >= 0; j--)
                {
                    reversed += words[i][j];
                }

                reversed += " ";
            }

            return reversed;
        }    
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string sentence:");
            string input = Console.ReadLine();
            Console.WriteLine("Your sentence with reversed words\n{0}", ReverseEveryWord(input));
        }
    }
}
