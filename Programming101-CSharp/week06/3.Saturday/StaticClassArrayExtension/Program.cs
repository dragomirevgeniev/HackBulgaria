using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassArrayExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers1 = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> numbers2 = new List<int>() { 3, 4, 5, 6, 7 };

            List<int> intersected = new List<int>();
            intersected = numbers1.Intersect(numbers2);

            List<int> allUnioned = new List<int>();
            allUnioned = ArrayExtension.UnionAll(numbers1, numbers2);

            List<int> unionedWithoutDuplicates = new List<int>();
            unionedWithoutDuplicates = ArrayExtension.Union(numbers1, numbers2);

            char specialChar = ArrayExtension.GetReplacingValue;
            List<string> strings = new List<string>() { "I", "love", "fried", "potatoes" };
            string joined = ArrayExtension.Join(strings);

            foreach (var item in intersected)
            {
                Console.Write("{0} ", item);  // 3 4 5
            }

            Console.WriteLine();

            foreach (var item in allUnioned)
            {
                 Console.Write("{0} ", item);  // 1 2 3 4 5 3 4 5 6 7
            }

            Console.WriteLine();

            foreach (var item in unionedWithoutDuplicates)
            {
                Console.Write("{0} ", item);  // 1 2 3 4 5 6 7
            }

            Console.WriteLine();
            Console.WriteLine("Special replacing value: {0}\nJoined string: {1}", specialChar, joined);
            Console.WriteLine();
        }
    }
}
