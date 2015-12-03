using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSpan
{
    public class MaxSpan
    {
        public static int GetMaxSpan(List<int> numbers)
        {
            if (numbers.Count < 2)
            { 
                return numbers.Count;
            }
            
            int left = 0;
            int right = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[0] == numbers[numbers.Count - 1 - i]) 
                {
                    left = numbers.Count - i;
                    break;
                } 
                
                else if (numbers[numbers.Count - 1] == numbers[i])
                {
                    right = numbers.Count - i;
                    break;
                }
            }

            return Math.Max(left, right);
        }

        public static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 1, 2, 1, 1, 3 };
            List<int> list2 = new List<int>() { 1, 4, 2, 1, 4, 1, 4 };
            List<int> list3 = new List<int>() { 1, 4, 2, 1, 4, 4, 4 };
            Console.WriteLine("Max span in list1: {0}\nMax span in list2: {1}\nMax span in list3: {2}",
                GetMaxSpan(list1), GetMaxSpan(list2), GetMaxSpan(list3));
        }   
    }
}
