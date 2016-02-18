using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    class TestSorts
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = new List<int>() { 4, 23, 2, 15, 11, 64, 7, 3, 1 };
            List<int?> listOfNullableIntegers = new List<int?>() { 4, null, 2, 15, null, 64, 7, 11, 66, 5, 8 };
            List<string> listOfStrings = new List<string> {"asd", "asdf", "mnogodulugstring" , "s", "ae", string.Empty, "asdec"};
           
            listOfIntegers.BubbleSort();
            foreach (var item in listOfIntegers)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            listOfNullableIntegers.SelectionSort(new OddEvenComparer());
            foreach (var item in listOfNullableIntegers)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            listOfStrings.SelectionSort(new StringLengthComparer());
            foreach (var item in listOfStrings)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            Console.WriteLine(listOfIntegers.BSearch(1)); // 0

            List<int> listOfIntegersQS = new List<int>() { 4, 5, 1, 3, 2 };
            List<int> listOfIntegersMS = new List<int>() { 1, 7, 13, 3, 9, 5, 11 };

            listOfIntegersQS.QuickSort();
            foreach (var item in listOfIntegersQS)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            listOfIntegersMS.MergeSort();
            foreach (var item in listOfIntegersMS)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
        }
    }
}
