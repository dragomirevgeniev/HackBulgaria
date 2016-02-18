using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters_selectors_
{
    public delegate bool FilterDelegate<T>(T item);
    
    class Program
    {
        static List<T> FilterCollection<T>(List<T> original, FilterDelegate<T> filter)
        {
            List<T> filteredNums = new List<T>();
            foreach (var item in original)
            {
                if (filter(item))
                {
                    filteredNums.Add(item);
                }
            }

            return filteredNums;
        }

        static bool EvenFilter(int item)
        {
            return item % 2 == 0;
        }

        static bool OddFilter(int item)
        {
            return item % 2 != 0;
        }

        static bool LengthGreaterThanThree(string item)
        {
            return item.Length > 3;
        }
        
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<string> strings = new List<string>() { "qwe", "asd", "habba", "a" , "babba" };
            Console.WriteLine("All numbers: " + string.Join(", ", numbers));
            Console.WriteLine("Even numbers: " + string.Join(", ", FilterCollection(numbers, EvenFilter)));
            Console.WriteLine("Odd numbers: " + string.Join(", ", FilterCollection(numbers, OddFilter)));
            Console.WriteLine("Filtered strings: " + string.Join(", ", FilterCollection(strings, LengthGreaterThanThree)));
        }
    }
}
