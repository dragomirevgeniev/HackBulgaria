using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtremeElementsInAList
{
    public class ExtremeElementsInAList
    {
        public static int GetMin(int[] items)
        {
            int min = int.MaxValue;

            foreach (var num in items)
            {
                if (min > num)
                {
                    min = num;
                }
            }

            return min;
        }

        public static int GetMax(int[] items)
        {
            int max = int.MinValue;

            foreach (var num in items)
            {
                if (max < num)
                {
                    max = num;
                }
            }

            return max;
        }

        public static int GetNthMin(int n, int[] items)
        {
            int minElement = int.MaxValue;
            int[] temp = new int[items.Length];

            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = items[i];
            }

            for (int i = 0; i < n; i++)
            {
                int currMin = GetMin(temp);

                for (int j = 0; j < temp.Length; j++)
                {
                    if (temp[j] == currMin)
                    {
                        temp[j] = int.MaxValue;
                        break;
                    }
                }

                minElement = currMin;
            }

            return minElement;
        }

        public static int GetNthMax(int n, int[] items)
        {
            int maxElement = int.MinValue;
            int[] temp = new int[items.Length];

            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = items[i];
            }

            for (int i = 0; i < n; i++)
            {
                int currMax = GetMax(temp);

                for (int j = 0; j < temp.Length; j++)
                {
                    if (temp[j] == currMax)
                    {
                        temp[j] = int.MinValue;
                        break;
                    }
                }

                maxElement = currMax;
            }

            return maxElement;
        }
        
        public static void Main(string[] args)
        {
            // Tests
            int[] arr1 = new int[6] { 1, 2, 4, 5, 6, 9 };
            int[] arr2 = new int[6] { 5, 2, 2, 3, 6, 9 };
            int[] arr3 = new int[6] { 11, 14, 4, 7, 2, 7 };

            Console.WriteLine(GetMin(arr1));         // 1
            Console.WriteLine(GetMin(arr2));         // 2
            Console.WriteLine(GetMin(arr3));         // 2
                                                     
            Console.WriteLine(GetMax(arr1));         // 9
            Console.WriteLine(GetMax(arr2));         // 9
            Console.WriteLine(GetMax(arr3));         // 14
                                                     
            Console.WriteLine(GetNthMin(3, arr1));   // 4
            Console.WriteLine(GetNthMin(4, arr2));   // 5
            Console.WriteLine(GetNthMin(5, arr3));   // 11
                                                     
            Console.WriteLine(GetNthMax(2, arr1));   // 6
            Console.WriteLine(GetNthMax(3, arr2));   // 5
            Console.WriteLine(GetNthMax(4, arr3));   // 7
        }
    }
}
