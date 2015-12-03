using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingAndDecreasingSequences
{
    public class IncreasingAndDecreasingSequences
    {
        public static bool IsIncreasing(int[] sequence)
        {
            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i - 1] >= sequence[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsDecreasing(int[] sequence)
        {
            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i - 1] <= sequence[i])
                {
                    return false;
                }
            }

            return true;
        }
        
        public static void Main(string[] args)
        {
            int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[5] { 1, 2, 3, 3, 4 };
            int[] arr3 = new int[5] { 5, 4, 3, 2, 1 };
            int[] arr4 = new int[5] { 5, 4, 4, 2, 1 };

            Console.WriteLine("Array    Increasing    Decreasing");
            Console.WriteLine("arr1     {0}          {1}", IsIncreasing(arr1), IsDecreasing(arr1));
            Console.WriteLine("arr2     {0}         {1}", IsIncreasing(arr2), IsDecreasing(arr2));
            Console.WriteLine("arr3     {0}         {1}", IsIncreasing(arr3), IsDecreasing(arr3));
            Console.WriteLine("arr4     {0}         {1}", IsIncreasing(arr4), IsDecreasing(arr4));
        }
    }
}
