using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    public static class SortAndSearchExtensions
    {
        public static IList<T> BubbleSort<T>(this IList<T> list, IComparer<T> comp)
        {
            int n = list.Count;
            for (int i = n - 1; i > 0; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (comp.Compare(list[j], list[j + 1]) > 0)
                    {
                        T highValue = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = highValue;
                    }
                }
            }

            return list;
        }

        public static IList<T> BubbleSort<T>(this IList<T> list)
        {
            return list.BubbleSort(Comparer<T>.Default);
        }

        public static IList<T> SelectionSort<T>(this IList<T> list, IComparer<T> comp)
        {
            int n = list.Count;
            int maxIndex;
            T temp;
            for (int i = n - 1; i > 0; i--)
            {
                maxIndex = 0;
                for (int j = 0; j <= i; j++)
                {
                    if (comp.Compare(list[j], list[maxIndex]) > 0)
                    {
                        maxIndex = j;
                    }
                }

                temp = list[maxIndex];
                list[maxIndex] = list[i];
                list[i] = temp;
            }

            return list;
        }

        public static IList<T> SelectionSort<T>(this IList<T> list)
        {
            return list.SelectionSort(Comparer<T>.Default);
        }

        public static int BSearch<T>(this IList<T> list, T value, IComparer<T> comp)
        {
            if (list == null)
                throw new ArgumentNullException("list");

            int lower = 0;
            int upper = list.Count - 1;

            while (lower <= upper)
            {
                int middle = lower + (upper - lower) / 2;

                int comparisonResult = comp.Compare(value, list[middle]);
                if (comparisonResult == 0)
                    return middle;
                else if (comparisonResult < 0)
                    upper = middle - 1;
                else
                    lower = middle + 1;
            }

            return -1;
        }

        public static int BSearch<T>(this IList<T> list, T value)
        {
            return list.BSearch(value, Comparer<T>.Default);
        }

        private static void QuickSortRecursion<T>(IList<T> listToSort, int leftIndex, int rightIndex, IComparer<T> comparer)
        {
            if (leftIndex < rightIndex)
            {
                int partitionPlace = QuickSortPartition(listToSort, leftIndex, rightIndex, comparer);

                QuickSortRecursion(listToSort, leftIndex, partitionPlace - 1, comparer);
                QuickSortRecursion(listToSort, partitionPlace + 1, rightIndex, comparer);
            }
        }

        private static int QuickSortPartition<T>(IList<T> listToSort, int leftIndex, int rightIndex, IComparer<T> comparer)
        {
            T pivot = listToSort[rightIndex];
            int indexToSwap = leftIndex;
            for (int j = leftIndex; j < rightIndex; j++)
            {
                if (comparer.Compare(listToSort[j], pivot) <= 0)
                {
                    T temp = listToSort[indexToSwap];
                    listToSort[indexToSwap] = listToSort[j];
                    listToSort[j] = temp;

                    indexToSwap++;
                }
            }

            T temp2 = listToSort[indexToSwap];
            listToSort[indexToSwap] = listToSort[rightIndex];
            listToSort[rightIndex] = temp2;

            return indexToSwap;
        }

        public static IList<T> QuickSort<T>(this IList<T> listToSort)
        {
            return listToSort.QuickSort(Comparer<T>.Default);
        }

        public static IList<T> QuickSort<T>(this IList<T> listToSort, IComparer<T> comparer)
        {
            QuickSortRecursion(listToSort, 0, listToSort.Count - 1, comparer);
            return listToSort;
        }

        public static IList<T> MergeSort<T>(this IList<T> listToSort, IComparer<T> comparer)
        {
            var linked = new LinkedList<T>();
            foreach (T item in listToSort)
            {
                linked.AddLast(item);
            }

            linked = MergeSortLinkedListRecursion(linked, comparer);

            int i = 0;
            foreach (T item in linked)
            {
                listToSort[i++] = item;
            }

            return listToSort;
        }

        private static LinkedList<T> MergeSortLinkedListRecursion<T>(LinkedList<T> list, IComparer<T> comparer)
        {
            if (list.Count <= 1) 
                return list;

            bool addLeft = true;
            var left = new LinkedList<T>();
            var right = new LinkedList<T>();
            foreach (T item in list)
            {
                if (addLeft)
                {
                    left.AddLast(item);
                    addLeft ^= true;
                }

                else
                {
                    right.AddLast(item);
                    addLeft ^= true;
                }
            }

            left = MergeSortLinkedListRecursion(left, comparer);
            right = MergeSortLinkedListRecursion(right, comparer);

            return MergeSortLinkedListMerge(left, right, comparer);
        }

        private static LinkedList<T> MergeSortLinkedListMerge<T>(LinkedList<T> left, LinkedList<T> right, IComparer<T> comparer)
        {
            var merged = new LinkedList<T>();
            while (left.Count != 0 && right.Count != 0)
            {
                if (comparer.Compare(left.First.Value, right.First.Value) <= 0)
                {
                    merged.AddLast(left.First.Value);
                    left.RemoveFirst();
                }

                else
                {
                    merged.AddLast(right.First.Value);
                    right.RemoveFirst();
                }
            }

            while (left.Count != 0)
            {
                merged.AddLast(left.First.Value);
                left.RemoveFirst();
            }

            while (right.Count != 0)
            {
                merged.AddLast(right.First.Value);
                right.RemoveFirst();
            }

            return merged;
        }

        public static IList<T> MergeSort<T>(this IList<T> listToSort)
        {
            return listToSort.MergeSort(Comparer<T>.Default);
        }
    }
}
