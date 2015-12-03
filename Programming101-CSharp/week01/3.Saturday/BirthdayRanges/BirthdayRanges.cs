using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayRanges
{
    public class BirthdayRanges
    {
        public static List<int> GetBirthdayRanges(List<int> birthdays, List<KeyValuePair<int, int>> ranges)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < ranges.Count; i++)
            {
                int counter = 0;
                for (int j = 0; j < birthdays.Count; j++)
                {
                    if ((birthdays[j] >= ranges[i].Key) && (birthdays[j] <= ranges[i].Value))
                    {
                        counter++;
                    }
                }

                result.Add(counter);
            }
            
            return result;
        }
        
        
        public static void Main(string[] args)
        {
            List<int> birthdays1 = new List<int>() { 5, 10, 6, 7, 3, 4, 5, 11, 21, 300, 15 };
            List<int> birthdays2 = new List<int>() { 1, 2, 3, 4, 5 };
            List<KeyValuePair<int, int>> ranges1 = new List<KeyValuePair<int, int>>() { 
                new KeyValuePair<int, int>(4, 9),
                new KeyValuePair<int, int>(6, 7),
                new KeyValuePair<int, int>(200,225),
                new KeyValuePair<int, int>(300, 365)
            };

            List<KeyValuePair<int, int>> ranges2 = new List<KeyValuePair<int, int>>() { 
                new KeyValuePair<int, int>(1, 2),
                new KeyValuePair<int, int>(1, 3),
                new KeyValuePair<int, int>(1, 4),
                new KeyValuePair<int, int>(1, 5),
                new KeyValuePair<int, int>(4 ,6)
            };

            Console.Write("First results: ");
            foreach (var number in GetBirthdayRanges(birthdays1, ranges1))
            {
                Console.Write("{0} ", number);
            }

            Console.Write("\nSecond results: ");
            foreach (var number in GetBirthdayRanges(birthdays2, ranges2))
            {
                Console.Write("{0} ", number);
            }

            Console.WriteLine();
        }
    }
}
