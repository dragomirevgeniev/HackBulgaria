using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyEveryCharacterKTimes
{
    public class CopyEveryCharacterKTimes
    {
        public static string CopyEveryChar(string input, int k)
        {
            string answer = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    answer += input[i];
                }
            }

            return answer;
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string to copy each character K times:");
            string input = Console.ReadLine();
            Console.Write("Please enter value for K: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Answer: {0}", CopyEveryChar(input, k));
        }
    }
}
