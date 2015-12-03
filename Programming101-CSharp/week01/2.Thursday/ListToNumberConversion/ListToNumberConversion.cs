using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListToNumberConversion
{
    public class ListToNumberConversion
    {
        public static List<int> ConvertNumberToList(int n)
        {
            string number = n.ToString();
            List<int> listOfDigits = new List<int>(number.Length);

            for (int i = 0; i < number.Length; i++)
            {
                listOfDigits.Add(number[i]-'0');
            }

            return listOfDigits;
        }

        public static int ConvertListToNumber(List<int> listOfDigits)
        {
            string number = string.Empty;

            foreach (var digit in listOfDigits)
            {
                number += digit;
            }

            return int.Parse(number);
        }
        
        public static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int input = int.Parse(Console.ReadLine());
            Console.Write("List: ");
            foreach (var digit in ConvertNumberToList(input))
            {
                Console.Write("{0} ", digit);
            }

            Console.WriteLine("\nNumber: {0}", ConvertListToNumber(ConvertNumberToList(input)));
        }
    }
}
