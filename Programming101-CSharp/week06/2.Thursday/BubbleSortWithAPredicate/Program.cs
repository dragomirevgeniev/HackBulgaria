using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortWithAPredicate
{
    public delegate int CompareDelegate<T>(T x, T y);
    
    static class Program
    {
        static IList<T> BubbleSort<T>(this IList<T> list, CompareDelegate<T> comp)
        {
            int n = list.Count;
            for (int i = n - 1; i > 0; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (comp(list[j], list[j + 1]) > 0)
                    {
                        T highValue = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = highValue;
                    }
                }
            }

            return list;
        }

        static int ReverseIntComparer(int x, int y)
        {
            return y - x;
        }

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 4, 6, 3, 5, 2, 10, 8, 9, 7 };
            Console.WriteLine("All numbers: " + string.Join(", ", numbers));
            BubbleSort(numbers, ReverseIntComparer);
            Console.WriteLine("Sorted numbers: " + string.Join(", ", numbers));
        }
    }
}
